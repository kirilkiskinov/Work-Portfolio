using System;

namespace Cruise_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double finalSum = 0;

            if (cruiseType == "Mediterranean")
            {
                switch (cabinType)
                {
                    case "standard cabin": finalSum = 27.50 * 4 * nights; break;
                    case "cabin with balcony": finalSum = 30.20 * 4 * nights; break;
                    case "apartment": finalSum = 40.50 * 4 * nights; break;
                }
            }
            else if (cruiseType == "Adriatic")
            {
                switch (cabinType)
                {
                    case "standard cabin": finalSum = 22.99 * 4 * nights; break;
                    case "cabin with balcony": finalSum = 25.00 * 4 * nights; break;
                    case "apartment": finalSum = 34.99 * 4 * nights; break;
                }
            }
            else if (cruiseType == "Aegean")
            {
                switch (cabinType)
                {
                    case "standard cabin": finalSum = 23.00 * 4 * nights; break;
                    case "cabin with balcony": finalSum = 26.60 * 4 * nights; break;
                    case "apartment": finalSum = 39.80 * 4 * nights; break;
                }
            }

            if (nights > 7)
            {
                Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {finalSum * 0.75:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {finalSum:F2} lv.");
            }
        }
    }
}
