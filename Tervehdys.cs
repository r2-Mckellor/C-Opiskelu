using System;

namespace Tervehdys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei mikä sinun nimi on?");
            string nimi = Console.ReadLine();

            Console.WriteLine("Hei "+nimi+" hauska tutustua!");
        }
    }
}
