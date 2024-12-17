using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampoImpestato
{
    internal class MyButton:Button
    {
        private bool haBomba = false;
        
        public bool HaBomba { get => haBomba; set => haBomba = value; }
    }
}
