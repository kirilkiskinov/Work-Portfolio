using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            var volume = length * width * height / 1000;

            var loss = percentage * volume / 100;

            var liters = volume - loss;

            Console.WriteLine($"{liters:F3}");
        }
    }
}
