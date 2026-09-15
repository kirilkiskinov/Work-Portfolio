using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // w - length in meters;  h - width in meters;  3 ≤ h ≤ w ≤ 100;

            double w = double.Parse(Console.ReadLine()) * 100; // times 100 to turn metres into centimeters
            double h = (double.Parse(Console.ReadLine()) - 1) * 100; // -1 because 1 metre goes for the corridor

            int rows = (int) h / 70;
            
            int columns = (int) w / 120;

            int seats = rows * columns - 3;

            Console.WriteLine(seats);

        }
    }
}
