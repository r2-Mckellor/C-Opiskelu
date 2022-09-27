using System;

namespace Olio_ikä
{
    class Ikä
    {
        private string nimi;
        private int ika;
        private int syntymavuosi;


        public Ikä()
        {
            nimi = "Arttu Mäkelä";
            ika = 24;
            syntymavuosi = 1998;
        }

        public int laskeIka()
        {
            Console.WriteLine("laskeIka metodia käytetty");
            return ika;
        }

        public int palautaIka()
        {
            Console.WriteLine("palautaIka metodia käytetty");
            return ika;
        }

        public Ikä(string u_nimi, int u_ika, int u_syntymavuosi)
        {
            nimi = u_nimi;
            ika = u_ika;
            syntymavuosi = u_syntymavuosi;
        }

        public string Nimi
        {
            set { nimi = value; }
            get { return nimi; }
        }
        public int Ika
        {
            set { ika = value; }
            get { return ika; }
        }
        public int Syntymavuosi
        {
            set { syntymavuosi = value; }
            get { return syntymavuosi; }
        }


        class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine("Oliotesti/ Arttu Mäkelä\n\n");
                Console.WriteLine("Luodaan olion henk1");
                Console.WriteLine("Oletus konstruktoria käytetty");
                Ikä oma = new Ikä();

                Console.WriteLine("Mikä sinun nimesi on?: ");
                oma.Nimi = Console.ReadLine();

                Console.WriteLine("Minä vuonna olet syntynyt?: ");
                oma.Syntymavuosi = int.Parse(Console.ReadLine());
                oma.laskeIka();
                oma.palautaIka();

                DateTime nyt = DateTime.Now;
                int nyt_vuosi = nyt.Year - oma.Syntymavuosi;
                oma.Ika = nyt_vuosi;

           
                Console.WriteLine("{0} täytät/täytit tänä vuonna {1} vuotta!\n\n", oma.Nimi, oma.Ika );

                Console.WriteLine("Luodaan olion henk2");
                Console.WriteLine("Ylikuormitettua konstruktoria käytetty");
                Ikä oma1 = new Ikä();
                oma.laskeIka();
                oma.palautaIka();

                Console.WriteLine("{0} täytät/täytit tänä vuonna {1} vuotta!", oma1.Nimi, oma1.Ika);
            }
        }
    }
}