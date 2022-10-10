using System;

namespace Olio_tehtävä_6
{
    class Kulkuneuvo
    {
        public string kulkuneuvo;

        public Kulkuneuvo()
        {
            kulkuneuvo = "";
        }
    }

    class Tiedot : Kulkuneuvo
    {
        private int nopeus;
        private int matkustajat;
        public static int laskuri;


        public Tiedot() : base()
        {
            Kulkuneuvo = "";
            nopeus = 0;
            matkustajat = 0;
            laskuri++;
        }
        public Tiedot(int u_nopeus, int u_matkustajat)
        {
            nopeus = u_nopeus;
            matkustajat = u_matkustajat;
            laskuri++;
        }


        public string Kulkuneuvo
        {
            set { Kulkuneuvo = value; }
            get { return Kulkuneuvo; }
        }
        public int Nopeus
        {
            set { nopeus = value; }
            get { return nopeus; }
        }

        public int Matkustajat
        {
            set { matkustajat = value; }
            get { return matkustajat; }
        }

        public static int Oliomaara()
        {
            return laskuri;
        }

        static void Main(string[] args)
        {
            Tiedot menopeli = new Tiedot();
            string u_kulkuneuvo;
            int u_nopeus;
            int u_matkustajat;
        }
    }

}

