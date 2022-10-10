using System;

namespace Olio_tehtävä_6
{
    class Kulkuneuvo
    {
            private int nopeus;
            private int matkustajat;
            public static int laskuri = 0;

        public void TulostaTiedot()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ajoneuvon nopeus on: {0}km/h" + " \nAjoneuvon matkustajien määrä on: " + matkustajat, nopeus);
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
        }
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
                get { return nopeus; }
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
                    Console.WriteLine("Mikä on autosi merkki: ");
                    malli = Console.ReadLine();
                    Console.WriteLine("Autosi merkki on {0}", malli);
                }
                public void Kulkuneuvotiedot()
                {
                    Console.WriteLine("Auton nopeus on {0}" + "\nAutoon mahtuu {1} matkustajaa" + "Ja auton Malli on {2}", Nopeus, Matkustajat, Malli);
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
                    Console.WriteLine("Mikä on laivasi tuottaja: ");
                    tuottaja = Console.ReadLine();
                    Console.WriteLine("Laivasi tuotti {0}", tuottaja);
                }
                public void Kulkuneuvotiedot()
                {
                    Console.WriteLine("Laivan nopeus on {0}" + "\nLaivaan mahtuu {1} matkustajaa" + "Ja laivan tuottaja on {2}", Nopeus, Matkustajat, tuottaja);
                    Console.WriteLine("Käytit metodia");
                }

                public Laiva() : base()
                {
                    tuottaja = "";
                }

                public Laiva(int u_nopeus, int u_matkustajat, string u_tuottaja) : base(u_nopeus, u_matkustajat)
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

                Auto menopeli1 = new Auto();
                Console.WriteLine("Auton nopeus on {0}km/h" + "\nAutoon mahtuu " + menopeli1.Matkustajat + " matkustajaa", menopeli1.Nopeus);
                Console.WriteLine();

                Auto menopeli2 = new Auto();
                Console.Write("Anna Auton nopeus: ");
                menopeli2.Nopeus = int.Parse(Console.ReadLine());
                Console.Write("Anna Auton matkustajien määrä: ");
                menopeli2.Matkustajat = int.Parse(Console.ReadLine());
                Console.WriteLine("Auton nopeus on {0}km/h" + "\nAutoon mahtuu " + menopeli2.Matkustajat + " matkustajaa", menopeli2.Nopeus);
                Console.WriteLine();

                int u_nopeus = 0;
                int u_matkustajat = 0;
                string u_tuottaja= "";

                Console.Write("Anna laivan nopeus: ");
                u_nopeus = int.Parse(Console.ReadLine());
                Console.Write("Anna laivan matkustajien määrä: ");
                u_matkustajat = int.Parse(Console.ReadLine());
                Console.Write("Anna laivan tuottaja: ");
                u_tuottaja = Console.ReadLine();
                Laiva menopeli3 = new Laiva(u_nopeus, u_matkustajat, u_tuottaja);
                Console.WriteLine("Auton nopeus on {0}km/h" + "\nAutoon mahtuu " + menopeli3.Matkustajat + " matkustajaa", menopeli3.Nopeus);
                Console.WriteLine();

                Laiva menopeli4 = new Laiva();

                Console.WriteLine();
                menopeli4.TulostaTiedot();
                Console.WriteLine("Loit {0} oliota.", Kulkuneuvo.laskuri);
             }
        }
    }
