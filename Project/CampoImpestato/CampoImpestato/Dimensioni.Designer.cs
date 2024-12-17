namespace CampoImpestato
{
    partial class Dimensioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dimensioni));
            this.BtnConferma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxLunghezza = new System.Windows.Forms.TextBox();
            this.txtBoxPercentualeBombe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxLarghezza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarBombe = new System.Windows.Forms.TrackBar();
            this.trackBarLunghezza = new System.Windows.Forms.TrackBar();
            this.trackBarAltezza = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBombe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLunghezza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltezza)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConferma
            // 
            this.BtnConferma.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConferma.Location = new System.Drawing.Point(137, 267);
            this.BtnConferma.Name = "BtnConferma";
            this.BtnConferma.Size = new System.Drawing.Size(96, 23);
            this.BtnConferma.TabIndex = 0;
            this.BtnConferma.Text = "Conferma";
            this.BtnConferma.UseVisualStyleBackColor = true;
            this.BtnConferma.Click += new System.EventHandler(this.BtnConferma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dimensioni Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            // 
            // txtBoxLunghezza
            // 
            this.txtBoxLunghezza.Location = new System.Drawing.Point(59, 102);
            this.txtBoxLunghezza.Name = "txtBoxLunghezza";
            this.txtBoxLunghezza.Size = new System.Drawing.Size(51, 20);
            this.txtBoxLunghezza.TabIndex = 4;
            // 
            // txtBoxPercentualeBombe
            // 
            this.txtBoxPercentualeBombe.Location = new System.Drawing.Point(164, 204);
            this.txtBoxPercentualeBombe.Name = "txtBoxPercentualeBombe";
            this.txtBoxPercentualeBombe.Size = new System.Drawing.Size(39, 20);
            this.txtBoxPercentualeBombe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Impostazioni";
            // 
            // txtBoxLarghezza
            // 
            this.txtBoxLarghezza.Location = new System.Drawing.Point(257, 102);
            this.txtBoxLarghezza.Name = "txtBoxLarghezza";
            this.txtBoxLarghezza.Size = new System.Drawing.Size(51, 20);
            this.txtBoxLarghezza.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Percentuale Bombe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "%";
            // 
            // trackBarBombe
            // 
            this.trackBarBombe.LargeChange = 10;
            this.trackBarBombe.Location = new System.Drawing.Point(129, 224);
            this.trackBarBombe.Maximum = 90;
            this.trackBarBombe.Minimum = 5;
            this.trackBarBombe.Name = "trackBarBombe";
            this.trackBarBombe.Size = new System.Drawing.Size(115, 45);
            this.trackBarBombe.SmallChange = 5;
            this.trackBarBombe.TabIndex = 11;
            this.trackBarBombe.Value = 5;
            this.trackBarBombe.Scroll += new System.EventHandler(this.trackBarBombe_Scroll);
            // 
            // trackBarLunghezza
            // 
            this.trackBarLunghezza.LargeChange = 10;
            this.trackBarLunghezza.Location = new System.Drawing.Point(33, 128);
            this.trackBarLunghezza.Maximum = 50;
            this.trackBarLunghezza.Minimum = 5;
            this.trackBarLunghezza.Name = "trackBarLunghezza";
            this.trackBarLunghezza.Size = new System.Drawing.Size(104, 45);
            this.trackBarLunghezza.TabIndex = 12;
            this.trackBarLunghezza.Value = 5;
            this.trackBarLunghezza.Scroll += new System.EventHandler(this.trackBarLunghezza_Scroll);
            // 
            // trackBarAltezza
            // 
            this.trackBarAltezza.LargeChange = 10;
            this.trackBarAltezza.Location = new System.Drawing.Point(228, 128);
            this.trackBarAltezza.Maximum = 50;
            this.trackBarAltezza.Minimum = 5;
            this.trackBarAltezza.Name = "trackBarAltezza";
            this.trackBarAltezza.Size = new System.Drawing.Size(104, 45);
            this.trackBarAltezza.TabIndex = 13;
            this.trackBarAltezza.Value = 5;
            this.trackBarAltezza.Scroll += new System.EventHandler(this.trackBarAltezza_Scroll);
            // 
            // Dimensioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(371, 323);
            this.Controls.Add(this.trackBarAltezza);
            this.Controls.Add(this.trackBarLunghezza);
            this.Controls.Add(this.trackBarBombe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxLarghezza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPercentualeBombe);
            this.Controls.Add(this.txtBoxLunghezza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConferma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dimensioni";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBombe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLunghezza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltezza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConferma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxLunghezza;
        private System.Windows.Forms.TextBox txtBoxPercentualeBombe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxLarghezza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarBombe;
        private System.Windows.Forms.TrackBar trackBarLunghezza;
        private System.Windows.Forms.TrackBar trackBarAltezza;
    }
}