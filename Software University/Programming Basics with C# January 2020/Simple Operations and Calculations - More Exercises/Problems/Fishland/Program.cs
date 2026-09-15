using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine()); // скумрия
            double spratPrice = double.Parse(Console.ReadLine()); // цаца
            double bonitoWeightInKilos = double.Parse(Console.ReadLine()); // паламуд
            double saurelWeightInKilos = double.Parse(Console.ReadLine()); // сафрид
            int seaShellsWeightInKilos = int.Parse(Console.ReadLine()); // миди

            double bonitoPrice = mackerelPrice + mackerelPrice * 0.60;
            double bonitoSum = bonitoWeightInKilos * bonitoPrice;

            double saurelPrice = spratPrice + spratPrice * 0.80;
            double saurelSum = saurelWeightInKilos * saurelPrice;

            double seaSchellsSum = seaShellsWeightInKilos * 7.50;

            double bill = bonitoSum + saurelSum + seaSchellsSum;

            Console.WriteLine($"{bill:F2}");
        }
    }
}
