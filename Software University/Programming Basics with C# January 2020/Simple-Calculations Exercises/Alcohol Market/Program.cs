using System;

namespace Alcohol_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceOfWhiskeyInLeva = double.Parse(Console.ReadLine());
            double beerInLitters = double.Parse(Console.ReadLine());
            double wineInLitters = double.Parse(Console.ReadLine());
            double rakiaInLitters = double.Parse(Console.ReadLine());
            double whiskeyInLitters = double.Parse(Console.ReadLine());

            double rakiaPrice = priceOfWhiskeyInLeva / 2;

            double winePrice = rakiaPrice - (0.4 * rakiaPrice);

            double beerPrice = rakiaPrice - (0.8 * rakiaPrice);

            double rakiaSum = rakiaInLitters * rakiaPrice;

            double wineSum = wineInLitters * winePrice;

            double beerSum = beerInLitters * beerPrice;

            double whiskeySum = whiskeyInLitters * priceOfWhiskeyInLeva;

            double fullPrice = rakiaSum + wineSum + beerSum + whiskeySum;

            Console.WriteLine($"{fullPrice:F2}");

        }
    }
}
