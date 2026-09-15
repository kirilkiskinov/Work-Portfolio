using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = nights * 50;
                apartmentPrice = nights * 65;

                if (nights > 14)
                {
                    studioPrice *= 0.70;
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;

                if (nights > 14)
                {
                    studioPrice *= 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = nights * 76;
                apartmentPrice = nights * 77;
            }

            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");

        }
    }
}
