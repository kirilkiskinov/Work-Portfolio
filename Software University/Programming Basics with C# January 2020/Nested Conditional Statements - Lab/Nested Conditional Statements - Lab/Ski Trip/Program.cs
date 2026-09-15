using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;

            double priceForNights = 0;

            if (roomType == "room for one person")
            {
                priceForNights = nights * 18;
            }
            else if (roomType == "apartment")
            {
                if (nights < 10)
                {
                    priceForNights = (nights * 25) * 0.70;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    priceForNights = (nights * 25) * 0.65;
                }
                else if (nights > 15)
                {
                    priceForNights = (nights * 25) * 0.50;
                }
            }
            else if (roomType == "president apartment")
            {
                if (nights < 10)
                {
                    priceForNights = (nights * 35) * 0.90;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    priceForNights = (nights * 35) * 0.85;
                }
                else if (nights > 15)
                {
                    priceForNights = (nights * 35) * 0.80;
                }
            }

            if (feedback == "positive")
            {
                priceForNights *= 1.25;
            }
            else if (feedback == "negative")
            {
                priceForNights *= 0.90;
            }

            Console.WriteLine($"{priceForNights:F2}");
        }
    }
}
