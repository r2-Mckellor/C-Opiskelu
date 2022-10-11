using System;

namespace Olio_tehtävä_6
{
    class Kulkuneuvo
    {
        private int nopeus;
        private int matkustajat;
        public static int laskuri = 0;

        public Kulkuneuvo()
        {
            nopeus = 0;
            matkustajat = 0;
            laskuri++;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }
        public Kulkuneuvo(int u_nopeus, int u_matkustajat)
        {
            nopeus = u_nopeus;
            matkustajat = u_matkustajat;
            laskuri++;
            Console.WriteLine("Käytit ylikuormitettua konstruktoria.");
        }

        public int Nopeus
        {

            set { Console.WriteLine("Käytit setteriä."); nopeus = value; }
            get { Console.WriteLine("Käytit setteriä."); return nopeus; }
        }

        public int Matkustajat
        {
            set { Console.WriteLine("Käytit setteriä."); matkustajat = value; }
            get { Console.WriteLine("Käytit getteriä."); return matkustajat; }
        }

        class Auto : Kulkuneuvo
        {
            private string malli;

            public void AutonTiedot()
            {
                Console.Write("Mikä on autosi merkki: ");  
                malli = Console.ReadLine();
            }
            public void Kulkuneuvotiedot1()
            {
                Console.WriteLine("-------------------------------\n" + "Auton nopeus on {0}km/h" + "\nAutoon mahtuu {1} matkustajaa" + "\nJa auton Malli on {2}" + "\n-------------------------------", Nopeus, Matkustajat, Malli);
                Console.WriteLine("Käytit metodia");
            }

            public Auto() : base()
            {
                malli = "";
            }

            public Auto(string u_malli)
            {
                malli = u_malli;
            }

            public string Malli
            {
                set { Console.WriteLine("Käytit setteriä."); malli = value; }
                get { Console.WriteLine("Käytit getteriä."); return malli; }
            }

        }

        class Laiva : Kulkuneuvo
        {
            private string tuottaja;
            public void LaivanTiedot()
            {
                Console.Write("Mikä on laivasi tuottaja: ");
                tuottaja = Console.ReadLine();
            }
            public void Kulkuneuvotiedot2()
            {
                Console.WriteLine("-------------------------------\n" + "Laivan nopeus on {0}km/h" + "\nLaivaann mahtuu {1} matkustajaa" + "\nJa Laivan tuottaja on {2}" + "\n-------------------------------", Nopeus, Matkustajat, Tuottaja);
                Console.WriteLine("Käytit metodia");
            }

            public Laiva() : base()
            {
                tuottaja = "";
            }

            public Laiva(string u_tuottaja)
            {
                tuottaja = u_tuottaja;
            }

            public string Tuottaja
            {
                set { Console.WriteLine("Käytit setteriä."); tuottaja = value; }
                get { Console.WriteLine("Käytit getteriä."); return tuottaja; }
            }

        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Arttu Mäkelä / Olio tehtävä 6\n\n");

            Laiva menopeli0 = new Laiva();
            menopeli0.Kulkuneuvotiedot2();
            Console.WriteLine();

            Auto menopeli1 = new Auto();
            Console.Write("Anna Auton nopeus: ");
            menopeli1.Nopeus = int.Parse(Console.ReadLine());
            Console.Write("Anna Auton matkustajien määrä: ");
            menopeli1.Matkustajat = int.Parse(Console.ReadLine());
            menopeli1.AutonTiedot();
            menopeli1.Kulkuneuvotiedot1();
            Console.WriteLine();

            Auto menopeli2 = new Auto();
            Console.Write("Anna Auton nopeus: ");
            menopeli2.Nopeus = int.Parse(Console.ReadLine());
            Console.Write("Anna Auton matkustajien määrä: ");
            menopeli2.Matkustajat = int.Parse(Console.ReadLine());
            menopeli2.AutonTiedot();
            menopeli2.Kulkuneuvotiedot1();
            Console.WriteLine();

            int u_nopeus = 0;
            int u_matkustajat = 0;
            string u_tuottaja = "";

            Console.Write("Anna laivan nopeus: ");
            u_nopeus = int.Parse(Console.ReadLine());
            Console.Write("Anna laivan matkustajien määrä: ");
            u_matkustajat = int.Parse(Console.ReadLine());
            Console.Write("Anna laivan tuottaja: ");
            u_tuottaja = Console.ReadLine();
            Laiva menopeli3 = new Laiva(u_nopeus, u_matkustajat, u_tuottaja);
            Console.WriteLine("-------------------------------\n" + "Laivan nopeus on {0}km/h" + "\nLaivaan mahtuu {1}" + " matkustajaa" + "\nJa laivan tuottaja on {2}" + "\n-------------------------------", menopeli3.Nopeus, menopeli3.Matkustajat, menopeli3.Tuottaja);
            Console.WriteLine();

            Console.WriteLine("Loit {0} oliota.", Kulkuneuvo.laskuri);
        }
    }
}