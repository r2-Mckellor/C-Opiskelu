using System;

namespace Harjoituksia_E
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
                Console.Write("Minkä ikäinen olet?\n");
                int ikä = int.Parse(Console.ReadLine());

                Console.WriteLine(ikä + " näytät ikäistäsi nuoremmalta");
            }

            static void Tehtava2()
            {
                int luku;
                start:
                    Console.WriteLine("Anna kymmenen tai suurempi luku: ");
                    luku = Int32.Parse(Console.ReadLine());

                if (luku < 10)
                {
                    Console.WriteLine("Antamasi luku on liian pieni");
                    goto start;
                }
               
                for (int a = 0; a < luku; a++)
                {
                    for (int b = 0; b < luku; b++)
                    {
                        Console.Write(luku + " ");
                    }
                    Console.WriteLine();
                    for (int k = 0; k < luku; k++)
                    {
                        Console.Write(luku);
                    }
                    Console.WriteLine();
                }
            }

            static void Tehtava3()
            {
                string sana, uusisana;
                int pituus;
                Console.Write("Anna sana, jonka ensimmäinen ja viimeinen kirjain vaihdetaan keskenään: ");
                sana = Console.ReadLine();
                pituus = sana.Length;
                char[] taulu = new char[pituus];
                for (int i = 0; i < pituus; i++)
                    taulu[i] = sana[i];
                taulu[0] = sana[pituus - 1];
                taulu[pituus - 1] = sana[0];
                uusisana = String.Join("", taulu);
                Console.WriteLine("Annoit sanan {0} ja se on muutettuja {1}", sana, uusisana);
            }

            static void Tehtava4()
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());

                if (luku1 >= 0 && luku2 >= 0)
                {
                    Console.WriteLine("Molemmat ovat positiivisia");
                }

                else if (luku1 < 0 && luku2 < 0)
                {
                    Console.WriteLine("Molemmat ovat negatiivisia");
                }

                else
                {
                    Console.WriteLine("Toinen on positiivinen ja toinen negatiivinen");
                }
            }

            static void Tehtava5()
            {
                Console.WriteLine("Tämä ohjelma pyytää käyttäjältä lausetta ja palauttaa lauseen pisimmin sanan.");
                string lause;
                Console.Write("Anna lause: ");
                lause = Console.ReadLine();
                string[] taulu = lause.Split(' ');
                string pisin = taulu[0];
                for (int i = 1; i < taulu.Length; i++)
                {
                    if (taulu[i].Length > pisin.Length)
                    {
                        pisin = taulu[i];
                    }
                }
                Console.WriteLine("Antamasi lause oli {0}, jonka pisin sana oli {1}.", lause, pisin);
            }

            static void Tehtava6()
            {
                Console.WriteLine("Tämä ohjelma tulostaa parittomat luvut väliltä 1-99.");
                for (int i = 1; i <= 99; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            static void Tehtava7()
            {
                Console.WriteLine("Tämä ohjelma tulostaa kolmella jaolliset luvut väliltä 1-99.");
                for (int i = 3; i <= 99; i += 3)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
