using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoImpestato
{
    public partial class FormSettings : Form
    {
        public int GridWidth { get; private set; }
        public int GridHeight { get; private set; }
        public int BombPercentage { get; private set; }

        public FormSettings(int currentWidth, int currentHeight, int currentBombPercentage)
        {
            InitializeComponent();

            // Imposta i valori iniziali
            numericWidth.Value = currentWidth;
            numericHeight.Value = currentHeight;
            numericBombPercentage.Value = currentBombPercentage;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Ottieni i valori inseriti dall'utente
            GridWidth = (int)numericWidth.Value;
            GridHeight = (int)numericHeight.Value;
            BombPercentage = (int)numericBombPercentage.Value;

            this.DialogResult = DialogResult.OK; // Chiudi il form con esito positivo
            this.Close();
        }
    }
}
