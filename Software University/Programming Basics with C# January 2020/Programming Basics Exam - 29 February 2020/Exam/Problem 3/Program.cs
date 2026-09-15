using System;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursPassed = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            double pricePerPerson = 0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (partOfDay == "day")
                {
                    pricePerPerson = 10.50;
                }
                else if (partOfDay == "night")
                {
                    pricePerPerson = 8.4;
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (partOfDay == "day")
                {
                    pricePerPerson = 12.60;
                }
                else if (partOfDay == "night")
                {
                    pricePerPerson = 10.20;
                }
            }

            if (peopleCount >= 4)
            {
                pricePerPerson = pricePerPerson - (pricePerPerson * 0.10);
            }

            if (hoursPassed >= 5)
            {
                pricePerPerson = pricePerPerson - (pricePerPerson * 0.50);
            }

            double totalCost = (pricePerPerson * hoursPassed) * peopleCount;

            Console.WriteLine($"Price per person for one hour: {pricePerPerson:F2}");
            Console.WriteLine($"Total cost of the visit: {totalCost:F2}");

        }
    }
}
