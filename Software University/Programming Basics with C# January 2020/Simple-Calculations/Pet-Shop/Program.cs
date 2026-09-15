using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double sum = dogs * 2.5 + otherAnimals * 4;

            Console.WriteLine($"{sum:F2} lv.");

            //Console.WriteLine("{0:F2} lv.", sum);

        }
    }
}
