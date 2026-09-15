//Enter a day number [1…7] and print the name (in English) or "Invalid day!"

using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());

            string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine($"{weekDays[dayNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
