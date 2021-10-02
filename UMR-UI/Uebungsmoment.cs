using System.Collections.Generic;

namespace MichaelKoch.UeMR.UI
{
    public class Uebungsmoment
    {
        public string Bezeichnung { get; set; }
        public List<string> Tags { get; set; }
        public string Beschreibung { get; set; }
        public int EinzelBewertung { get; set; }
        public double GesammtBewertung { get; set; }
    }
}
