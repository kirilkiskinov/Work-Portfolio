using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double travelPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double earnedMoneyBeforeDisscount = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            int totalToysCount = puzzles + dolls + bears + minions + trucks;

            double moneyAfterFirstDiscount = earnedMoneyBeforeDisscount;

            if (totalToysCount >= 50)
            {
                moneyAfterFirstDiscount = earnedMoneyBeforeDisscount * 0.75;
            }

            double moneyAfterRent = moneyAfterFirstDiscount * 0.9;

            if (moneyAfterRent >= travelPrice)
            {
                Console.WriteLine($"Yes! {moneyAfterRent - travelPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {travelPrice - moneyAfterRent:F2} lv needed.");
            }
        }
    }
}
