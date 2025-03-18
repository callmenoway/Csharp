using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using NAudio.Wave;

namespace PlayerAudio
{
    public partial class Main : Form
    {
        private List<Canzone> canzoneList = new List<Canzone>();
        private WaveOutEvent waveOut;
        private AudioFileReader audioFileReader;
        private Random random = new Random();
        private Timer timer = new Timer();
        private int counter = -1;
        private bool loopAttivo = false;
        public Main()
        {
            InitializeComponent(); //inizializza tutti i componenti
            listaCanzoni.DoubleClick += LbxLista_DoubleClick;
            listaCanzoni.KeyDown += LbxLista_KeyDown;
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            numericUpDownDurata.Minimum = 0;
            numericUpDownDurata.Maximum = 1000;
            numericUpDownDurata.Increment = 10;
            btnFiltri.Click += btnFiltri_Click;
            Volume.Scroll += Volume_Scroll; //evento per il volume
            btnLoop.Image = Image.FromFile("Resources/loop.png");
            btnPlay.Image = Image.FromFile("Resources/play.png");
            btnCasuale.Image = Image.FromFile("Resources/casuale.png");
            btnPrima.Image = Image.FromFile("Resources/skipPrevious.png");
            btnPrecedente.Image = Image.FromFile("Resources/arrowBack.png");
            btnSuccessiva.Image = Image.FromFile("Resources/arrowForward.png");
            btnUltima.Image = Image.FromFile("Resources/skipForward.png");
            btnAll.Image = Image.FromFile("Resources/all.png");
            btnFiltri.Image = Image.FromFile("Resources/filtri.png");
            btnCarica.Image = Image.FromFile("Resources/carica.png");
            btnSfoglia.Image = Image.FromFile("Resources/sfoglia.png");
        }

        //durata file audio
        static double Durata(string filePath)
        {
            try
            {
                var tagFile = TagLib.File.Create(filePath);
                return tagFile.Properties.Duration.TotalSeconds;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel calcolo della durata del file: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        //aggiorna la visualizzazione della playlist
        private void AggiornaPlaylist()
        {
            listaCanzoni.Items.Clear(); //pulisce la lista
            foreach (var canzone in canzoneList)
            {
                listaCanzoni.Items.Add(canzone.ToString()); //aggiunge le canzoni alla lista
            }
        }

        //funzione per aggiornare la progress bar e la durata della canzone
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                progBar.Value = Math.Min((int)audioFileReader.CurrentTime.TotalSeconds, progBar.Maximum); //aggiorna la progress bar
                lblVisualizzaDurata.Text = $"{(int)audioFileReader.CurrentTime.TotalSeconds}/{(int)audioFileReader.TotalTime.TotalSeconds}"; //aggiorna la durata
            }
        }

        //funzione per riprodurre la traccia selezionata
        private void RiproduciTraccia(int indice)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }

            //verifica che l'indice sia valido
            if (indice >= 0 && indice < canzoneList.Count)
            {
                var canzone = canzoneList[indice];
                //informazioni della traccia
                lblVisualizzaTitolo.Text = canzone.Titolo;
                lblVisuallizzaAuto.Text = canzone.Autore;
                lblVisuallizzaNomeFile.Text = canzone.PercorsoFile;
                progBar.Maximum = canzone.Durata;
                progBar.Value = 0;

                //start della riproduzione
                audioFileReader = new AudioFileReader(canzone.PercorsoFile);
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);
                waveOut.Play();

                waveOut.PlaybackStopped += (s, e) =>
                {
                    if (loopAttivo)
                    {
                        RiproduciTraccia(indice); // Riproduce di nuovo la traccia se il loop è attivo
                    }
                };

