using System;

namespace PäiväMäärä
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now; //DateTime.Now tarkoittaa tätä päivää

            string päivä = "tänään on " + aDate.ToString("dddd dd, MMMM yyyy"); //dddd on viikon päivä, dd on kuukaudenpäivä, MMMM on kuukauden nimi ja yyyy on vuosi
            Console.WriteLine(päivä);
        }
    }
}
