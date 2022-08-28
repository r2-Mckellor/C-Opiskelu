using System;

namespace Harjoituksia_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            
            Console.WriteLine("Hyvää päivää!");
            
            Console.WriteLine("Arttu Mäkelä");
            
            Console.WriteLine("1\n11\n101\n1001");
            
            Console.WriteLine("Mikä on sinun nimesi?");
            string nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi + " hauska tavata");

            DateTime aDate = DateTime.Now; //DateTime.Now tarkoittaa tätä päivää
            string päivä = "tänään on " + aDate.ToString("dddd dd, MMMM yyyy"); //dddd on viikon päivä, dd on kuukaudenpäivä, MMMM on kuukauden nimi ja yyyy on vuosi
            Console.WriteLine(päivä);

            int x = 6;
            int y = 9;

            Console.WriteLine(Math.Max(x, y)); //Etsii annettujen lukujen suurimman arvon
            Console.WriteLine(Math.Min(x, y)); // Etsii annettujen lukujen pienimmän arvon
            Console.WriteLine(Math.Sqrt(x)); // Laskee annetun arvon potenssiin
            Console.WriteLine(Math.Round(8.9)); // Pyöristää annetun luvun
        }
    }
}
