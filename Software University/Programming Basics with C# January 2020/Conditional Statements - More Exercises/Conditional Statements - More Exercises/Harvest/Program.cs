using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapesPerArea = double.Parse(Console.ReadLine());
            int wineNeededInLitters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = vineyardArea * grapesPerArea;

            double totalWine = (totalGrapes / 2.5) * 0.4;

            double wineLeft = totalWine - wineNeededInLitters;

            double winePerPerson = wineLeft / workers;

            double wineShortage = wineNeededInLitters - totalWine;

            if (totalWine >= wineNeededInLitters)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(winePerPerson)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineShortage)} liters wine needed.");
            }
        }
    }
}
