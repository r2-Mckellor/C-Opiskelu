using System;

namespace Matikkaa
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 9;

            Console.WriteLine(Math.Max(x, y)); //Etsii annettujen lukujen suurimman arvon
            Console.WriteLine(Math.Min(x, y)); // Etsii annettujen lukujen pienimmän arvon
            Console.WriteLine(Math.Sqrt(x)); // Laskee annetun arvon potenssiin
            Console.WriteLine(Math.Round(8.9)); // Pyöristää annetun luvun
        }
    }
}
