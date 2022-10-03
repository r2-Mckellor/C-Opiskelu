using System;

namespace Olio_tehtävä_4
{
    class Koulu
    {
        private string oppilasnimi;
        private int ika;
        private int arvosana;
        public static int laskuri;
    

        public Koulu()
        {
            oppilasnimi = "";
            ika = 0;
            arvosana = 0;
            laskuri++;
         
        }

        public static string NimenMuutos()
        {
            Console.Write("Mikä on opiskelijan nimi: ");
            oppilasnimi = Console.ReadLine();
            return oppilasnimi;
        }

        public static int Vanhene()
        {
            Console.Write("Kuinka vanha hän on: ");
            ika = int.Parse(Console.ReadLine());
            return ika;
        }

        public static int ArvosananMuutos()
        {
            Console.Write("Kuinka hyvin hän on pärjännyt: ");
            Arvosana = int.Parse(Console.ReadLine());
            return Arvosana;
        }

        public Koulu(string u_oppilasnimi, int u_ika, int u_arvosana)
        {
            oppilasnimi = u_oppilasnimi;
            ika = u_ika;
            arvosana = u_arvosana;
            laskuri++;
        }

        public string Oppilasnimi
        {
            set { oppilasnimi = value; }
            get { return oppilasnimi; }
        }

        public int Ika
        {
            set { ika = value; }
            get { return ika; }
        }

        public int Arvosana
        {
            set { arvosana = value; }
            get { return arvosana; }
        }
       
        public static int OlioMaara()
        {
            return laskuri;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Koulu oppilas1 = new Koulu
            {
                Oppilasnimi = Koulu.NimenMuutos(),
                Ika = Koulu.Vanhene(),
                Arvosana = Koulu.ArvosananMuutos()
            };
            Console.WriteLine("Tuotteen nimi on {0}, tuotteen ika on {1}, tuotteita on varastossa {2} ja saatavuus on {3}. Käytit getteriä ja setteriä sekä loit uuden olion.\n", oppilas1.Oppilasnimi, oppilas1.Ika, oppilas1.Arvosana);

            /* Koulu yleistiedot = new Koulu(u_oppilasnimi, u_ika, u_arvosana);
            Console.WriteLine("Tuotteen nimi on {0}, tuotteen Ika on {1}, tuotteita on varastossa {2} ja saatavuus on {3}. Loit uuden olion ja käytit getteriä.\n", yleistiedot.Oppilasnimi, yleistiedot.Ika, yleistiedot.Arvosana);

            Koulu oletustiedot = new Koulu();
            Console.WriteLine("Tuotteen nimi on {0}, tuotteen Ika on {1} ja tuotteita on varastossa {2}. Loit uuden olion ja käytit getteriä.\n", oletustiedot.Oppilasnimi, oletustiedot.Ika, oletustiedot.Arvosana);*/

            Console.WriteLine("Loit näin monta uutta oliota: " + Koulu.OlioMaara());
        }
    }
}