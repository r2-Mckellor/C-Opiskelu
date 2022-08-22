using System;

namespace Harjoitukset_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei anna ensimmäinen arvo");
            int lukuX = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna vielä toinen arvo");
            int lukuY = int.Parse(Console.ReadLine());

            Console.WriteLine("x = " + (lukuY + 3));
            Console.WriteLine("x = " + (lukuY - 2));
            Console.WriteLine("x = " + (lukuY * 5));
            Console.WriteLine("x = " + (lukuX / lukuY));
            Console.WriteLine("x = " + (lukuX % lukuY));
            Console.WriteLine("x = " + (lukuX += lukuY));
            Console.WriteLine("x = " + (lukuX -= lukuY));
            Console.WriteLine("x = " + (lukuX *= lukuY * 5));
            Console.WriteLine("x = " + (lukuX /= lukuY));
        }
    }
}