using MichaelKoch.UeMR.UI.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MichaelKoch.UeMR.UI.ViewModel
{
    public class HauptansichtViewModel
    {
        private ICollectionView _teilnehmerCollectionView;
        public HauptansichtViewModel()
        {
            TeilnehmerListe = new TeilnehmerCollection();
            _teilnehmerCollectionView = CollectionViewSource.GetDefaultView(TeilnehmerListe);

            DummyLoadData();
        }

        public TeilnehmerCollection TeilnehmerListe { get; }
        private void DummyLoadData()
        {
            Uebungsmoment UebungsMoment21von21 = new()
            {
                Bezeichnung = "ÜbungsMoment 21/21",
                Beschreibung = "Entwerfen einer Oberfläche mit der WPF",
                Tags = new() { "C#", "WPF", "Xaml", "Master-Detail-View" },
                EinzelBewertung = 4,
                GesammtBewertung = 4.8
            };

            Uebungsmoment UebungsMoment250 = new()
            {
                Bezeichnung = "ÜbungsMoment 250",
                Beschreibung = "Dieser ÜbungsMoment wurde noch nicht erstellt, daher kann er nicht beschrieben werden.",
                Tags = new() { "C#", "WPF", "Xaml", "List<>", "anderes" },
                EinzelBewertung = 3,
                GesammtBewertung = 3.9
            };


            TeilnehmerListe.Add(new Teilnehmer { Name = "Koch", Vorname = "Michael", Emailadresse = "email@adresse.wo", Geburtsdatum = new(2000, 05, 20), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true, });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Peter", Vorname = "Michael", Emailadresse = "hallo@adresse.wo", Geburtsdatum = new(1956, 02, 15), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250 });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Green", Vorname = "John", Emailadresse = "gutentag@adresse.wo", Geburtsdatum = new(1966, 05, 18), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21 });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Brown", Vorname = "Jackson", Emailadresse = "aufwiedersehen@adresse.wo", Geburtsdatum = new(2011, 02, 17), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250 });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Knoll", Vorname = "Jens", Emailadresse = "byby@adresse.wo", Geburtsdatum = new(1999, 03, 22), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21 });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Müller", Vorname = "Robert", Emailadresse = "info@adresse.wo", Geburtsdatum = new(1968, 05, 04), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250 });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Karl", Vorname = "Peter", Emailadresse = "knaller@adresse.wo", Geburtsdatum = new(2017, 07, 08), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21 });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Busse", Vorname = "Jürgen", Emailadresse = "rakete@adresse.wo", Geburtsdatum = new(1965, 06, 24), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Maximus", Vorname = "Koriosus", Emailadresse = "inbox@adresse.wo", Geburtsdatum = new(1988, 09, 29), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Plümm", Vorname = "Horst", Emailadresse = "hey@adresse.wo", Geburtsdatum = new(1989, 03, 07), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Dahl", Vorname = "Sven", Emailadresse = "hello@adresse.wo", Geburtsdatum = new(1932, 08, 16), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Kohl", Vorname = "Detlef", Emailadresse = "kaesebrot@adresse.wo", Geburtsdatum = new(1977, 01, 31), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Weise", Vorname = "Bernhard", Emailadresse = "salatbar@adresse.wo", Geburtsdatum = new(1992, 12, 01), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true });
            TeilnehmerListe.Add(new Teilnehmer { Name = "Maul", Vorname = "Giesberth", Emailadresse = "ichweissauchnicht@adresse.wo", Geburtsdatum = new(1992, 07, 02), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true });

        }
    }
}
