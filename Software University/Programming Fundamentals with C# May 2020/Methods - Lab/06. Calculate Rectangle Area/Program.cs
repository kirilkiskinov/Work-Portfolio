//Create a method that calculates and returns the area of a rectangle by given width and height.

using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double rectangleArea = CalculateRectangleArea(width, height);

            Console.WriteLine(rectangleArea); 
        }

        static double CalculateRectangleArea(double a, double b)
        {
            double area = a * b;

            return area;
        }
    }
}
