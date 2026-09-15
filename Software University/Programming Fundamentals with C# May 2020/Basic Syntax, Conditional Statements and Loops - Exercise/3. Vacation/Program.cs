//You are given a group of people, type of the group, on which day of the week they are going to stay. 
//Based on that information calculate how much they have to pay and print that price on the console. 
//Use the table below. In each cell is the price for a single person. The output should look like that: 
//“Total price: {price}”. The price should be formatted to the second decimal point.
//There are also discounts based on some conditions:
//•	Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15%
//•	Business – if the group is bigger than or equal to  100 people 10 of them can stay for free.
//•	Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5%
//You should reduce the prices in that EXACT order

using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double singlePrice = 0;

            if (dayOfTheWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    singlePrice = 8.45;
                }
                else if (groupType == "Business")
                {
                    singlePrice = 10.90;
                }
                else if (groupType == "Regular")
                {
                    singlePrice = 15;
                }
            }
            else if (dayOfTheWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    singlePrice = 9.80;
                }
                else if (groupType == "Business")
                {
                    singlePrice = 15.60;
                }
                else if (groupType == "Regular")
                {
                    singlePrice = 20;
                }
            }
            else if (dayOfTheWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    singlePrice = 10.46;
                }
                else if (groupType == "Business")
                {
                    singlePrice = 16;
                }
                else if (groupType == "Regular")
                {
                    singlePrice = 22.50;
                }
            }

            double totalPrice = singlePrice * groupCount;

            if (groupCount >= 30 && groupType == "Students")
            {
                totalPrice *= 0.85; 
            }
            else if (groupCount >= 100 && groupType == "Business")
            {
                totalPrice -= singlePrice * 10; 
            }
            else if ((groupCount >= 10 && groupCount <= 20) && groupType == "Regular")
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
