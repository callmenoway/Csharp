using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoImpestato
{
    public partial class AboutForm : Form
    {
        private Label labelInfo;

        public AboutForm()
        {
            InitializeComponent();
            //testo dell'about
            AssemblyInfo entryAssemblyInfo = new AssemblyInfo(Assembly.GetEntryAssembly());
            labelInfo.Text = "Azienda: " + entryAssemblyInfo.Company + "\nCopyright: " + entryAssemblyInfo.Copyright 
                + "\nDescrizione: " + entryAssemblyInfo.Description + "\nProdotto: " + entryAssemblyInfo.Product 
                + "\nTitolo Prodotto: " + entryAssemblyInfo.ProductTitle + "\nVersione: " + entryAssemblyInfo.Version;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(66, 19);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "ABOUT";
            // 
            // AboutForm
            // 
            this.ClientSize = new System.Drawing.Size(348, 145);
            this.Controls.Add(this.labelInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

