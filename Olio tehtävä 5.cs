using System;

namespace Olio_tehtävä_5
{
    class Koulu
    {
        private string oppilasnimi;
        private int ika;
        private int arvosana;
        public static int laskuri = 0;


        public Koulu()
        {
            oppilasnimi = "";
            ika = 0;
            arvosana = 0;
            laskuri++;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }

        public Koulu(string u_oppilasnimi, int u_ika, int u_arvosana)
        {
            oppilasnimi = u_oppilasnimi;
            ika = u_ika;
            arvosana = u_arvosana;
            laskuri++;
            Console.WriteLine("Käytit ylikuormitettua konstruktoria.");
        }
        public string Oppilasnimi
        {
            set { Console.WriteLine("Käytit setteriä."); oppilasnimi = value; }
            get { Console.WriteLine("Käytit getteriä."); return oppilasnimi; }
        }

        public int Ika
        {
            set { Console.WriteLine("Käytit setteriä."); ika = value; }
            get { Console.WriteLine("Käytit getteriä."); return ika; }
        }

        public int Arvosana
        {
            set { Console.WriteLine("Käytit setteriä."); arvosana = value; }
            get { Console.WriteLine("Käytit getteriä."); return arvosana; }
        }

        public string UusiOpiskelija()
        {
            Console.WriteLine("UusiOpiskelija metodia käyetty");
            Console.Write("Mikä on opiskelijan nimi: ");
            oppilasnimi = Console.ReadLine();
            Console.Write("Kuinka vanha hän on: ");
            ika = int.Parse(Console.ReadLine());
            Console.Write("Kuinka hyvin hän on pärjännyt: ");
            arvosana = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Uusi opikelija {0} luotu.", oppilasnimi);
            return null;
        }

        public string NimenMuutos()
        {
            Console.WriteLine("NimenMuutos metodia käyetty");
            Console.Write("Mikä on opiskelijan uusi nimi: ");
            oppilasnimi = Console.ReadLine();
            return oppilasnimi;
        }

        public int Vanhene()
        {
            int lisays;
            Console.WriteLine("Vanhene metodia käyetty");
            Console.Write("Kuinka monta vuotta {0} on vanhentunut: ", oppilasnimi);
            lisays = int.Parse(Console.ReadLine());
            int u_ika = ika + lisays;
            for (int i = ika; i <= u_ika; i++)
            {
                ika++;
                Console.WriteLine("Oppilas vanheni vuodella ja on nyt {0} vuotias", Ika);
                
                if (ika == 18)
                {
                    Console.WriteLine("Oppilas on täysi-ikäinen");
                }
            }
            return ika;
        }

        public int ArvosananMuutos()
        {
            Console.WriteLine("ArvosananMuutos metodia käyetty");
            Console.Write("Mikä on {0} uusi arvosana: ", oppilasnimi);
            Arvosana = int.Parse(Console.ReadLine());
            return Arvosana;
        }

        public void OpiskelijaLista()
        {
            Console.WriteLine("-------------\n" + " Nimi: " + oppilasnimi + " \n Ikä: " + ika + " \n Arvosana: " + arvosana + "\n-------------");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arttu Mäkelä / Olio tehtävä 5\n\n");

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
                    oppilas[i].NimenMuutos();
                    oppilas[i].ArvosananMuutos();
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
            Console.WriteLine("Loit {0} uutta oliota: ", Koulu.laskuri);
        }
    }
}