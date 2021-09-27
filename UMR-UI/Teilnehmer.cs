using System;

namespace UMR_UI
{
    public class Teilnehmer
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string VollerName { get => Vorname + " " + Name; }
        public string Emailadresse { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public DateTime Anmeldedatum { get; set; }
        public Uebungsmoment Uebungsmoment { get; set; }
        public bool zweiWochenAlt { get; set; }
    }
}
