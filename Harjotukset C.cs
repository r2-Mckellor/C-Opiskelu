using System;

namespace Harjoituksia_C
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Valitse tehtävä 1-7: ");
            int tehtava = int.Parse(Console.ReadLine());
            Alku:
            switch (tehtava)
            {
                case 1:
                    Tehtava1();
                    break;
                case 2:
                    Tehtava2();
                    break;
                case 3:
                    Tehtava3();
                    break;
                case 4:
                    Tehtava4();
                    break;
                case 5:
                    Tehtava5();
                    break;
                case 6:
                    Tehtava6();
                    break;
                case 7:
                    Tehtava7();
                    break;
                default:
                    Console.WriteLine("Sinun pitää valita tehtävien 1-7 välillä: ");
                    Console.ReadLine();
                    goto Alku;
            }

            static void Tehtava1()
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());

                int suurin = luku1;
                if (luku2 > suurin)
                {
                    Console.WriteLine("Luvut suuruusjärjestyksessä: " + luku2 + " ja " + luku1);
                }
                else
                {
                    Console.WriteLine("Luvut suuruusjärjestyksessä: " + luku1 + " ja " + luku2);
                }
            }

            static void Tehtava2()
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä kolmas arvo: ");
                int luku3 = int.Parse(Console.ReadLine());

                int suurin = luku1;
                if (luku2 > suurin)
                {
                    suurin = luku2;
                }
                if (luku3 > suurin)
                {
                    suurin = luku3;
                }
                Console.WriteLine("Suurin arvo oli " + suurin);
            }

            static void Tehtava3()
            {

                Console.Write("Anna numero 0-9: ");
                int arvo = int.Parse(Console.ReadLine());
            Alkuun:
                switch (arvo)
                {

                    case 0:
                        if (arvo == 0)
                            Console.WriteLine("Nolla");
                        break;
                    case 1:
                        if (arvo == 1)
                            Console.WriteLine("Yksi");
                        break;
                    case 2:
                        if (arvo == 2)
                            Console.WriteLine("Kaksi");
                        break;
                    case 3:
                        if (arvo == 3)
                            Console.WriteLine("Kolme");
                        break;
                    case 4:
                        if (arvo == 4)
                            Console.WriteLine("Neljä");
                        break;
                    case 5:
                        if (arvo == 5)
                            Console.WriteLine("Viisi");
                        break;
                    case 6:
                        if (arvo == 6)
                            Console.WriteLine("Kuusi");
                        break;
                    case 7:
                        if (arvo == 7)
                            Console.WriteLine("Seitsemän");
                        break;
                    case 8:
                        if (arvo == 8)
                            Console.WriteLine("Kahdeksan");
                        break;
                    case 9:
                        if (arvo == 9)
                            Console.WriteLine("Yhdeksän");
                        break;
                    default:
                        Console.Write("Et antanut numeroa 1-9. ");
                        arvo = int.Parse(Console.ReadLine());
                        goto Alkuun;
                }

            }

            static void Tehtava4()
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä kolmas arvo: ");
                int luku3 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä neljäs arvo: ");
                int luku4 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä viides arvo: ");
                int luku5 = int.Parse(Console.ReadLine());

                int suurin = luku1;
                if (luku2 > suurin)
                {
                    suurin = luku2;
                }
                if (luku3 > suurin)
                {
                    suurin = luku3;
                }
                if (luku4 > suurin)
                {
                    suurin = luku4;
                }
                if (luku5 > suurin)
                {
                    suurin = luku5;
                }
                Console.WriteLine("Suurin arvo oli " + suurin);
            }

            static void Tehtava5()
            {
                Console.WriteLine("Millaisen tiedon haluat syöttää? (k = kokonaisluku, d = desimaaliluku, m = merkkijono): ");
                string syote = Console.ReadLine();
            Alkuun:
                switch (syote)
                {

                    case "k":
                        Console.Write("Anna kokonaisluku: ");
                        int kl = int.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + kl + "johon lisäsin 1: " + (kl + 1));
                        break;
                    case "d":
                        Console.Write("Anna desimaaliluku: ");
                        decimal dl = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Annoit luvun " + dl + "johon lisäsin 1: " + (dl + 1));
                        break;
                    case "m":
                        Console.Write("Anna merkkijono: ");
                        string mj = Console.ReadLine();
                        Console.WriteLine("Annoit merkkijonon " + mj + ", johon lisäsin *: " + (mj + "*"));
                        break;
                    default:
                        Console.Write("Virheellinen syöte. Anna joko k, d tai m: ");
                        syote = Console.ReadLine();
                        goto Alkuun;
                }
            }

            static void Tehtava6()
            {
                Console.WriteLine("Anna arvo 1-9");
                int arvo = int.Parse(Console.ReadLine());
            Alkuun:
                switch (arvo)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Antamasi arvo muutui 10x: " + (arvo * 10));
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Antamasi arvo muutui 100x: " + (arvo * 100));
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Antamasi arvo muutui 1000x: " + (arvo * 1000));
                        break;
                    default:
                        Console.WriteLine("Antamasi arvo ei ollut 1-9 välillä");
                        arvo = int.Parse(Console.ReadLine());
                        goto Alkuun;
                }
            }

            static void Tehtava7()
            {
                string luku = "";
                Console.WriteLine("Anna arvo 0 - 999 välillä");
                string arvo = Console.ReadLine();
                int num = arvo.Length;

                if (num == 3)
                {
                    luku += sadat(arvo[0]);

                    if (arvo[1] == '1')
                    {
                        luku += teinit(arvo[2]);
                    }

                    else
                    {
                        luku += kymmenet(arvo[1]);
                        luku += ykköset(arvo[2]);
                    }
                }
                else if (num == 2)
                {
                    Console.WriteLine("num[0] = " + arvo[0]);

                    if (arvo[0] == '1')
                    {
                        luku += teinit(arvo[1]);
                    }
                    else
                    {
                        luku += kymmenet(arvo[0]);
                        luku += ykköset(arvo[1]);
                    }
                }
                else
                {
                    luku += ykköset(arvo[0]);
                }
                Console.WriteLine(luku);

                static string sadat(int nro)
                {
                    switch (nro)
                    {
                        case '9':
                            return "yhdeksänsataa ";
                        case '8':
                            return "kahdeksansataa ";
                        case '7':
                            return "seitsemänsataa ";
                        case '6':
                            return "kuusisataa ";
                        case '5':
                            return "viisisataa ";
                        case '4':
                            return "neljäsataa ";
                        case '3':
                            return "kolmesataa ";
                        case '2':
                            return "kaksisataa ";
                        case '1':
                            return "sata ";
                        default:
                            return "";
                    }
                }

                static string kymmenet(int nro)
                {
                    switch (nro)
                    {
                        case '9':
                            return "yhdeksänkymmentä ";
                        case '8':
                            return "kahdeksankymmentä ";
                        case '7':
                            return "seitsemänkymmentä ";
                        case '6':
                            return "kuusikymmentä ";
                        case '5':
                            return "viisikymmentä ";
                        case '4':
                            return "neljäkymmentä ";
                        case '3':
                            return "kolmekymmentä ";
                        case '2':
                            return "kaksikymmentä ";
                        case '1':
                            return "kymmenen ";
                        default:
                            return "";
                    }
                }

                static string teinit(int nro)
                {
                    switch(nro)
                    { 
                        case '9':
                           return "yhdeksäntoista";
                        case '8':
                           return "kahdeksantoista";
                        case '7':
                           return "seitsemäntoista";
                        case '6':
                           return "kuusitoista";
                        case '5':
                           return "viisitoista";
                        case '4':
                           return "neljätoista";
                        case '3':
                           return "kolmetoista";
                        case '2':
                           return "kaksitoista";
                        case '1':
                           return "yksitoista";
                        default:
                           return "";
                    }
                 }

                static string ykköset(int nro)
                {
                    switch(nro)
                    {
                        case '9':
                            return "yhdeksän";
                        case '8':
                            return "kahdeksan";
                        case '7':
                            return "seitsemän";
                        case '6':
                            return "kuusi";
                        case '5':
                            return "viisi";
                        case '4':
                            return "neljä";
                        case '3':
                            return "kolme";
                        case '2':
                            return "kaksi";
                        case '1':
                            return "yksi";
                        default:
                            return "";
                    }
                }
            }       
        }
    }
}
