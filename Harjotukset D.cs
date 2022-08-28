using System;

namespace Harjoituksia_D
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Valitse tehtävä 1-10: ");
            int tehtava = int.Parse(Console.ReadLine());
            Alku:
            switch (tehtava)
            {
                case 1:
                    Tehtava1(3, 5);
                    break;
                case 2:
                    Tehtava2(10);
                    break;
               case 3:
                    Tehtava3(8, 5);
                    break;
                case 4:
                    Tehtava4(5, 2);
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
                case 8:
                    Tehtava8();
                    break;
                case 9:
                    Tehtava9();
                    break;
                case 10:
                    Tehtava10();
                    break;
                default:
                    Console.WriteLine("Sinun pitää valita tehtävien 1-7 välillä: ");
                    Console.ReadLine();
                    goto Alku;
            }
            
            static void Tehtava1(int a, int b)
            {
                Console.WriteLine("Tulos on: " + (a + b));
            }
            
            static void Tehtava2(int a)
            {
                Console.WriteLine( a + " Celsius atetta Farenheiteissa on: " + ((a * 1.8) + 32));
            }

            static void Tehtava3(int a, int b)
            {
                Console.WriteLine(a + " + " + b + " = " + (a + b));
                Console.WriteLine(a + " - " + b + " = " + (a - b));
                Console.WriteLine(a + " * " + b + " = " + (a * b));
                Console.WriteLine(a + " / " + b + " = " + ((double)a / b));

            }

            static void Tehtava4(int a, int b)
            {
                Console.WriteLine("lukujen jakojöönnös on: " + (a % b));
            }
            
            static void Tehtava5()
            {
                string nimi;
                Console.WriteLine("Mikä on nimesi?");
                nimi = Console.ReadLine();
                Console.WriteLine("Hei " + nimi + "!");
            }
            
            static void Tehtava6()
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Antamasi luvut ovat yhteen laskettuna: " + (luku1 + luku2));
            }
            
            static void Tehtava7()
            {
                Console.Write("Anna Ceslius aste: ");
                int luku1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Antamasi Ceslius aste on Faarenheiteissa: " + ((luku1*1.8)+32));
            }

            static void Tehtava8()  
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());
                
                Console.WriteLine(luku1 + " + " + luku2 + " = " + (luku1 + luku2));
                Console.WriteLine(luku1 + " - " + luku2 + " = " + (luku1 - luku2));
                Console.WriteLine(luku1 + " * " + luku2 + " = " + (luku1 * luku2));
                Console.WriteLine(luku1 + " / " + luku2 + " = " + ((double)luku1 / luku2));
            }

            static void Tehtava9()
            {
                Console.Write("Anna ensimmäinen arvo: ");
                int luku1 = int.Parse(Console.ReadLine());
                Console.Write("Anna vielä toinen arvo: ");
                int luku2 = int.Parse(Console.ReadLine());

                Console.WriteLine("lukujen jakojöönnös on: " + (luku1 % luku2));
            }

            static void Tehtava10()
            {
                Console.Write("Anna arvo: ");
                int luku1 = int.Parse(Console.ReadLine());

                Console.WriteLine(" 1 x " + luku1 + " = " + (1 * luku1));
                Console.WriteLine(" 2 x " + luku1 + " = " + (2 * luku1));
                Console.WriteLine(" 3 x " + luku1 + " = " + (3 * luku1));
                Console.WriteLine(" 4 x " + luku1 + " = " + (4 * luku1));
                Console.WriteLine(" 5 x " + luku1 + " = " + (5 * luku1));
                Console.WriteLine(" 6 x " + luku1 + " = " + (6 * luku1));
                Console.WriteLine(" 7 x " + luku1 + " = " + (7 * luku1));
                Console.WriteLine(" 8 x " + luku1 + " = " + (8 * luku1));
                Console.WriteLine(" 9 x " + luku1 + " = " + (9 * luku1));
                Console.WriteLine(" 10 x " + luku1 + " = " + (10 * luku1));
            }

        }
    }
}
