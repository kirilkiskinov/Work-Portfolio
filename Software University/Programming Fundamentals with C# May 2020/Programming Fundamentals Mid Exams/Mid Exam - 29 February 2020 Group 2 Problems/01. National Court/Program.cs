using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int maxEfficiency = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;

            int hoursCount = 0;
           
            while (peopleCount > 0)
            {                
                hoursCount++;

                if (hoursCount % 4 == 0)
                {
                    continue;
                }

                peopleCount -= maxEfficiency;
            }          

            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
