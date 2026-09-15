using System;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int kidsCount = 0;
            int adultsCount = 0;
            int moneyForToys = 0;
            int moneyForSweaters = 0;

            while (input != "Christmas")
            {
                int inputAsNumber = int.Parse(input);

                if (inputAsNumber <= 16)
                {
                    kidsCount++;
                    moneyForToys += 5;
                }
                else
                {
                    adultsCount++;
                    moneyForSweaters += 15;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Number of adults: {adultsCount}");
            Console.WriteLine($"Number of kids: {kidsCount}");
            Console.WriteLine($"Money for toys: {moneyForToys}");
            Console.WriteLine($"Money for sweaters: {moneyForSweaters}");

        }
    }
}
