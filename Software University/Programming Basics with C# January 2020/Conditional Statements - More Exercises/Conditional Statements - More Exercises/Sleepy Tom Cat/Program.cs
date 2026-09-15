using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workingDays = 365 - daysOff;

            int totalTimeToPlay = workingDays * 63 + daysOff * 127;

            int normDifference = Math.Abs(30000 - totalTimeToPlay);

            int hours = normDifference / 60;

            int minutes = normDifference % 60;

            if (totalTimeToPlay < 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
