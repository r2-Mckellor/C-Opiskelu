using System;

namespace Olio_tehtävä_5
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

        public string UusiOpiskelija()
        {
            Console.Write("Mikä on opiskelijan nimi: ");
            oppilasnimi = Console.ReadLine();
            Console.Write("Kuinka vanha hän on: ");
            ika = int.Parse(Console.ReadLine());
            Console.Write("Kuinka hyvin hän on pärjännyt: ");
            arvosana = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Uusi opiskelija '{0}' luotu.", oppilasnimi);
            return null;
        }

        public string NimenMuutos()
        {
            Console.Write("Mikä on opiskelijan nimi: ");
            oppilasnimi = Console.ReadLine();
            return oppilasnimi;
        }

        public void Vanhene()
        {
            Console.Write("Kuinka vanha hän on: ");
            ika = int.Parse(Console.ReadLine());

            for (int i = 0; i < ika;)
            {
                ika++;
                Console.Write("Oppiskelija vanheni vuoden. opiskelija on nyt {0} vuotta vanha.", ika);
                Console.WriteLine();

                if (ika >= 18)
                {
                    Console.WriteLine("Opiskelija on täysi-ikäinen!");
                }

                Console.WriteLine();
                Console.Write("Haluatko vanhentaa opiskelijata? (K/E) ");
                string vastaus = Console.ReadLine();
                if (vastaus == "E" || vastaus == "e")
                {
                    Console.WriteLine("Siirrytään uuteen oppilaaseen...");
                    break;
                }
            }
        
        }

        public int ArvosananMuutos()
        {
            Console.Write("Kuinka hyvin hän on pärjännyt: ");
            Arvosana = int.Parse(Console.ReadLine());
            return Arvosana;
        }

        public void OpiskelijaLista()
        {
            Console.WriteLine("-------------");
            Console.WriteLine(" Nimi: " + oppilasnimi + " \n Ikä: " + ika + " \n Arvosana: " + arvosana);
            Console.WriteLine("-------------");
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

    internal class Program
    {
        static void Main(string[] args)
        {
            Koulu[] oppilas = new Koulu[4];
            string vastaus;

            for (int i = 0; i < 4; i++)
            {
                oppilas[i] = new Koulu();
                Console.WriteLine(oppilas[i].UusiOpiskelija());
            }

            oppilas[0].OpiskelijaLista();
            oppilas[1].OpiskelijaLista();
            oppilas[2].OpiskelijaLista();
            oppilas[3].OpiskelijaLista();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Haluatko muuttaa tietoja? (K/E): ");
                vastaus = Console.ReadLine();

                if (vastaus == "K" || vastaus == "k")
                {
                    Console.Write("Anna oppilaan {0} uusi arvosana: ", oppilas[i].Oppilasnimi);
                    oppilas[i].Arvosana = int.Parse(Console.ReadLine());
                    Console.Write("Oppilaan {0} uusi arvosana on {1}", oppilas[i].Oppilasnimi, oppilas[i].Arvosana);
                    Console.WriteLine();
                    oppilas[i].Vanhene();
                }
                else
                {
                    Console.WriteLine("Lopetetaan...");
                    goto loppu;
                }
            }

            oppilas[0].OpiskelijaLista();
            oppilas[1].OpiskelijaLista();
            oppilas[2].OpiskelijaLista();
            oppilas[3].OpiskelijaLista();
        loppu:;
            Console.WriteLine("Loit näin monta uutta oliota: " + Koulu.OlioMaara());
        }
    }
}