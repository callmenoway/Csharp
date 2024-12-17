using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Media;

namespace CampoImpestato
{
    public partial class CampoImpestato : Form
    {
        private Size gridSize = Config.GridSize; //dimensioni della griglia di gioco
        private int cellSize = Config.CellSize; //dimensione delle celle
        private double percentualeBombe = Config.PercentualeBombe; //percentuale bombe
        private SoundPlayer clickSound = new SoundPlayer(Config.ClickSoundPath); //percorsi dei suoni
        private SoundPlayer flagSound = new SoundPlayer(Config.FlagSoundPath); //percorsi dei suoni

        private bool timerIniziato = false; //stato del timer
        int timer = 0;
        private List<int> currentBombIndices = new List<int>(); //memorizza la posizione delle bombe

        public CampoImpestato()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bombsIndices = GenerateBombs(); //indici delle celle con le bombe

            //liste per i pulsanti e le etichette create
            var buttons = new List<MyButton>();
            var labels = new List<Label>();

            //creiamo tutte le celle (pulsanti e etichette)
            for (int i = 0; i < gridSize.Width; i++)
            {
                for (int j = 0; j < gridSize.Height; j++)
                {
                    var button = CreateButton(i, j);
                    buttons.Add(button);

                    var label = CreateLabel(i, j);
                    labels.Add(label);

                    panelCampoGioco.Controls.Add(button);
                    panelCampoGioco.Controls.Add(label);

                    //aggiungi la bomba alla cella se necessario
                    SetBomb(button, bombsIndices, i, j);
                }
            }

            //dopo aver creato tutte le celle, calcoliamo le bombe vicine
            UpdateLabelsWithAdjacentBombs(labels);
        }

        private List<int> GenerateBombs()
        {
            var allPositions = Enumerable.Range(0, gridSize.Width * gridSize.Height).ToList();
            int bombsCount = (int)Math.Ceiling(allPositions.Count * percentualeBombe);
            Random rand = new Random();

            currentBombIndices = allPositions.OrderBy(x => rand.Next()).Take(bombsCount).ToList();
            return currentBombIndices;
        }

        private void ReplayGame()
        {
            panelCampoGioco.Controls.Clear();
            timer = 0;
            labelTimer.Text = "0";
            timer1.Stop();
            timerIniziato = false;

            var buttons = new List<MyButton>();
            var labels = new List<Label>();

            for (int i = 0; i < gridSize.Width; i++)
            {
                for (int j = 0; j < gridSize.Height; j++)
                {
                    var button = CreateButton(i, j);
                    buttons.Add(button);

                    var label = CreateLabel(i, j);
                    labels.Add(label);

                    panelCampoGioco.Controls.Add(button);
                    panelCampoGioco.Controls.Add(label);

                    //usa le bombe salvate
                    SetBomb(button, currentBombIndices, i, j);
                }
            }

            UpdateLabelsWithAdjacentBombs(labels);
        }

        private MyButton CreateButton(int i, int j)
        {
            var button = new MyButton
            {
                Location = new Point(i * cellSize, j * cellSize),
                Size = new Size(cellSize, cellSize),
                UseVisualStyleBackColor = true,
                Tag = new Point(i, j) //associa la posizione della cella
            };

            button.Click += OnCellClick; //gestore dell'evento di clic sinistro mouse
            button.MouseUp += OnCellRightClick; //gestore dell'evento di clic destro mouse

            return button;
        }

        private Label CreateLabel(int i, int j)
        {
            var label = new Label
            {
                Location = new Point(i * cellSize, j * cellSize),
                Size = new Size(cellSize, cellSize),
                Font = new Font("Arial", 30, FontStyle.Bold),
                Tag = new Point(i, j) //associa la posizione della cella
            };

            return label;
        }

        private void SetBomb(MyButton button, List<int> bombIndices, int i, int j)
        {
            int index = j * gridSize.Width + i;
            button.HaBomba = bombIndices.Contains(index); //imposta se c'è una bomba
        }

        private Label FindLabel(Point position)
        {
            //cerca la label associata alla posizione specifica (tag)
            return panelCampoGioco.Controls
                .OfType<Label>()
                .FirstOrDefault(l => ((Point)l.Tag).X == position.X && ((Point)l.Tag).Y == position.Y);
        }


