using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MichaelKoch.UeMR.UI
{
    public partial class MainWindow : Window
    {
        public static Uebungsmoment UebungsMoment21von21 = new()
        {
            Bezeichnung = "ÜbungsMoment 21/21",
            Beschreibung = "Entwerfen einer Oberfläche mit der WPF",
            Tags = new() { "C#", "WPF", "Xaml", "Master-Detail-View" },
            EinzelBewertung = 4,
            GesammtBewertung = 4.8
        };

        public static Uebungsmoment UebungsMoment250 = new()
        {
            Bezeichnung = "ÜbungsMoment 250",
            Beschreibung = "Dieser ÜbungsMoment wurde noch nicht erstellt, daher kann er nicht beschrieben werden.",
            Tags = new() { "C#", "WPF", "Xaml", "List<>", "anderes" },
            EinzelBewertung = 3,
            GesammtBewertung = 3.9
        };
        public TeilnehmerListe Teilnehmerliste { get; set; } = new()
        {
            new Teilnehmer { Name = "Koch", Vorname = "Michael", Emailadresse = "email@adresse.wo", Geburtsdatum = new(2000, 05, 20), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true, },
            new Teilnehmer { Name = "Peter", Vorname = "Michael", Emailadresse = "hallo@adresse.wo", Geburtsdatum = new(1956, 02, 15), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250 },
            new Teilnehmer { Name = "Green", Vorname = "John", Emailadresse = "gutentag@adresse.wo", Geburtsdatum = new(1966, 05, 18), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21 },
            new Teilnehmer { Name = "Brown", Vorname = "Jackson", Emailadresse = "aufwiedersehen@adresse.wo", Geburtsdatum = new(2011, 02, 17), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250 },
            new Teilnehmer { Name = "Knoll", Vorname = "Jens", Emailadresse = "byby@adresse.wo", Geburtsdatum = new(1999, 03, 22), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21 },
            new Teilnehmer { Name = "Müller", Vorname = "Robert", Emailadresse = "info@adresse.wo", Geburtsdatum = new(1968, 05, 04), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250 },
            new Teilnehmer { Name = "Karl", Vorname = "Peter", Emailadresse = "knaller@adresse.wo", Geburtsdatum = new(2017, 07, 08), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21 },
            new Teilnehmer { Name = "Busse", Vorname = "Jürgen", Emailadresse = "rakete@adresse.wo", Geburtsdatum = new(1965, 06, 24), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true },
            new Teilnehmer { Name = "Maximus", Vorname = "Koriosus", Emailadresse = "inbox@adresse.wo", Geburtsdatum = new(1988, 09, 29), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true },
            new Teilnehmer { Name = "Plümm", Vorname = "Horst", Emailadresse = "hey@adresse.wo", Geburtsdatum = new(1989, 03, 07), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true },
            new Teilnehmer { Name = "Dahl", Vorname = "Sven", Emailadresse = "hello@adresse.wo", Geburtsdatum = new(1932, 08, 16), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true },
            new Teilnehmer { Name = "Kohl", Vorname = "Detlef", Emailadresse = "kaesebrot@adresse.wo", Geburtsdatum = new(1977, 01, 31), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true },
            new Teilnehmer { Name = "Weise", Vorname = "Bernhard", Emailadresse = "salatbar@adresse.wo", Geburtsdatum = new(1992, 12, 01), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment21von21, zweiWochenAlt = true },
            new Teilnehmer { Name = "Maul", Vorname = "Giesberth", Emailadresse = "ichweissauchnicht@adresse.wo", Geburtsdatum = new(1992, 07, 02), Anmeldedatum = DateTime.Now, Uebungsmoment = UebungsMoment250, zweiWochenAlt = true },
        };

        
        

        public MainWindow()
        {
            InitializeComponent();
            ICollectionView teilnehmerListCollectionView = CollectionViewSource.GetDefaultView(Teilnehmerliste);
            DataContext = teilnehmerListCollectionView;
        }
    }
}
