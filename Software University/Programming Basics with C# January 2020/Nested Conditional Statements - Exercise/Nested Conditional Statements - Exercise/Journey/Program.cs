using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            double moneySpent = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";

                if (season == "summer")
                {
                    moneySpent = budget * 0.30;
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.70;
                }               
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    moneySpent = budget * 0.40;
                }
                else if (season == "winter")
                {
                    moneySpent = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                
                moneySpent = budget * 0.90;
            }

            string vacationType = "";

            if (season == "summer" && destination != "Europe")
            {
                 vacationType = "Camp";
            }
            else
            {
                 vacationType = "Hotel";
            } 

            Console.WriteLine($"Somewhere in {destination}");

            Console.WriteLine($"{vacationType} - {moneySpent:F2}");

        }
    }
}
