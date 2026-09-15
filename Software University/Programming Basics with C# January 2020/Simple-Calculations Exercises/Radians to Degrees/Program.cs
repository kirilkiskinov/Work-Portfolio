using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());

            double degrees = Math.Round(rad * 180 / Math.PI);

            Console.WriteLine(degrees);

        }
    }
}
