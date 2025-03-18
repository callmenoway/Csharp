using System.Drawing;

namespace PlayerAudio
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTitolo = new System.Windows.Forms.Panel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.panelVisuale = new System.Windows.Forms.Panel();
            this.lblVolume = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.btnLoop = new System.Windows.Forms.Button();
            this.lblVisualizzaDurata = new System.Windows.Forms.Label();
            this.btnCasuale = new System.Windows.Forms.Button();
            this.PanelTitolo2 = new System.Windows.Forms.Panel();
            this.lblListaCanzoni = new System.Windows.Forms.Label();
            this.btnPrima = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrecedente = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.btnSuccessiva = new System.Windows.Forms.Button();
            this.lblVisuallizzaNomeFile = new System.Windows.Forms.Label();
            this.lblVisuallizzaAuto = new System.Windows.Forms.Label();
            this.lblVisualizzaTitolo = new System.Windows.Forms.Label();
            this.btnUltima = new System.Windows.Forms.Button();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lblNomeFile = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.panelInserimento = new System.Windows.Forms.Panel();
            this.lblTitoloAdd = new System.Windows.Forms.Label();
            this.pannelloAggiunta = new System.Windows.Forms.Panel();
            this.txtAutoreAgg = new System.Windows.Forms.TextBox();
            this.numericUpDownDurata = new System.Windows.Forms.NumericUpDown();
            this.txtNomeFileAgg = new System.Windows.Forms.TextBox();
            this.txtTitoloAgg = new System.Windows.Forms.TextBox();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnSfoglia = new System.Windows.Forms.Button();
            this.panelTitolo4 = new System.Windows.Forms.Label();
            this.lblAutoreAdd = new System.Windows.Forms.Label();
            this.lblDurataAdd = new System.Windows.Forms.Label();
            this.lblNomeFileAdd = new System.Windows.Forms.Label();
            this.panelFIltri = new System.Windows.Forms.Panel();
            this.panelTitolo3 = new System.Windows.Forms.Panel();
            this.lblFiltri = new System.Windows.Forms.Label();
            this.btnFiltri = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.txtDurataMinima = new System.Windows.Forms.NumericUpDown();
            this.lblDurataMinima = new System.Windows.Forms.Label();
            this.lblContieneTesto = new System.Windows.Forms.Label();
            this.txtContenente = new System.Windows.Forms.TextBox();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.listaCanzoni = new System.Windows.Forms.ListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTitolo.SuspendLayout();
            this.panelVisuale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.PanelTitolo2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelInserimento.SuspendLayout();
            this.pannelloAggiunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurata)).BeginInit();
            this.panelFIltri.SuspendLayout();
            this.panelTitolo3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurataMinima)).BeginInit();
            this.panelListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitolo
            // 
            this.panelTitolo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTitolo.Controls.Add(this.lblPlayer);
            this.panelTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitolo.Location = new System.Drawing.Point(0, 0);
            this.panelTitolo.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitolo.Name = "panelTitolo";
            this.panelTitolo.Size = new System.Drawing.Size(804, 40);
            this.panelTitolo.TabIndex = 0;
            // 
            // lblPlayer
            // 
            this.lblPlayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(364, 12);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(79, 20);
            this.lblPlayer.TabIndex = 2;
            this.lblPlayer.Text = "PLAYER";
            // 
            // panelVisuale
            // 
            this.panelVisuale.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelVisuale.Controls.Add(this.lblVolume);
            this.panelVisuale.Controls.Add(this.Volume);
            this.panelVisuale.Controls.Add(this.btnLoop);
            this.panelVisuale.Controls.Add(this.lblVisualizzaDurata);
            this.panelVisuale.Controls.Add(this.btnCasuale);
            this.panelVisuale.Controls.Add(this.PanelTitolo2);
            this.panelVisuale.Controls.Add(this.btnPrima);
            this.panelVisuale.Controls.Add(this.btnPlay);
            this.panelVisuale.Controls.Add(this.btnPrecedente);
            this.panelVisuale.Controls.Add(this.panel4);
            this.panelVisuale.Controls.Add(this.btnSuccessiva);
            this.panelVisuale.Controls.Add(this.lblVisuallizzaNomeFile);
            this.panelVisuale.Controls.Add(this.lblVisuallizzaAuto);
            this.panelVisuale.Controls.Add(this.lblVisualizzaTitolo);
            this.panelVisuale.Controls.Add(this.btnUltima);
            this.panelVisuale.Controls.Add(this.lblDurata);
            this.panelVisuale.Controls.Add(this.lblNomeFile);
            this.panelVisuale.Controls.Add(this.lblAutore);
            this.panelVisuale.Controls.Add(this.lblTitolo);
            this.panelVisuale.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVisuale.Location = new System.Drawing.Point(0, 40);
            this.panelVisuale.Margin = new System.Windows.Forms.Padding(2);
            this.panelVisuale.Name = "panelVisuale";
            this.panelVisuale.Size = new System.Drawing.Size(804, 195);
            this.panelVisuale.TabIndex = 1;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(349, 101);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 16;
            this.lblVolume.Text = "Volume";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(293, 117);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(150, 45);
            this.Volume.TabIndex = 15;
            this.Volume.TickFrequency = 10;
            this.Volume.Value = 50;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(222, 103);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(31, 31);
            this.btnLoop.TabIndex = 14;
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // lblVisualizzaDurata
            // 
            this.lblVisualizzaDurata.Location = new System.Drawing.Point(86, 135);
            this.lblVisualizzaDurata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisualizzaDurata.Name = "lblVisualizzaDurata";
            this.lblVisualizzaDurata.Size = new System.Drawing.Size(75, 19);
            this.lblVisualizzaDurata.TabIndex = 13;
            // 
            // btnCasuale
            // 
            this.btnCasuale.Location = new System.Drawing.Point(257, 103);
            this.btnCasuale.Margin = new System.Windows.Forms.Padding(2);
            this.btnCasuale.Name = "btnCasuale";
            this.btnCasuale.Size = new System.Drawing.Size(31, 31);
            this.btnCasuale.TabIndex = 12;
            this.btnCasuale.UseVisualStyleBackColor = true;
            this.btnCasuale.Click += new System.EventHandler(this.btnRipCasuale_Click);
            // 
            // PanelTitolo2
            // 
            this.PanelTitolo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelTitolo2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PanelTitolo2.Controls.Add(this.lblListaCanzoni);
            this.PanelTitolo2.Location = new System.Drawing.Point(0, 164);
            this.PanelTitolo2.Name = "PanelTitolo2";
            this.PanelTitolo2.Size = new System.Drawing.Size(804, 31);
            this.PanelTitolo2.TabIndex = 8;
            // 
            // lblListaCanzoni
            // 
            this.lblListaCanzoni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblListaCanzoni.AutoSize = true;
            this.lblListaCanzoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCanzoni.Location = new System.Drawing.Point(330, 7);
            this.lblListaCanzoni.Name = "lblListaCanzoni";
            this.lblListaCanzoni.Size = new System.Drawing.Size(142, 20);
            this.lblListaCanzoni.TabIndex = 1;
            this.lblListaCanzoni.Text = "LISTA CANZONI";
            // 
            // btnPrima
            // 
            this.btnPrima.Location = new System.Drawing.Point(47, 103);
            this.btnPrima.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrima.Name = "btnPrima";
            this.btnPrima.Size = new System.Drawing.Size(31, 31);
            this.btnPrima.TabIndex = 7;
            this.btnPrima.UseVisualStyleBackColor = true;
            this.btnPrima.Click += new System.EventHandler(this.btnPrima_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(117, 103);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(31, 31);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrecedente
            // 
            this.btnPrecedente.Location = new System.Drawing.Point(82, 103);
            this.btnPrecedente.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrecedente.Name = "btnPrecedente";
            this.btnPrecedente.Size = new System.Drawing.Size(31, 31);
            this.btnPrecedente.TabIndex = 8;
            this.btnPrecedente.UseVisualStyleBackColor = true;
            this.btnPrecedente.Click += new System.EventHandler(this.btnPrecedente_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.progBar);
            this.panel4.Location = new System.Drawing.Point(47, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 30);
            this.panel4.TabIndex = 6;
            // 
            // progBar
            // 
            this.progBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.progBar.Location = new System.Drawing.Point(0, 0);
            this.progBar.Margin = new System.Windows.Forms.Padding(2);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(685, 39);
            this.progBar.TabIndex = 3;
            // 
            // btnSuccessiva
            // 
            this.btnSuccessiva.Location = new System.Drawing.Point(152, 103);
            this.btnSuccessiva.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuccessiva.Name = "btnSuccessiva";
            this.btnSuccessiva.Size = new System.Drawing.Size(31, 31);
            this.btnSuccessiva.TabIndex = 10;
            this.btnSuccessiva.UseVisualStyleBackColor = true;
            this.btnSuccessiva.Click += new System.EventHandler(this.btnSuccessiva_Click);
            // 
            // lblVisuallizzaNomeFile
            // 
            this.lblVisuallizzaNomeFile.Location = new System.Drawing.Point(102, 48);
            this.lblVisuallizzaNomeFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisuallizzaNomeFile.Name = "lblVisuallizzaNomeFile";
            this.lblVisuallizzaNomeFile.Size = new System.Drawing.Size(577, 19);
            this.lblVisuallizzaNomeFile.TabIndex = 6;
            // 
            // lblVisuallizzaAuto
            // 
            this.lblVisuallizzaAuto.Location = new System.Drawing.Point(99, 27);
            this.lblVisuallizzaAuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisuallizzaAuto.Name = "lblVisuallizzaAuto";
            this.lblVisuallizzaAuto.Size = new System.Drawing.Size(240, 19);
            this.lblVisuallizzaAuto.TabIndex = 5;
            // 
            // lblVisualizzaTitolo
            // 
            this.lblVisualizzaTitolo.Location = new System.Drawing.Point(99, 2);
            this.lblVisualizzaTitolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisualizzaTitolo.Name = "lblVisualizzaTitolo";
            this.lblVisualizzaTitolo.Size = new System.Drawing.Size(240, 19);
            this.lblVisualizzaTitolo.TabIndex = 4;
            // 
            // btnUltima
            // 
            this.btnUltima.Location = new System.Drawing.Point(187, 103);
            this.btnUltima.Margin = new System.Windows.Forms.Padding(2);
            this.btnUltima.Name = "btnUltima";
            this.btnUltima.Size = new System.Drawing.Size(31, 31);
            this.btnUltima.TabIndex = 11;
            this.btnUltima.UseVisualStyleBackColor = true;
            this.btnUltima.Click += new System.EventHandler(this.btnUltima_Click);
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(44, 136);
            this.lblDurata.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(39, 13);
            this.lblDurata.TabIndex = 12;
            this.lblDurata.Text = "Durata";
            // 
            // lblNomeFile
            // 
            this.lblNomeFile.AutoSize = true;
            this.lblNomeFile.Location = new System.Drawing.Point(44, 50);
            this.lblNomeFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeFile.Name = "lblNomeFile";
            this.lblNomeFile.Size = new System.Drawing.Size(54, 13);
            this.lblNomeFile.TabIndex = 2;
            this.lblNomeFile.Text = "Nome File";
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Location = new System.Drawing.Point(44, 27);
            this.lblAutore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(38, 13);
            this.lblAutore.TabIndex = 1;
            this.lblAutore.Text = "Autore";
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(44, 2);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(33, 13);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Titolo";
            // 
            // panelInserimento
            // 
            this.panelInserimento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelInserimento.Controls.Add(this.lblTitoloAdd);
            this.panelInserimento.Controls.Add(this.pannelloAggiunta);
            this.panelInserimento.Controls.Add(this.btnCarica);
            this.panelInserimento.Controls.Add(this.btnSfoglia);
            this.panelInserimento.Controls.Add(this.panelTitolo4);
            this.panelInserimento.Controls.Add(this.lblAutoreAdd);
            this.panelInserimento.Controls.Add(this.lblDurataAdd);
            this.panelInserimento.Controls.Add(this.lblNomeFileAdd);
            this.panelInserimento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInserimento.Location = new System.Drawing.Point(0, 137);
            this.panelInserimento.Margin = new System.Windows.Forms.Padding(2);
            this.panelInserimento.Name = "panelInserimento";
            this.panelInserimento.Size = new System.Drawing.Size(804, 142);
            this.panelInserimento.TabIndex = 2;
            // 
            // lblTitoloAdd
            // 
            this.lblTitoloAdd.AutoSize = true;
            this.lblTitoloAdd.Location = new System.Drawing.Point(44, 41);
            this.lblTitoloAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitoloAdd.Name = "lblTitoloAdd";
            this.lblTitoloAdd.Size = new System.Drawing.Size(33, 13);
            this.lblTitoloAdd.TabIndex = 14;
            this.lblTitoloAdd.Text = "Titolo";
            // 
            // pannelloAggiunta
            // 
            this.pannelloAggiunta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pannelloAggiunta.Controls.Add(this.txtAutoreAgg);
            this.pannelloAggiunta.Controls.Add(this.numericUpDownDurata);
            this.pannelloAggiunta.Controls.Add(this.txtNomeFileAgg);
            this.pannelloAggiunta.Controls.Add(this.txtTitoloAgg);
            this.pannelloAggiunta.Location = new System.Drawing.Point(101, 38);
            this.pannelloAggiunta.Name = "pannelloAggiunta";
            this.pannelloAggiunta.Size = new System.Drawing.Size(690, 104);
            this.pannelloAggiunta.TabIndex = 11;
            // 
            // txtAutoreAgg
            // 
            this.txtAutoreAgg.Location = new System.Drawing.Point(15, 27);
            this.txtAutoreAgg.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutoreAgg.Name = "txtAutoreAgg";
            this.txtAutoreAgg.Size = new System.Drawing.Size(658, 20);
            this.txtAutoreAgg.TabIndex = 6;
            // 
            // numericUpDownDurata
            // 
            this.numericUpDownDurata.Location = new System.Drawing.Point(15, 50);
            this.numericUpDownDurata.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDurata.Name = "numericUpDownDurata";
            this.numericUpDownDurata.Size = new System.Drawing.Size(196, 20);
            this.numericUpDownDurata.TabIndex = 8;
            // 
            // txtNomeFileAgg
            // 
            this.txtNomeFileAgg.Location = new System.Drawing.Point(15, 75);
            this.txtNomeFileAgg.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeFileAgg.Name = "txtNomeFileAgg";
            this.txtNomeFileAgg.Size = new System.Drawing.Size(659, 20);
            this.txtNomeFileAgg.TabIndex = 7;
            // 
            // txtTitoloAgg
            // 
            this.txtTitoloAgg.Location = new System.Drawing.Point(15, 3);
            this.txtTitoloAgg.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitoloAgg.Name = "txtTitoloAgg";
            this.txtTitoloAgg.Size = new System.Drawing.Size(659, 20);
            this.txtTitoloAgg.TabIndex = 5;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(2, 47);
            this.btnCarica.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(32, 31);
            this.btnCarica.TabIndex = 10;
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnSfoglia
            // 
            this.btnSfoglia.Location = new System.Drawing.Point(2, 85);
            this.btnSfoglia.Margin = new System.Windows.Forms.Padding(2);
            this.btnSfoglia.Name = "btnSfoglia";
            this.btnSfoglia.Size = new System.Drawing.Size(32, 31);
            this.btnSfoglia.TabIndex = 9;
            this.btnSfoglia.UseVisualStyleBackColor = true;
            this.btnSfoglia.Click += new System.EventHandler(this.btnSfoglia_Click);
            // 
            // panelTitolo4
            // 
            this.panelTitolo4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTitolo4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitolo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitolo4.Location = new System.Drawing.Point(0, 0);
            this.panelTitolo4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panelTitolo4.Name = "panelTitolo4";
            this.panelTitolo4.Size = new System.Drawing.Size(804, 24);
            this.panelTitolo4.TabIndex = 0;
            this.panelTitolo4.Text = "AGGIUNTA CANZONI";
            this.panelTitolo4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAutoreAdd
            // 
            this.lblAutoreAdd.AutoSize = true;
            this.lblAutoreAdd.Location = new System.Drawing.Point(43, 65);
            this.lblAutoreAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutoreAdd.Name = "lblAutoreAdd";
            this.lblAutoreAdd.Size = new System.Drawing.Size(38, 13);
            this.lblAutoreAdd.TabIndex = 2;
            this.lblAutoreAdd.Text = "Autore";
            // 
            // lblDurataAdd
            // 
            this.lblDurataAdd.AutoSize = true;
            this.lblDurataAdd.Location = new System.Drawing.Point(44, 89);
            this.lblDurataAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurataAdd.Name = "lblDurataAdd";
            this.lblDurataAdd.Size = new System.Drawing.Size(39, 13);
            this.lblDurataAdd.TabIndex = 3;
            this.lblDurataAdd.Text = "Durata";
            // 
            // lblNomeFileAdd
            // 
            this.lblNomeFileAdd.AutoSize = true;
            this.lblNomeFileAdd.Location = new System.Drawing.Point(42, 114);
            this.lblNomeFileAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeFileAdd.Name = "lblNomeFileAdd";
            this.lblNomeFileAdd.Size = new System.Drawing.Size(54, 13);
            this.lblNomeFileAdd.TabIndex = 4;
            this.lblNomeFileAdd.Text = "Nome File";
            // 
            // panelFIltri
            // 
            this.panelFIltri.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelFIltri.Controls.Add(this.panelTitolo3);
            this.panelFIltri.Controls.Add(this.btnFiltri);
            this.panelFIltri.Controls.Add(this.btnAll);
            this.panelFIltri.Controls.Add(this.txtDurataMinima);
            this.panelFIltri.Controls.Add(this.lblDurataMinima);
            this.panelFIltri.Controls.Add(this.lblContieneTesto);
            this.panelFIltri.Controls.Add(this.txtContenente);
            this.panelFIltri.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFIltri.Location = new System.Drawing.Point(476, 0);
            this.panelFIltri.Margin = new System.Windows.Forms.Padding(2);
            this.panelFIltri.Name = "panelFIltri";
            this.panelFIltri.Size = new System.Drawing.Size(328, 137);
            this.panelFIltri.TabIndex = 3;
            // 
            // panelTitolo3
            // 
            this.panelTitolo3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelTitolo3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTitolo3.Controls.Add(this.lblFiltri);
            this.panelTitolo3.Location = new System.Drawing.Point(-15, 1);
            this.panelTitolo3.Name = "panelTitolo3";
            this.panelTitolo3.Size = new System.Drawing.Size(358, 31);
            this.panelTitolo3.TabIndex = 9;
            // 
            // lblFiltri
            // 
            this.lblFiltri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltri.AutoSize = true;
            this.lblFiltri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltri.Location = new System.Drawing.Point(156, 6);
            this.lblFiltri.Name = "lblFiltri";
            this.lblFiltri.Size = new System.Drawing.Size(65, 20);
            this.lblFiltri.TabIndex = 1;
            this.lblFiltri.Text = "FILTRI";
            // 
            // btnFiltri
            // 
            this.btnFiltri.Location = new System.Drawing.Point(86, 38);
            this.btnFiltri.Name = "btnFiltri";
            this.btnFiltri.Size = new System.Drawing.Size(31, 31);
            this.btnFiltri.TabIndex = 7;
            this.btnFiltri.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(49, 38);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(31, 31);
            this.btnAll.TabIndex = 6;
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // txtDurataMinima
            // 
            this.txtDurataMinima.Location = new System.Drawing.Point(209, 80);
            this.txtDurataMinima.Margin = new System.Windows.Forms.Padding(2);
            this.txtDurataMinima.Name = "txtDurataMinima";
            this.txtDurataMinima.Size = new System.Drawing.Size(90, 20);
            this.txtDurataMinima.TabIndex = 5;
            // 
            // lblDurataMinima
            // 
            this.lblDurataMinima.AutoSize = true;
            this.lblDurataMinima.Location = new System.Drawing.Point(46, 84);
            this.lblDurataMinima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDurataMinima.Name = "lblDurataMinima";
            this.lblDurataMinima.Size = new System.Drawing.Size(141, 13);
            this.lblDurataMinima.TabIndex = 4;
            this.lblDurataMinima.Text = "Durata di almeno W secondi";
            // 
            // lblContieneTesto
            // 
            this.lblContieneTesto.AutoSize = true;
            this.lblContieneTesto.Location = new System.Drawing.Point(46, 107);
            this.lblContieneTesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContieneTesto.Name = "lblContieneTesto";
            this.lblContieneTesto.Size = new System.Drawing.Size(95, 13);
            this.lblContieneTesto.TabIndex = 3;
            this.lblContieneTesto.Text = "Contenente il testo";
            // 
            // txtContenente
            // 
            this.txtContenente.Location = new System.Drawing.Point(208, 104);
            this.txtContenente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContenente.Name = "txtContenente";
            this.txtContenente.Size = new System.Drawing.Size(91, 20);
            this.txtContenente.TabIndex = 2;
            // 
            // panelListBox
            // 
            this.panelListBox.Controls.Add(this.panelFIltri);
            this.panelListBox.Controls.Add(this.panelInserimento);
            this.panelListBox.Controls.Add(this.listaCanzoni);
            this.panelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListBox.Location = new System.Drawing.Point(0, 235);
            this.panelListBox.Margin = new System.Windows.Forms.Padding(2);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(804, 279);
            this.panelListBox.TabIndex = 4;
            // 
            // listaCanzoni
            // 
            this.listaCanzoni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaCanzoni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listaCanzoni.FormattingEnabled = true;
            this.listaCanzoni.Location = new System.Drawing.Point(0, -2);
            this.listaCanzoni.Margin = new System.Windows.Forms.Padding(2);
            this.listaCanzoni.Name = "listaCanzoni";
            this.listaCanzoni.Size = new System.Drawing.Size(478, 147);
            this.listaCanzoni.TabIndex = 0;
            this.listaCanzoni.SelectedIndexChanged += new System.EventHandler(this.listaCanzoni_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 514);
            this.Controls.Add(this.panelListBox);
            this.Controls.Add(this.panelVisuale);
            this.Controls.Add(this.panelTitolo);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(450, 545);
            this.Name = "Main";
            this.Text = "Player Audio";
            this.panelTitolo.ResumeLayout(false);
            this.panelTitolo.PerformLayout();
            this.panelVisuale.ResumeLayout(false);
            this.panelVisuale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.PanelTitolo2.ResumeLayout(false);
            this.PanelTitolo2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panelInserimento.ResumeLayout(false);
            this.panelInserimento.PerformLayout();
            this.pannelloAggiunta.ResumeLayout(false);
            this.pannelloAggiunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurata)).EndInit();
            this.panelFIltri.ResumeLayout(false);
            this.panelFIltri.PerformLayout();
            this.panelTitolo3.ResumeLayout(false);
            this.panelTitolo3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurataMinima)).EndInit();
            this.panelListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitolo;
        private System.Windows.Forms.Panel panelVisuale;
        private System.Windows.Forms.Panel panelInserimento;
        private System.Windows.Forms.Panel panelFIltri;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.ListBox listaCanzoni;
        private System.Windows.Forms.Label lblVisuallizzaNomeFile;
        private System.Windows.Forms.Label lblVisuallizzaAuto;
        private System.Windows.Forms.Label lblVisualizzaTitolo;
        private System.Windows.Forms.Label lblNomeFile;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Button btnSfoglia;
        private System.Windows.Forms.NumericUpDown numericUpDownDurata;
        private System.Windows.Forms.TextBox txtNomeFileAgg;
        private System.Windows.Forms.TextBox txtAutoreAgg;
        private System.Windows.Forms.TextBox txtTitoloAgg;
        private System.Windows.Forms.Label lblNomeFileAdd;
        private System.Windows.Forms.Label lblDurataAdd;
        private System.Windows.Forms.Label lblAutoreAdd;
        private System.Windows.Forms.Label panelTitolo4;
        private System.Windows.Forms.NumericUpDown txtDurataMinima;
        private System.Windows.Forms.Label lblDurataMinima;
        private System.Windows.Forms.Label lblContieneTesto;
        private System.Windows.Forms.TextBox txtContenente;
        private System.Windows.Forms.Label lblVisualizzaDurata;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnCasuale;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSuccessiva;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Button btnPrima;
        private System.Windows.Forms.Button btnPrecedente;
        private System.Windows.Forms.Button btnUltima;
        private System.Windows.Forms.Button btnFiltri;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Panel PanelTitolo2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblListaCanzoni;
        private System.Windows.Forms.Panel panelTitolo3;
        private System.Windows.Forms.Label lblFiltri;
        private System.Windows.Forms.Panel pannelloAggiunta;
        private System.Windows.Forms.Label lblTitoloAdd;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ImageList imageList1;
    }
}

