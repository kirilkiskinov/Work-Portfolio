//A theatre is doing a ticket sale, but they need a program to calculate the price of a single ticket.
//If the given age does not fit one of the categories, you should print "Error!".
//You can see the prices in the table below:

using System;

namespace Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int price = 0;

            if (day == "Weekday")
            {
                if ((age >= 0 && age <= 18) || (age >= 65 && age <= 122))
                {
                    price = 12;
                }

                if (age > 18 && age <= 64)
                {
                    price = 18;
                }

            }

            if (day == "Weekend")
            {
                if ((age >= 0 && age <= 18) || (age >= 65 && age <= 122))
                {
                    price = 15;
                }

                if (age > 18 && age <= 64)
                {
                    price = 20;
                }
            }

            if (day == "Holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    price = 5;
                }
                else if (age >= 65 && age <= 122)
                {
                    price = 10;
                }
                else if (age > 18 && age <= 64)
                {
                    price = 12;
                }
            }

            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }
    }
}