                timer.Start();
                btnPlay.Image = Image.FromFile("Resources/pause.png");

            }

        }

        //pulsante per sfogliare gli elementi locali e selezionare la canzone
        private void btnSfoglia_Click(object sender, EventArgs e)
        {
            //apre finestra esplora file con dei filtri per i file audio
            OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "File Audio|*.mp3;*.wav;*.aac;*.flac" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //recupera le informazioni del file selezionato
                FileInfo fileInfo = new FileInfo(openFileDialog.FileName);

                txtAutoreAgg.Text = (TagLib.File.Create(openFileDialog.FileName)).Tag.FirstAlbumArtist;
                txtNomeFileAgg.Text = fileInfo.FullName;
                txtTitoloAgg.Text = fileInfo.Name;
                numericUpDownDurata.Value = Math.Min((int)Durata(openFileDialog.FileName), numericUpDownDurata.Maximum);
                btnCarica.Visible = true;
            }
        }

        //pulsante che carica la canzone nella playlist
        private void btnCarica_Click(object sender, EventArgs e)
        {
            //controlla che tutti i campi siano stati compilati
            if (string.IsNullOrWhiteSpace(txtTitoloAgg.Text) || string.IsNullOrWhiteSpace(txtAutoreAgg.Text) || string.IsNullOrWhiteSpace(txtNomeFileAgg.Text))
            {
                MessageBox.Show("Tutti i campi devono essere compilati!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //crea un oggetto canzone e lo aggiunge alla lista
            Canzone c = new Canzone(
                (UInt16)numericUpDownDurata.Value,
                txtTitoloAgg.Text,
                txtAutoreAgg.Text,
                txtNomeFileAgg.Text
            );
            canzoneList.Add(c);
            AggiornaPlaylist();

            //pulisce i campi dopo l'aggiunta e azzera il valore della durata
            txtAutoreAgg.Clear();
            txtTitoloAgg.Clear();
            txtNomeFileAgg.Clear();
            numericUpDownDurata.Value = 0;
        }

        //cancellazione canzone dalla playlist
        private void LbxLista_KeyDown(object sender, KeyEventArgs e)
        {
            //verifica che sia stata selezionata una canzone e che sia stato premuto il tasto delete
            if (e.KeyCode == Keys.Delete && listaCanzoni.SelectedIndex >= 0)
            {
                canzoneList.RemoveAt(listaCanzoni.SelectedIndex); //rimuove la canzone selezionata
                AggiornaPlaylist(); //aggiorna la visualizzazione della playlist
            }
        }

        //riproduzione canzone
        private void LbxLista_DoubleClick(object sender, EventArgs e)
        {
            //verifica che sia stata selezionata una canzone
            if (listaCanzoni.SelectedIndex >= 0)
            {
                RiproduciTraccia(listaCanzoni.SelectedIndex); //riproduce la canzone selezionata
            }
        }

        //selezione canzone
        private void listaCanzoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verifica che sia stata selezionata una canzone
            if (listaCanzoni.SelectedIndex >= 0 && listaCanzoni.SelectedIndex < canzoneList.Count)
            {
                RiproduciTraccia(listaCanzoni.SelectedIndex); //riproduce la canzone selezionata
            }
        }

        //pulsante per la riproduzione
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //verifica se la canzone è in riproduzione
            if (waveOut != null && waveOut.PlaybackState == PlaybackState.Playing)
            {
                waveOut.Pause(); //mette in pausa la canzone
                timer.Stop(); //ferma il timer
                btnPlay.Image = Image.FromFile("Resources/play.png");

            }
            else if (waveOut != null) //verifica se la canzone è in pausa
            {
                waveOut.Play();
                timer.Start();
                btnPlay.Image = Image.FromFile("Resources/pause.png");
            }
        }

        //pulsante canzone precedente
        private void btnPrecedente_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                listaCanzoni.SelectedIndex = counter;
                RiproduciTraccia(counter);
            }
        }

        //pulsante prima caznone della playlist
        private void btnPrima_Click(object sender, EventArgs e)
        {
            if (canzoneList.Count > 0)
            {
                listaCanzoni.SelectedIndex = 0;
                RiproduciTraccia(0);
            }
        }

        //pulsante canzone successiva
        private void btnSuccessiva_Click(object sender, EventArgs e)
        {
            if (counter < canzoneList.Count - 1)
            {
                counter++;
                listaCanzoni.SelectedIndex = counter;
                RiproduciTraccia(counter);
            }
        }

        //pulsante ultima canzone
        private void btnUltima_Click(object sender, EventArgs e)
        {
            //verifica che ci siano canzoni nella playlist
            if (canzoneList.Count > 0)
            {
                listaCanzoni.SelectedIndex = canzoneList.Count - 1;
                RiproduciTraccia(canzoneList.Count - 1);
            }
        }

        //pulsante elimina filtri
        private void btnAll_Click(object sender, EventArgs e)
        {
            txtContenente.Clear(); //pulisce il campo di ricerca
            AggiornaPlaylist(); //aggiorna la visualizzazione della playlist
        }

        //pulsante per i filtri
        private void btnFiltri_Click(object sender, EventArgs e)
        {
            //imposta i valori minimi e massimi per la durata
            txtDurataMinima.Minimum = 0;
            txtDurataMinima.Maximum = 1000;
            int durataMinima = (int)txtDurataMinima.Value;
            string filtro = txtContenente.Text.Trim().ToLower();
            listaCanzoni.Items.Clear(); //pulisce la lista

            //scorre tutte le canzoni
            foreach (var canzone in canzoneList)
            {
                //verifica che il filtro sia presente nel titolo o nell'autore e che la durata sia maggiore o uguale a quella immessa
                if ((canzone.Titolo.ToLower().Contains(filtro) || canzone.Autore.ToLower().Contains(filtro)) && canzone.Durata >= durataMinima)
                {
                    listaCanzoni.Items.Add(canzone.ToString()); //aggiunge la canzone alla lista
                }
            }
            if (listaCanzoni.Items.Count == 0)
            {
                MessageBox.Show("Nessuna canzone trovata secondo il filtro immesso.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //funzione custom per la riproduzione casuale
        private void btnRipCasuale_Click(object sender, EventArgs e)
        {
            if (canzoneList.Count > 0)
            {
                listaCanzoni.SelectedIndex = random.Next(canzoneList.Count); //seleziona una canzone casuale
                RiproduciTraccia(counter); //riproduce la canzone selezionata
            }
        }

        //funzione custom per il loop
        private void btnLoop_Click(object sender, EventArgs e)
        {
            loopAttivo = !loopAttivo;

            if (loopAttivo)
            {
                btnLoop.Image = Image.FromFile("Resources/loopOn.png");
            }
            else
            {
                btnLoop.Image = Image.FromFile("Resources/loop.png");
            }
        }

        //funzione custom per il volume
        private void Volume_Scroll(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                float volume = Volume.Value / 100f;
                waveOut.Volume = volume;
            }
        }

    }
}
