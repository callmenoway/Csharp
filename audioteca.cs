using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Audioteca
{
    public partial class Form1 : Form
    {
        FileStream fs = new FileStream("./config.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            fs.Close();
            // Chiedere conferma all'utente
            if (MessageBox.Show("Vuoi creare un nuovo archivio?",
                "Conferma creazione:",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                //cancella il file esistente e creane uno nuovo
                try
                {
                    //controlla se il file esiste e lo elimina
                    if (File.Exists("./config.dat"))
                    {
                        File.Delete("./config.dat");
                    }

                    //ricrea il file vuoto
                    using (FileStream newFileStream = new FileStream("./config.dat", FileMode.Create, FileAccess.Write))
                    {
                        MessageBox.Show("Archivio creato con successo.", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante la creazione dell'archivio: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                fs.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            fs.Close();

            try
            {
                using (FileStream localFs = new FileStream("./config.dat", FileMode.Append, FileAccess.Write, FileShare.None))
                using (BinaryWriter bw = new BinaryWriter(localFs))
                {
                    //ottieni i valori dagli input dell'utente
                    long codiceOpera = Convert.ToInt64(txt_codice.Value);
                    string artista = txt_artista.Text;
                    string titolo = txt_titolo.Text;
                    string genere = txt_genere.Text;
                    DateTime dataRegistrazione = dateTimePicker1.Value;
                    string tipoSupporto = txt_tipo.SelectedItem.ToString();
                    bool danneggiato = chk_danneggiato.Checked;

                    //scrivi i dati nel file binario
                    bw.Write(codiceOpera);
                    bw.Write(artista);
                    bw.Write(titolo);
                    bw.Write(genere);
                    bw.Write(dataRegistrazione.ToString("dd/MM/yyyy"));
                    bw.Write(tipoSupporto);
                    bw.Write(danneggiato);

                    //resetta tutti i campi del modulo
                    txt_codice.Value = 0; 
                    txt_artista.Text = "";
                    txt_titolo.Text = ""; 
                    txt_genere.Text = ""; 
                    dateTimePicker1.Value = DateTime.Now;
                    txt_tipo.SelectedIndex = -1;
                    chk_danneggiato.Checked = false;

                    //conferma all'utente
                    MessageBox.Show("Opera aggiunta con successo.", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'aggiunta dell'opera: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            //mostra la finestra di conferma
            var dialogResult = MessageBox.Show("Vuoi visualizzare tutte le opere?",
                                               "Conferma Visualizzazione",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                //se l'utente sceglie "Sì", visualizza tutte le opere
                CaricaTutteLeOpere();
            }
            else if (dialogResult == DialogResult.No)
            {
                //se l'utente sceglie "No", mostra una finestra di input personalizzata
                string artista = MostraInputBox("Inserisci il nome dell'artista:", "Ricerca per Artista");

                if (!string.IsNullOrWhiteSpace(artista))
                {
                    RicercaPerArtista(artista);
                }
            }
        }

        private string MostraInputBox(string prompt, string titolo)
        {
            Form inputBox = new Form()
            {
                Width = 400,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titolo,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label label = new Label() { Left = 20, Top = 20, Text = prompt, Width = 350 };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 350 };
            Button conferma = new Button() { Text = "Conferma", Left = 270, Width = 100, Top = 100, DialogResult = DialogResult.OK };
            Button annulla = new Button() { Text = "Annulla", Left = 150, Width = 100, Top = 100, DialogResult = DialogResult.Cancel };

            inputBox.Controls.Add(label);
            inputBox.Controls.Add(textBox);
            inputBox.Controls.Add(conferma);
            inputBox.Controls.Add(annulla);

            inputBox.AcceptButton = conferma;
            inputBox.CancelButton = annulla;

            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                return textBox.Text;
            }
            else
            {
                return string.Empty;
            }
        }

        private void CaricaTutteLeOpere()
        {
            try
            {
                //lista temporanea per contenere i dati
                var listaOpere = new List<dynamic>();

                //apri il file in modalità lettura
                using (FileStream fs = new FileStream("./config.dat", FileMode.OpenOrCreate, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    //leggi i dati dal file finché ci sono record
                    while (fs.Position < fs.Length)
                    {
                        long codiceOpera = br.ReadInt64();
                        string artista = br.ReadString();
                        string titolo = br.ReadString();
                        string genere = br.ReadString();
                        string dataRegistrazione = br.ReadString();
                        string tipoSupporto = br.ReadString();
                        bool danneggiato = br.ReadBoolean();

                        //aggiungi i dati alla lista
                        listaOpere.Add(new
                        {
                            Codice = codiceOpera,
                            Artista = artista,
                            Titolo = titolo,
                            Genere = genere,
                            DataRegistrazione = dataRegistrazione,
                            TipoSupporto = tipoSupporto,
                            Danneggiato = danneggiato
                        });
                    }
                }

                //assegna la lista al DataGridView
                Tabella.DataSource = listaOpere;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento delle opere: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RicercaPerArtista(string artistaCercato)
        {
            try
            {
                //lista temporanea per contenere i dati filtrati
                var listaOpereFiltrate = new List<dynamic>();

                //apri il file in modalità lettura
                using (FileStream fs = new FileStream("./config.dat", FileMode.OpenOrCreate, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    //leggi i dati dal file finché ci sono record
                    while (fs.Position < fs.Length)
                    {
                        long codiceOpera = br.ReadInt64();
                        string artista = br.ReadString();
                        string titolo = br.ReadString();
                        string genere = br.ReadString();
                        string dataRegistrazione = br.ReadString();
                        string tipoSupporto = br.ReadString();
                        bool danneggiato = br.ReadBoolean();

                        //controlla se il nome dell'artista corrisponde
                        if (artista.Equals(artistaCercato, StringComparison.OrdinalIgnoreCase))
                        {
                            //aggiungi alla lista filtrata
                            listaOpereFiltrate.Add(new
                            {
                                Codice = codiceOpera,
                                Artista = artista,
                                Titolo = titolo,
                                Genere = genere,
                                DataRegistrazione = dataRegistrazione,
                                TipoSupporto = tipoSupporto,
                                Danneggiato = danneggiato
                            });
                        }
                    }
                }

                //se sono stati trovati risultati, aggiorna il DataGridView
                if (listaOpereFiltrate.Count > 0)
                {
                    Tabella.DataSource = listaOpereFiltrate;
                }
                else
                {
                    MessageBox.Show("Nessuna opera trovata per l'artista specificato.",
                                    "Ricerca Vuota",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la ricerca: {ex.Message}",
                                "Errore",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {

        }
    }
}
