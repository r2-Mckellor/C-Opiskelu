using System;

namespace Olio_tehtävä_7
{
    class Kiuas
    {
        private int lampotila;
        private int kosteus;
        public static int laskuri = 0;

        public Kiuas()
        {
            lampotila = 0;
            kosteus = 0;
            laskuri++;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }

        public Kiuas(int u_lampotila, int u_kosteus)
        {
            lampotila = u_lampotila;
            kosteus = u_kosteus;
            laskuri++;
            Console.WriteLine("Käytit ylikuormitettua konstruktoria.");
        }

        public int Lampotila
        {
            set { Console.WriteLine("Käytit setteriä."); lampotila = value; }
            get { Console.WriteLine("Käytit getteriä."); return lampotila; }
        }

        public int Kosteus
        {
            set { Console.WriteLine("Käytit setteriä."); kosteus = value; }
            get { Console.WriteLine("Käytit getteriä."); return kosteus; }
        }

        public int LampoTilanMuutos()
        {
            Console.WriteLine("LampoTilanMuutos metodia käytetty");
            Console.Write("Kuinka paljon celsius asteita haluaisit nostaa tai laskea: ");
            lampotila = int.Parse(Console.ReadLine());
            return lampotila;
        }

        public int KosteudenTilanMuutos()
        {
            Console.WriteLine("KosteudenTilanMuutos metodia käytetty");
            Console.Write("Kuinka paljon kosteutta haluaisit nostaa tai laskea: ");
            kosteus = int.Parse(Console.ReadLine());
            return kosteus;
        }

        public void KiuasTilanne()
        {
            Console.WriteLine("-------------\n" + "Saunan lämpötila on asetettu: " + Lampotila + "°C" + "\nSaunan kosteus prosentti on asetettu: " + Kosteus + "%" + "\n-------------");
        }
    }

    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arttu Mäkelä / Olio tehtävä 7\n\n");

            Kiuas sauna1 = new Kiuas();

            sauna1.Lampotila = 21;
            sauna1.Kosteus = 0;
            sauna1.KiuasTilanne();

            Kiuas sauna2 = new Kiuas();
            string vastaus;
            loop:

            Console.Write("Haluatko käynnistää saunan? (K/E): ");
            vastaus = Console.ReadLine();

            if (vastaus == "K" || vastaus == "k")
            {
                sauna2.LampoTilanMuutos();
                sauna2.Lampotila = sauna1.Lampotila + sauna2.Lampotila;
                sauna2.KosteudenTilanMuutos();
                sauna2.Kosteus = sauna1.Kosteus + sauna2.Kosteus;
                goto loop;
            }

            else
            {
                sauna2.KiuasTilanne();
                Console.WriteLine("Loit {0} oliota.", Kiuas.laskuri);
            }
        }
    }
}
