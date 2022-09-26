using System;

namespace Oliotehtävä_1
{
    class Kirjasto
    {
        private string kirjannimi;
        private string kirjailija;
        private int sivumaara;

        public string HaeKirjannimi() 
        {
            Console.WriteLine("Haekirjannimi käytetty");
            return kirjannimi; 
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

    public Kirjasto()
        {
            kirjannimi = "";
            kirjailija = "";
            sivumaara = 0;
        }

        public Kirjasto(string u_kirjannimi, string u_kirjailija, int u_sivumäärä)
        {
            kirjannimi = u_kirjannimi;
            kirjailija = u_kirjailija;
            sivumaara = u_sivumäärä;
        }

        public string Kirjannimi
        {
            set { kirjannimi = value; }
            get { return kirjannimi; }
        }

        public string Kirjailija
        {
            get { return kirjailija; }
            set { kirjailija = value; }
        }

        public int Sivumäärä
        {
            get { return sivumaara; }
            set { sivumaara = value; }
        }
    }
}
