using System;

namespace Olio_tehtävä_1
{
    class Kirjasto
    {
        private string kirjanimi;
        private string kirjailija;
        private int sivumaara;

        public Kirjasto()
        {
            kirjanimi = "";
            kirjailija = "";
            sivumaara = 0;
        }

        public string HaeKirjanimi()
        {
            Console.WriteLine("Haekirjannimi käytetty");
            return kirjanimi;
        }
        
        public string HaeKirjailija()
        {
            Console.WriteLine("HaeKirjailija käytetty");
            return kirjailija;
        }
        
        public int HaeSivumaara()
        {
            Console.WriteLine("HaeSivumaara käytetty");
            return sivumaara;
        }

        public Kirjasto(string u_kirjanimi, string u_kirjailija, int u_eräpäivä)
        {
            kirjanimi = u_kirjanimi;
            kirjailija = u_kirjailija;
            sivumaara = u_eräpäivä;
        }

        public string Kirjanimi
        {
           set { kirjanimi = value; }
           get { return kirjanimi; }
        }

        public string Kirjailija
        {
            set { kirjailija = value; }
            get { return kirjailija; }
        }

        public int Sivumaara
        {
            set { sivumaara = value; }
            get { return sivumaara; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
   
            Kirjasto Kirja = new Kirjasto();
            Kirja.HaeKirjanimi();
            Kirja.HaeKirjailija();
            Kirja.HaeSivumaara();
            Console.WriteLine("\nOlio luotu!");


            Kirja.Kirjanimi = "BaBa";
            Kirja.Kirjailija = "Boi";
            Kirja.Sivumaara = 69;
            Console.WriteLine("Kirjasi nimi on {0}\nsen kirjoitti {1}\nja siinä on {2} sivua", Kirja.Kirjanimi, Kirja.Kirjailija, Kirja.Sivumaara);
            Console.WriteLine("Käytit getteriä ja setteriä\n");

            Kirjasto Kirja1 = new Kirjasto();
            Console.WriteLine("Uusi Olio luotu!");
            
            Console.WriteLine("Kirjasi nimi on {0}\nsen kirjoitti {1}\nja siinä on {2} sivua", Kirja1.Kirjanimi, Kirja1.Kirjailija, Kirja1.Sivumaara);
            Console.WriteLine("Käytit setteriä\n");
        }
    }
}