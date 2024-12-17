namespace CampoImpestato
{
    partial class CampoImpestato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampoImpestato));
            this.panelStatistiche = new System.Windows.Forms.Panel();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaImpostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaImpostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dimensioniCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCampoGioco = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.replayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replayPartitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStatistiche.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStatistiche
            // 
            this.panelStatistiche.BackColor = System.Drawing.Color.Gray;
            this.panelStatistiche.Controls.Add(this.ResetBtn);
            this.panelStatistiche.Controls.Add(this.labelTimer);
            this.panelStatistiche.Controls.Add(this.label1);
            this.panelStatistiche.Controls.Add(this.menuStrip1);
            this.panelStatistiche.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatistiche.Location = new System.Drawing.Point(0, 0);
            this.panelStatistiche.Name = "panelStatistiche";
            this.panelStatistiche.Size = new System.Drawing.Size(303, 100);
            this.panelStatistiche.TabIndex = 0;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(223, 44);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(45, 31);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(77, 44);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(30, 31);
            this.labelTimer.TabIndex = 1;
            this.labelTimer.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.personalizzaToolStripMenuItem,
            this.replayToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(303, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaImpostazioniToolStripMenuItem,
            this.esportaImpostazioniToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importaImpostazioniToolStripMenuItem
            // 
            this.importaImpostazioniToolStripMenuItem.Name = "importaImpostazioniToolStripMenuItem";
            this.importaImpostazioniToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importaImpostazioniToolStripMenuItem.Text = "Importa Impostazioni";
            this.importaImpostazioniToolStripMenuItem.Click += new System.EventHandler(this.importaImpostazioniToolStripMenuItem_Click);
            // 
            // esportaImpostazioniToolStripMenuItem
            // 
            this.esportaImpostazioniToolStripMenuItem.Name = "esportaImpostazioniToolStripMenuItem";
            this.esportaImpostazioniToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.esportaImpostazioniToolStripMenuItem.Text = "Esporta Impostazioni";
            this.esportaImpostazioniToolStripMenuItem.Click += new System.EventHandler(this.esportaImpostazioniToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // personalizzaToolStripMenuItem
            // 
            this.personalizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dimensioniCustomToolStripMenuItem});
            this.personalizzaToolStripMenuItem.Name = "personalizzaToolStripMenuItem";
            this.personalizzaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.personalizzaToolStripMenuItem.Text = "Personalizza";
            // 
            // dimensioniCustomToolStripMenuItem
            // 
            this.dimensioniCustomToolStripMenuItem.Name = "dimensioniCustomToolStripMenuItem";
            this.dimensioniCustomToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dimensioniCustomToolStripMenuItem.Text = "Impostazioni";
            this.dimensioniCustomToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panelCampoGioco
            // 
            this.panelCampoGioco.BackColor = System.Drawing.Color.Silver;
            this.panelCampoGioco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCampoGioco.Location = new System.Drawing.Point(0, 100);
            this.panelCampoGioco.Name = "panelCampoGioco";
            this.panelCampoGioco.Size = new System.Drawing.Size(303, 305);
            this.panelCampoGioco.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // replayToolStripMenuItem
            // 
            this.replayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replayPartitaToolStripMenuItem});
            this.replayToolStripMenuItem.Name = "replayToolStripMenuItem";
            this.replayToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.replayToolStripMenuItem.Text = "Replay";
            // 
            // replayPartitaToolStripMenuItem
            // 
            this.replayPartitaToolStripMenuItem.Name = "replayPartitaToolStripMenuItem";
            this.replayPartitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replayPartitaToolStripMenuItem.Text = "Replay Partita";
            this.replayPartitaToolStripMenuItem.Click += new System.EventHandler(this.replayPartitaToolStripMenuItem_Click);
            // 
            // CampoImpestato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 405);
            this.Controls.Add(this.panelCampoGioco);
            this.Controls.Add(this.panelStatistiche);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CampoImpestato";
            this.Text = "Campo Impestato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelStatistiche.ResumeLayout(false);
            this.panelStatistiche.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStatistiche;
        private System.Windows.Forms.Panel panelCampoGioco;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaImpostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esportaImpostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dimensioniCustomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replayPartitaToolStripMenuItem;
    }
}

