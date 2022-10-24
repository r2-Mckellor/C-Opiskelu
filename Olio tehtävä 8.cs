using System;

namespace Olio_tehtävä_8
{
    class Pesukone
    {
        private int ajastin;
        private int lampotila;
        private string pesutyyli;
        public static int laskuri = 0;

        public Pesukone()
        {
            ajastin = 0;
            lampotila = 0;
            pesutyyli = "";
            laskuri++;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }

        public Pesukone(int u_ajastin, int u_lampotila, string u_pesutyyli)
        {
            ajastin = u_ajastin;
            lampotila = u_lampotila;
            pesutyyli = u_pesutyyli;
            laskuri++;
            Console.WriteLine("Käytit ylikuormitettua konstruktoria.");
        }

        public int Ajastin
        {
            set { Console.WriteLine("Käytit setteriä."); ajastin = value; }
            get { Console.WriteLine("Käytit getteriä."); return ajastin; }
        }

        public int Lampotila
        {
            set { Console.WriteLine("Käytit setteriä."); lampotila = value; }
            get { Console.WriteLine("Käytit getteriä."); return lampotila; }
        }

        public string Pesutyyli
        {
            set { Console.WriteLine("Käytit setteriä."); pesutyyli = value; }
            get { Console.WriteLine("Käytit getteriä."); return pesutyyli; }
        }

        public int AjastimenAsetus()
        {
            Console.WriteLine("AjastimenAsetus metodia käytetty");
            Console.Write("Kuinka kauan aikaa haluaisit pesun kestävän minuuteissa: ");
            ajastin = int.Parse(Console.ReadLine());
            return ajastin;
        }

        public int LampotilanMuutos()
        {
            Console.WriteLine("LampoTilanMuutos metodia käytetty");
            Console.Write("Kuinka paljon celsius asteita haluaisit asettaa pesun ajaksi: ");
            lampotila = int.Parse(Console.ReadLine());
            return lampotila;
        }

        public string PesutyyylinAsetus()
        {
            Console.WriteLine("PesutyyylinAsetus metodia käytetty");
            loop:
            Console.Write("Valitse pesutyyli / Kirjopesu / Kuituyyppi / Eko /: ");
            pesutyyli = Console.ReadLine();

            if (pesutyyli == "Kirjopesu" || pesutyyli == "kirjopesu" || pesutyyli == "Kuituyyppi" || pesutyyli == "kuituyyppi" || pesutyyli == "Eko" || pesutyyli == "eko") 
            {
                return pesutyyli;
            }

            else
            {
                Console.WriteLine("En tunnista tuota asetusta");
                goto loop;
            }
        }

        public void PesukoneOhjelma()
        {
            Console.WriteLine("-------------\n" + "Pesu kestää: " + Ajastin + "min" + "\nPesukoneen lämpötila on asetettu: " + Lampotila + "°C" + "\nPesukone pesee: " + Pesutyyli + " tyylillä" + "\n-------------");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arttu Mäkelä / Olio tehtävä 8\n\n");

            Pesukone likaiset1 = new Pesukone();
            likaiset1.AjastimenAsetus();
            likaiset1.LampotilanMuutos();
            likaiset1.PesutyyylinAsetus();
            likaiset1.PesukoneOhjelma();

            Pesukone likaiset2 = new Pesukone();
            likaiset2.AjastimenAsetus();
            likaiset2.LampotilanMuutos();
            likaiset2.PesutyyylinAsetus();
            likaiset2.PesukoneOhjelma();

            Console.WriteLine("\nLoit {0} oliota.", Pesukone.laskuri);
        }
    }
}
