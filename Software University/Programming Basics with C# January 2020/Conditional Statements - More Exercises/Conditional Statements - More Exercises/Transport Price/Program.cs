using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());    // from 1 to 5000
            string partOfDay = Console.ReadLine();     // Write day or night

            if (distance < 20 && partOfDay == "day")
            {
                double taxiFare = 0.70 + distance * 0.79;
                Console.WriteLine($"{taxiFare:F2}");
            }
            else if (distance < 20 && partOfDay == "night")
            {
                double taxiFare = 0.70 + distance * 0.90;
                Console.WriteLine($"{taxiFare:F2}");
            }
            else if (distance >= 20 && distance < 100)
            {
                double busFare = distance * 0.09;
                Console.WriteLine($"{busFare:F2}");
            }
            else
            {
                double trainFare = distance * 0.06;
                Console.WriteLine($"{trainFare:F2}");
            }
        }
    }
}
