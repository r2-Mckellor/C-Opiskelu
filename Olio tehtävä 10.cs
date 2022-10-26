using System;

namespace Olio_tehtävä_10
{
    class Opiskelija
    {
        private string nimi;
        private int oppilasnro;
        private int osoite;
        private int kurssit;

        public Opiskelija()
        {
            nimi = "";
            oppilasnro = 0;
            osoite = 0;
            kurssit = 0;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }

        public Opiskelija(string u_nimi, int u_oppilasnro, int u_osoite, int u_kurssit)
        {
            nimi = u_nimi;
            oppilasnro = u_oppilasnro;
            osoite = u_osoite;
            kurssit = u_kurssit;
            Console.WriteLine("Käytit ylikuormitettua konstruktoria.");
        }

        public string Nimi
        {
            set { Console.WriteLine("Käytit setteriä."); nimi = value; }
            get { Console.WriteLine("Käytit getteriä."); return nimi; }
        }


        public int Oppilasnro
        {
            set { Console.WriteLine("Käytit setteriä."); oppilasnro = value; }
            get { Console.WriteLine("Käytit getteriä."); return oppilasnro; }
        }

        public int Osoite
        {
            set { Console.WriteLine("Käytit setteriä."); osoite = value; }
            get { Console.WriteLine("Käytit getteriä."); return osoite; }
        }

        public int Kurssit
        {
            set { Console.WriteLine("Käytit setteriä."); kurssit = value; }
            get { Console.WriteLine("Käytit getteriä."); return kurssit; }
        }

        public string OpiskelijaTiedot()
        {
            nimi = OpiskelijaNimi();
            oppilasnro = OpiskelijaNumero();
            kurssit = OpiskelijaKurssit();
            return null;
        }

        public string OpiskelijaNimi()
        {
            
            string[] etuNimia = new string[] { "Teppo", "Seppo", "Alina", "Jeppe", "Joakim", "Taru", "Jan", "Eevertti" };
            string[] sukuNimia = new string[] { "Mäkinen", "Jokinen", "Mäkelä", "Kiviranta", "Virtanen" };
            loop:
            Random rnd1 = new Random(DateTime.Now.Second);
            string u_nimi = etuNimia[rnd1.Next(0, etuNimia.Length - 1)];
            return u_nimi;
            goto loop;
        }

        public int OpiskelijaNumero()
        {
            Random rnd2 = new Random();
            int u_oppilasnro = rnd2.Next(1000, 9999);
            return u_oppilasnro;
        }

        public int OpiskelijaKurssit()
        {
            Random rnd3 = new Random();
            int u_kurssit = rnd3.Next(20);
            return u_kurssit;
        }

        public void OpiskelijaLista()
        {
            Console.WriteLine("-------------------\n" + "Opiskelijan nimi: " + Nimi + "\nOpiskelija numero: " + Oppilasnro + "#" + "\nOpiskelijan osoite: " + Osoite + "\nKursseja suoritettu: " + Kurssit + "\n-------------------");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arttu Mäkelä / Olio tehtävä 10\n\n");

            Opiskelija[] koululainen = new Opiskelija[5];

            string u_nimi = "";
            int u_oppilasnro = 0;
            int u_osoite = 0;
            int u_kurssit = 0;

            for (int i = 0; i < 5; i++)
            {
                koululainen[i] = new Opiskelija(u_nimi, u_oppilasnro, u_osoite, u_kurssit);
                Console.WriteLine(koululainen[i].OpiskelijaTiedot());
            }

            koululainen[0].OpiskelijaLista();
            koululainen[1].OpiskelijaLista();
            koululainen[2].OpiskelijaLista();
            koululainen[3].OpiskelijaLista();
            koululainen[4].OpiskelijaLista();


        }
    }
}