        private void UpdateLabelsWithAdjacentBombs(List<Label> labels)
        {
            foreach (var label in labels)
            {
                var position = (Point)label.Tag;
                int x = position.X;
                int y = position.Y;

                var button = FindButton(x, y); //trova il MyButton corrispondente

                if (button.HaBomba)
                {
                    //se c'è una bomba, imposta l'immagine e il colore di sfondo
                    label.Image = Image.FromFile("Resources/bomb.png");
                    label.BackColor = Color.Red;
                }
                else
                {
                    int nearbyBombs = CountNearbyBombs(x, y); //calcola le bombe vicine
                    label.Text = nearbyBombs.ToString();
                }
            }
        }

        private int CountNearbyBombs(int x, int y)
        {
            int nearbyBombs = 0;

            //scorre le 8 direzioni attorno alla cella
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    //evita la cella corrente
                    if (dx == 0 && dy == 0) continue;

                    int nx = x + dx;
                    int ny = y + dy;

                    //verifica se la cella vicina è all'interno dei limiti della griglia
                    if (nx >= 0 && nx < gridSize.Width && ny >= 0 && ny < gridSize.Height)
                    {
                        var nearbyButton = FindButton(nx, ny);
                        if (nearbyButton != null && nearbyButton.HaBomba)
                        {
                            nearbyBombs++;
                        }
                    }
                }
            }

            return nearbyBombs;
        }
        private MyButton FindButton(int x, int y)
        {
            //scorre tutti i controlli nel panel per trovare il pulsante corrispondente
            return panelCampoGioco.Controls
                .OfType<MyButton>()
                .FirstOrDefault(b => ((Point)b.Tag).X == x && ((Point)b.Tag).Y == y);
        }

        public class MyButton : Button
        {
            public bool HaBomba { get; set; } //indica se c'è una bomba
            public bool HasFlag { get; set; } //indica se c'è una bandierina
        }


        private void OnCellRightClick(object sender, MouseEventArgs e)
        {
            flagSound.Play(); //suono quando si mette una bandierina
            if (e.Button == MouseButtons.Right)
            {
                var button = (MyButton)sender;

                //imposta o rimuove la bandierina
                if (!button.HasFlag)
                {
                    button.BackgroundImage = Image.FromFile("Resources/flag.png");
                    button.BackgroundImageLayout = ImageLayout.Stretch;
                    button.HasFlag = true; //indica che il pulsante ha una bandierina
                }
                else
                {
                    button.BackgroundImage = null; //rimuovi l'immagine della bandierina
                    button.HasFlag = false;
                }
            }
        }

        private void OnCellClick(object sender, EventArgs e)
        {
            clickSound.Play(); //suono quando si clicca su una cella
            var button = (MyButton)sender;

            //ignora il clic se c'è una bandierina
            if (button.HasFlag) return;

            //avvia il timer se non è già partito
            if (!timerIniziato)
            {
                timer1.Start();
                timerIniziato = true;
            }

            button.Visible = false; //nascondi il pulsante quando cliccato

            var label = FindLabel((Point)button.Tag);

            if (button.HaBomba)
            {
                //se clicchi su una bomba, finisce il gioco
                timer1.Stop();
                foreach (var k in panelCampoGioco.Controls.OfType<MyButton>())
                {
                    k.Visible = false; //nasconde tutte le celle
                }
            }
            else
            {
                if (label.Text == "0")
                {
                    OpenAdjacentCells((Point)button.Tag);
                }

                //controlla se il giocatore ha vinto
                if (CheckWinCondition())
                {
                    timer1.Stop();
                    MessageBox.Show("Hai vinto!", "Vittoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetGame(); //resetta il gioco dopo la vittoria
                }
            }
        }



        private void OpenAdjacentCells(Point position)
        {
            int x = position.X;
            int y = position.Y;

            //scorri le 8 direzioni attorno alla cella
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    //evita la cella corrente
                    if (dx == 0 && dy == 0) continue;

                    int nx = x + dx;
                    int ny = y + dy;

                    //verifica se la cella vicina è all'interno dei limiti della griglia
                    if (nx >= 0 && nx < gridSize.Width && ny >= 0 && ny < gridSize.Height)
                    {
                        var nearbyButton = FindButton(nx, ny);
                        var nearbyLabel = FindLabel(new Point(nx, ny));

                        //se il pulsante è già nascosto o ha una bandierina lo ignora
                        if (nearbyButton == null || !nearbyButton.Visible || nearbyButton.HasFlag) continue;

                        //nascondi il pulsante per rivelare la label
                        nearbyButton.Visible = false;

                        //se la cella vicina ha valore "0" richiama la funzione per aprire le celle vicine
                        if (nearbyLabel.Text == "0")
                        {
                            OpenAdjacentCells(new Point(nx, ny));
                        }
                    }
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            labelTimer.Text = timer.ToString();
        }

        private void ResetGame()
        {
            panelCampoGioco.Controls.Clear(); //rimuovi tutti i controlli esistenti
            timer = 0; //resetta il timer
            labelTimer.Text = "0"; //aggiorna il timer visivamente
            timer1.Stop(); //ferma il timer
            timerIniziato = false; //resetta lo stato del timer
            var bombsIndices = GenerateBombs(); //ricrea le bombe con la nuova percentuale

            //ricrea i pulsanti e le etichette
            var buttons = new List<MyButton>();
            var labels = new List<Label>();

            for (int i = 0; i < gridSize.Width; i++)
            {
                for (int j = 0; j < gridSize.Height; j++)
                {
                    var button = CreateButton(i, j);
                    buttons.Add(button);

                    var label = CreateLabel(i, j);
                    labels.Add(label);

                    panelCampoGioco.Controls.Add(button);
                    panelCampoGioco.Controls.Add(label);

                    //aggiungi la bomba alla cella se necessario
                    SetBomb(button, bombsIndices, i, j);
                }
            }

            //aggiorna le etichette con il conteggio delle bombe vicine
            UpdateLabelsWithAdjacentBombs(labels);

            int larghezzaForm = gridSize.Width * cellSize + 10; //larghezza del form
            int altezzaForm = gridSize.Height * cellSize + 110; //altezza del form
            this.ClientSize = new Size(larghezzaForm, altezzaForm); //dimensione del form
        }



        private void ResetBtn_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private bool CheckWinCondition()
        {
            //controlla se tutte le celle senza bombe sono state scoperte
            int totalNonBombCells = 0;
            int revealedNonBombCells = 0;

            foreach (var button in panelCampoGioco.Controls.OfType<MyButton>())
            {
                var label = FindLabel((Point)button.Tag);
                if (!button.HaBomba)
                {
                    totalNonBombCells++; //conta tutte le celle senza bomba
                    if (!button.Visible)
                    {
                        revealedNonBombCells++; //conta quante celle senza bomba sono state scoperte
                    }
                }
            }

            return totalNonBombCells == revealedNonBombCells; //se il numero di celle scoperte senza bomba è uguale al totale il giocatore ha vinto
        }


        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dimensioniForm = new Dimensioni())
            {
                if (dimensioniForm.ShowDialog() == DialogResult.OK)
                {
                    //aggiorna le dimensioni della griglia e la percentuale delle bombe
                    gridSize = new Size(dimensioniForm.Larghezza, dimensioniForm.Lunghezza);
                    percentualeBombe = dimensioniForm.PercentualeBombe / 100.0;

                    //reset del gioco con le nuove impostazioni
                    ResetGame();
                }
            }
        }

        private void importaImpostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //usa il dialogo di apertura per selezionare il file XML da importare
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files|*.xml",
                Title = "Importa Impostazioni"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //deserializza il file XML nelle impostazioni del gioco
                    using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        var serializer = new XmlSerializer(typeof(GameSettings));
                        var settings = (GameSettings)serializer.Deserialize(stream);

                        //imposta le nuove dimensioni della griglia e la percentuale delle bombe
                        gridSize = new Size(settings.Larghezza, settings.Lunghezza);
                        percentualeBombe = settings.PercentualeBombe / 100.0; //imposta la percentuale delle bombe

                        //reset del gioco con le nuove impostazioni
                        ResetGame();

                        MessageBox.Show("Impostazioni importate con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'importazione: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void esportaImpostazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //crea l'oggetto delle impostazioni
            var settings = new GameSettings
            {
                Lunghezza = gridSize.Height,
                Larghezza = gridSize.Width,
                PercentualeBombe = percentualeBombe * 100 //percentuale delle bombe
            };

            //usa il dialogo di salvataggio per selezionare il percorso del file XML
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "XML Files|*.xml",
                Title = "Esporta Impostazioni"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //serializza l'oggetto delle impostazioni in un file XML
                    using (var stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        var serializer = new XmlSerializer(typeof(GameSettings));
                        serializer.Serialize(stream, settings);
                        MessageBox.Show("Impostazioni esportate con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errore durante l'esportazione: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //mostra una finestra di conferma
            var result = MessageBox.Show("Sei sicuro di voler uscire?", "Conferma uscita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //se l'utente clicca si chiudi l'applicazione
            if (result == DialogResult.Yes)
            {
                Application.Exit(); //chiude l'applicazione
            }
        }

        private void replayPartitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplayGame();
        }
    }
}
