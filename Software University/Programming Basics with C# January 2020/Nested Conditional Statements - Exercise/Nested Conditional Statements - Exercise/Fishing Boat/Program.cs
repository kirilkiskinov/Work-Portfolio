using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatRent = 0;

            if (season == "Spring")
            {
                boatRent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                boatRent = 4200;
            }                                    
            else if (season == "Winter")
            {
                boatRent = 2600;
            }            

            if (fishermen <= 6)
            {
                boatRent *= 0.90;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                boatRent *= 0.85;
            }
            else if (fishermen >= 12)
            {
                boatRent *= 0.75;
            }            

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                boatRent *= 0.95;
            }

            if (budget < boatRent)
            {
                double moneyNeeded = boatRent - budget;

                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
            else if (budget >= boatRent)
            {
                double moneyLeft = budget - boatRent;

                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }            
        }
    }
}
