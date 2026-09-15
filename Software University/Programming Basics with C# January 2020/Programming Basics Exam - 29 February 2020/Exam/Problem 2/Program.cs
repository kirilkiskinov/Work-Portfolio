using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());          
            int actorsCount = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decorSum = movieBudget * 0.10;

            double clothesTotalSum = actorsCount * clothesPrice;

            if (actorsCount > 150)
            {
                clothesTotalSum *= 0.90;
            }

            double totalMovieSum = decorSum + clothesTotalSum;

            if (totalMovieSum > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMovieSum - movieBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - totalMovieSum:F2} leva left.");
            }
        }
    }
}
