using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampoImpestato
{
    public static class Config
    {
        //dimensione predefinita della griglia di gioco
        public static Size GridSize { get; set; } = new Size(5, 5);

        //dimensione predefinita delle celle (pulsanti e label)
        public static int CellSize { get; set; } = 60;

        //percentuale di bombe predefinita
        public static double PercentualeBombe { get; set; } = 0.10;

        //percorsi dei file audio
        public static string ClickSoundPath { get; set; } = "Resources/click.wav";
        public static string FlagSoundPath { get; set; } = "Resources/flag.wav";

        //percorso immagine bandierina e bomba
        public static string FlagImagePath { get; set; } = "Resources/flag.png";
        public static string BombImagePath { get; set; } = "Resources/bomb.png";

        //timer di aggiornamento (in millisecondi)
        public static int TimerInterval { get; set; } = 1000;

        //colori personalizzati
        public static Color BackgroundColor { get; set; } = Color.LightGray;
        public static Color BombBackgroundColor { get; set; } = Color.Red;

        //font utilizzato nel gioco
        public static Font CellFont { get; set; } = new Font("Arial", 30, FontStyle.Bold);
    }
}
