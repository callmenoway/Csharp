using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAudio
{
    internal class Canzone
    {
        private int durata;
        private string titolo;
        private string autore;
        private string percorsoFile;
        public int Durata { get => durata; set => durata = value; }
        public string Titolo { get => titolo; set => titolo = value; }
        public string Autore { get => autore; set => autore = value; }
        public string PercorsoFile { get => percorsoFile; set => percorsoFile = value; }

        //costruttore
        public Canzone(int durata, string titolo, string autore, string percorsoFile)
        {
            Durata = durata;
            Titolo = titolo;
            Autore = autore;
            PercorsoFile = percorsoFile;
        }

        //metoto per la visualizzazione delle informazioni della canzone
        public override string ToString()
        {
            return $"{Titolo} - {Autore} ({Durata} sec)";
        }
    }
}
