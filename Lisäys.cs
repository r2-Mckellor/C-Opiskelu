using System;

namespace Harjoitukset_B
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine("Hei anna arvo jonka voin laskea");
            int luku = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("valitsit " + luku + ", joka lisätään 3 kanssa");
            NewMethod(luku);
        }

        private static void NewMethod(int luku)
        {
            int x = luku;
            int y = 3;
            int sum = x + y;

            Console.WriteLine(sum);
        }
    }
}
