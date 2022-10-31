using System;

namespace Olio_tehtävä_10
{
    class Opiskelija
    {
        private string nimi;
        private int oppilasnro;
        private string osoite;
        private int kurssit;


        //Oletuskonstruktori
        public Opiskelija()
        {
            nimi = "";
            oppilasnro = 0;
            osoite = "";
            kurssit = 0;
            Console.WriteLine("Käytit oletuskonstruktoria");
        }


        //Ylikuormitettukonstruktori
        public Opiskelija(string u_nimi, int u_oppilasnro, string u_osoite, int u_kurssit)
        {
            nimi = u_nimi;
            oppilasnro = u_oppilasnro;
            osoite = u_osoite;
            kurssit = u_kurssit;
            Console.WriteLine("Käytit ylikuormitettuakonstruktoria.");
        }

        public string Nimi
        {
            set { nimi = value; }
            get { return nimi; }
        }


        public int Oppilasnro
        {
            set { oppilasnro = value; }
            get { return oppilasnro; }
        }

        public string Osoite
        {
            set { osoite = value; }
            get { return osoite; }
        }

        public int Kurssit
        {
            set { kurssit = value; }
            get { return kurssit; }
        }


        //Metodeja
        public string OpiskelijaTiedot()
        {
            Console.WriteLine("OpiskelijaTiedot metodia käytetty");
            nimi = OpiskelijaNimi();
            oppilasnro = OpiskelijaNumero();
            osoite = OpiskelijaOsoite();
            kurssit = OpiskelijaKurssit();
            return null;
        }

        public string OpiskelijaNimi()
        {
            Console.WriteLine("OpiskelijaNimi metodia käytetty");
            string[] etuNimia = new string[] { "Teppo", "Seppo", "Alina", "Jeppe", "Joakim", "Taru", "Jan", "Eevertti" };
            string[] sukuNimia = new string[] { "Mäkinen", "Jokinen", "Mäkelä", "Kiviranta", "Virtanen" };
            Random rnd1 = new Random();
            string u_nimi = etuNimia[rnd1.Next(0, etuNimia.Length - 1)] + " " + sukuNimia[rnd1.Next(0, sukuNimia.Length - 1)]; ;
            return u_nimi;
        }

        public int OpiskelijaNumero()
        {
            Console.WriteLine("OpiskelijaNumero metodia käytetty");
            Random rnd = new Random();
            int u_oppilasnro = rnd.Next(1000, 9999);
            return u_oppilasnro;
        }

        public string OpiskelijaOsoite()
        {
            Console.WriteLine("OpiskelijaOsoite metodia käytetty");
            string[] opiskelijaOsoite = new string[] { "Elontie", "Lepolantie", "Hämeentie", "Kalevalantie", "Osuuskunnantie", "Renkovahantie" };
            Random rnd = new Random();
            string u_osoite = opiskelijaOsoite[rnd.Next(0, opiskelijaOsoite.Length - 1)] + " " + rnd.Next(1, 50);
            return u_osoite;
        }

        public int OpiskelijaKurssit()
        {
            Random rnd = new Random();
            int u_kurssit = rnd.Next(20);
            return u_kurssit;
        }

        public void OpiskelijaLista()
        {
            Console.WriteLine("-------------------\n" + "Opiskelijan nimi: " + Nimi + "\nOpiskelijan osoite: " + Osoite +  "\nOpiskelija numero: " + Oppilasnro + "#" + "\nKursseja suoritettu: " + Kurssit + "\n-------------------");
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
            string u_osoite = "";
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