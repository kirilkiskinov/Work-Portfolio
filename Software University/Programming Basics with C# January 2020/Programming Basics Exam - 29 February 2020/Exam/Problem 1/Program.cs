using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double litersNeeded = double.Parse(Console.ReadLine());

            double totalDistance = 384400 * 2;

            double time = Math.Ceiling(totalDistance / averageSpeed);

            double totalTime = Math.Ceiling(time + 3);

            double gas = (litersNeeded * totalDistance) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(gas);

        }
    }
}
