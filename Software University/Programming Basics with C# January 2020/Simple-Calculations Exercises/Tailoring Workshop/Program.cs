using System;

namespace Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tablesCount = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = tablesCount * (length + 2 * 0.30) * (width + 2 * 0.30);

            double coach = tablesCount * (length / 2) * (length / 2);

            double usd = area * 7 + coach * 9;
            double bgn = usd * 1.85;

            Console.WriteLine($"{usd:F2} USD");
            Console.WriteLine($"{bgn:F2} BGN");




        }
    }
}
