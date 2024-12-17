using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CampoImpestato
{
    public partial class Dimensioni : Form
    {
        public int Lunghezza { get; private set; }
        public int Larghezza { get; private set; }
        public int PercentualeBombe { get; private set; }

        public Dimensioni()
        {
            InitializeComponent();
        }


        private void BtnConferma_Click(object sender, EventArgs e)
        {
            try
            {
                //legge i valori dai TextBox e li assegna alle proprietà
                Lunghezza = int.Parse(txtBoxLunghezza.Text);
                Larghezza = int.Parse(txtBoxLarghezza.Text);
                PercentualeBombe = int.Parse(txtBoxPercentualeBombe.Text);

                //check dati se sono validi
                if (Lunghezza < 5 || Lunghezza > 50 || Larghezza < 5 || Larghezza > 50)
                {
                    //ritorna errore perchè le dimensioni devono essere tra 5 e 50
                    MessageBox.Show("Le dimensioni devono essere tra 5 e 50.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (PercentualeBombe < 5 || PercentualeBombe > 90)
                {
                    //ritorna errore perchè la percentuale di bombe deve essere tra 5% e 90%
                    MessageBox.Show("La percentuale di bombe deve essere tra 5% e 90%.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.DialogResult = DialogResult.OK; //chiude il form
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserisci valori numerici validi.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBarBombe_Scroll(object sender, EventArgs e)
        {
            // Aggiorna il valore della TextBox con il valore della TrackBar
            txtBoxPercentualeBombe.Text = trackBarBombe.Value.ToString();
        }

        private void trackBarAltezza_Scroll(object sender, EventArgs e)
        {
            // Aggiorna il valore della TextBox con il valore della TrackBar
            txtBoxLarghezza.Text = trackBarAltezza.Value.ToString();
        }

        private void trackBarLunghezza_Scroll(object sender, EventArgs e)
        {
            // Aggiorna il valore della TextBox con il valore della TrackBar
            txtBoxLunghezza.Text = trackBarLunghezza.Value.ToString();
        }

    }
}
