using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMR_UI.SampleData
{
    public class UeMRHauptansichtSampleData
    {       
        public List<Teilnehmer> Teilnehmerliste { get; set; } = new()
        {
            new Teilnehmer { Name = "Koch", Vorname = "Michael", Uebungsmoment = "LernMail 21/21" },
            new Teilnehmer { Name = "Peter", Vorname = "Michael", Uebungsmoment = "LernMail 21/21" },
            new Teilnehmer { Name = "Green", Vorname = "John", Uebungsmoment = "LernMail 21/21" },
            new Teilnehmer { Name = "Brown", Vorname = "Jackson", Uebungsmoment = "LernMail 21/21" },
            new Teilnehmer { Name = "Knoll", Vorname = "Jens", Uebungsmoment = "LernMail 21/21" },
            new Teilnehmer { Name = "Müller", Vorname = "Robert", Uebungsmoment = "LernMail 21/21" },
            new Teilnehmer { Name = "Karl", Vorname = "Peter", Uebungsmoment = "LernMail 21/21" },
        };
    }

    public class Teilnehmer
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public string Uebungsmoment { get; set; }
    }
}
