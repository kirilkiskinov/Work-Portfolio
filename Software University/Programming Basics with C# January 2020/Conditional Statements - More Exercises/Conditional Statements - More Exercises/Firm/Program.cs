using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());  // from 0 to 200 000
            int days = int.Parse(Console.ReadLine());  // from 0 to 20 000
            int workers = int.Parse(Console.ReadLine());  // from 0 to 200

            double daysForWork =  days - (days * 0.1);  

            double hoursForWork = daysForWork * 8;

            double workersWorkingOvertime = workers * (2 * days);

            double totalHours = Math.Floor(hoursForWork + workersWorkingOvertime);

            if (totalHours >= hours)
            {
                double hoursLeft = totalHours - hours;
                Console.WriteLine($"Yes!{hoursLeft} hours left.");
            }
            else
            {
                double hoursNeeded = hours - totalHours;
                Console.WriteLine($"Not enough time!{hoursNeeded} hours needed.");
            }
        }
    }
}
