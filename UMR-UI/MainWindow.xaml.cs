using System;
using System.Collections.Generic;
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

namespace UMR_UI
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
        public List<Teilnehmer> Teilnehmerliste { get; set; } = new()
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
            uebungsMomentTeilnehmerExplorer.ItemsSource = Teilnehmerliste;
        }

        private void uebungsMomentTeilnehmerExplorer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var ausgewählterTeilnehmer = new Teilnehmer();
            ausgewählterTeilnehmer = (Teilnehmer)uebungsMomentTeilnehmerExplorer.SelectedItem;
            DetailViewZuruecksetzen();
            SetzeDetailView(ausgewählterTeilnehmer);
        }

        private void SetzeDetailView(Teilnehmer ausgewählterTeilnehmer)
        {
            vollerName.Text = ausgewählterTeilnehmer.VollerName;
            vorname.Text = ausgewählterTeilnehmer.Vorname;
            name.Text = ausgewählterTeilnehmer.Name;
            emailAdresse.Text = ausgewählterTeilnehmer.Emailadresse;
            geburtsdatum.Text = ausgewählterTeilnehmer.Geburtsdatum.ToString();
            anmeldedatum.Text = ausgewählterTeilnehmer.Anmeldedatum.ToString();

            uebungsmomentBezeichnung.Text = ausgewählterTeilnehmer.Uebungsmoment.Bezeichnung;
            Beschreibung.Text = ausgewählterTeilnehmer.Uebungsmoment.Beschreibung;
            Tags.Text = String.Join(";  ", ausgewählterTeilnehmer.Uebungsmoment.Tags.ToArray());
            Einzelbewertung.Text = ausgewählterTeilnehmer.Uebungsmoment.EinzelBewertung.ToString();
            Gesamtbewertung.Text = ausgewählterTeilnehmer.Uebungsmoment.GesammtBewertung.ToString();
        }

        private void DetailViewZuruecksetzen()
        {
            vollerName.Text = vorname.Text = name.Text = emailAdresse.Text = string.Empty;

        }
    }

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

    public class Uebungsmoment
    {
        public string Bezeichnung { get; set; }
        public List<string> Tags { get; set; }
        public string Beschreibung { get; set; }
        public int EinzelBewertung { get; set; }
        public double GesammtBewertung { get; set; }
    }
}
