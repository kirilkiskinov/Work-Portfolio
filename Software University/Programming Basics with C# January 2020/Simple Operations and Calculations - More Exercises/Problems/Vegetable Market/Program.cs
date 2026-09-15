using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPricePerKilo = double.Parse(Console.ReadLine());
            double fruitsPricePerKilo = double.Parse(Console.ReadLine());
            int vegetablesWeight = int.Parse(Console.ReadLine());
            int fruitsWeight = int.Parse(Console.ReadLine());

            double vegetablesSum = vegetablesPricePerKilo * vegetablesWeight;
            double fruitsSum = fruitsPricePerKilo * fruitsWeight;

            double fruitsAndVegetablesSumInEuro = (fruitsSum + vegetablesSum) / 1.94;

            Console.WriteLine($"{fruitsAndVegetablesSumInEuro:F2}");
        }
    }
}
