using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolia = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());  // зюмбюл
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double flowersSum = 3.25 * magnolia + 4 * hyacinth + 3.50 * roses + cactus * 8;

            double profit = flowersSum * 0.95;  // 5% goes for taxes

            if (profit < presentPrice)
            {
                double moneyNeeded = presentPrice - profit;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(moneyNeeded)} leva.");
            }
            else
            {
                double moneyLeft = profit - presentPrice;
                Console.WriteLine($"She is left with {Math.Floor(moneyLeft)} leva.");
            }
        }
    }
}
