using System;

namespace House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            // x , y , h = [2...100]; 

            double x = double.Parse(Console.ReadLine());  // the height of the house;
            double y = double.Parse(Console.ReadLine());  // the length of the side wall;
            double h = double.Parse(Console.ReadLine());  // the height of the triangular wall of the roof;

            // For the area of the walls of the house:

            double sideWallArea = x * y;

            double windowArea = 1.5 * 1.5;

            double sideWallsAreaWithoutWinodws = 2 * sideWallArea - 2 * windowArea;

            double backWall = x * x;

            double frontDoor = 1.2 * 2;

            double frontAndBackWallArea = 2 * backWall - frontDoor;

            double totalAreaOfWalls = sideWallsAreaWithoutWinodws + frontAndBackWallArea;

            double greenPaintNeeded = totalAreaOfWalls / 3.4;

            Console.WriteLine($"{greenPaintNeeded:F2}");

            // For the area of the roof of the house:

            double areaOfBothRoofRectangles = 2 * (x * y);

            double areaOfBothRoofTriangles = 2 * (x * h / 2);

            double totalAreaofRoof = areaOfBothRoofRectangles + areaOfBothRoofTriangles;

            double redPaintNeeded = totalAreaofRoof / 4.3;

            Console.WriteLine($"{redPaintNeeded:F2}");

        }
    }
}
