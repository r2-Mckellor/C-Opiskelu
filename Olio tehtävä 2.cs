using System;

namespace Olio_tehtävä_2
{
    class Varasto
    {
        private string tuotenimi;
        private int paino;
        private int maara;
        private bool saatavuus;
        public static int laskuri;

        public Varasto()
        {
            tuotenimi = "";
            paino = 0;
            maara = 0;
            saatavuus = true;
            laskuri++;
        }

        public string nimenMuutos()
        {
            Console.Write("Anna tuotteen uusi nimi: ");
            tuotenimi = Console.ReadLine();
            return tuotenimi;
        }

        public int painonMuutos()
        {
            Console.Write("Anna tuotteen uusi paino: ");
            paino = int.Parse(Console.ReadLine());
            return paino;
        }

        public int maaranMuutos()
        {
            Console.Write("Anna tuotteen uusi määrä: ");
            maara = int.Parse(Console.ReadLine());
            return maara;
        }

        public bool Saatavuus()
        {
            Console.Write("Onko tuotetta saatavilla? (true/false): ");
            saatavuus = bool.Parse(Console.ReadLine());
            return saatavuus;
        }

        public Varasto(string u_tuotenimi, int u_paino, int u_maara, bool u_saatavuus)
        {
            tuotenimi = u_tuotenimi;
            paino = u_paino;
            maara = u_maara;
            saatavuus = u_saatavuus;
            laskuri++;
        }

        public string Tuotenimi
        {
            set { tuotenimi = value; }
            get { return tuotenimi; }
        }

        public int Paino
        {
            set { paino = value; }
            get { return paino; }
        }

        public int Maara
        {
            set { maara = value; }
            get { return maara; }
        }

        public bool HyllySaatavuus
        {
            set { saatavuus = value; }
            get { return saatavuus; }
        }

        public static int OlioMaara()
        {
            return laskuri;
        }
    }

    class program
    {
    
        static void Main(string[] args)
        {
            Varasto tiedot = new Varasto();
            string u_tuotenimi;
            int u_paino;
            int u_maara;
            bool u_saatavuus = true;

            Console.Write("Anna tuotteen nimi: ");
            u_tuotenimi = Console.ReadLine();
            Console.Write("Anna tuotteen paino: ");
            u_paino = int.Parse(Console.ReadLine());
            Console.Write("Anna tuotteen määrä: ");
            u_maara = int.Parse(Console.ReadLine());
            Console.Write("Onko tuotetta saatavilla? (true/false): ");
            u_saatavuus = bool.Parse(Console.ReadLine());

            tiedot.Tuotenimi = u_tuotenimi;
            tiedot.Paino = u_paino;
            tiedot.Maara = u_maara;

            Console.WriteLine("Tuotteen nimi on {0}, tuotteen paino on {1}, tuotteita on varastossa {2} ja saatavuus on {3}. Käytit getteriä ja setteriä sekä loit uuden olion.\n", tiedot.Tuotenimi, tiedot.Paino, tiedot.Maara, tiedot.HyllySaatavuus);

            Varasto yleistiedot = new Varasto(u_tuotenimi, u_paino, u_maara, u_saatavuus);
            Console.WriteLine("Tuotteen nimi on {0}, tuotteen paino on {1}, tuotteita on varastossa {2} ja saatavuus on {3}. Loit uuden olion ja käytit getteriä.\n", yleistiedot.Tuotenimi, yleistiedot.Paino, yleistiedot.Maara, yleistiedot.HyllySaatavuus);

            Varasto oletustiedot = new Varasto();
            Console.WriteLine("Tuotteen nimi on {0}, tuotteen paino on {1} ja tuotteita on varastossa {2}. Loit uuden olion ja käytit getteriä.\n", oletustiedot.Tuotenimi, oletustiedot.Paino, oletustiedot.Maara, oletustiedot.HyllySaatavuus);

            Console.WriteLine("Loit näin monta uutta oliota: " + Varasto.OlioMaara());
            }
        
    }
}