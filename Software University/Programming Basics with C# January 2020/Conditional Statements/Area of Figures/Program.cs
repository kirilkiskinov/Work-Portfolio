using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "square")
            {
                double a = double.Parse(Console.ReadLine());

                double squareArea = a * a;

                Console.WriteLine($"{squareArea:F3}");
            }
            else if (input == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());

                double rectangleArea = x * y;

                Console.WriteLine($"{rectangleArea:F3}");
            }
            else if (input == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                double circleArea = r * r * Math.PI;

                Console.WriteLine($"{circleArea:F3}");
            }
            else if (input == "triangle")
            {
                double b = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double triangleArea = b * h / 2;

                Console.WriteLine($"{triangleArea:F3}");
            }
        }
    }
}
