using System;

namespace Olio_tehtävä_1
{
    class Kirjasto
    {
        private string kirjanimi;
        private string kirjailija;
        private int eräpäivä;

        public string Kirjanimi
        {
            get { return kirjanimi; }
            set { kirjanimi = value; }
        }
        public string Kirjailija
        {
            get { return kirjailija; }
            set { kirjailija = value; }
        }
        public int Eräpäivä
        {
            get { return eräpäivä; }
            set { eräpäivä = value; }
        }


        public Kirjasto()
        {
            kirjanimi = "";
            kirjailija = "";
            eräpäivä = 0;
        }

        public Kirjasto(string u_kirjanimi, string u_kirjailija, int u_eräpäivä)
        {
            kirjanimi = u_kirjanimi;
            kirjailija = u_kirjailija;
            eräpäivä = u_eräpäivä;
        }
    }
}
