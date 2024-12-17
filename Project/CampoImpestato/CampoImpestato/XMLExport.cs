using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CampoImpestato
{

    [Serializable]
    public class GameSettings
    {
        public int Lunghezza { get; set; }
        public int Larghezza { get; set; }
        public double PercentualeBombe { get; set; }
    }
}
