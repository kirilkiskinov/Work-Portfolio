using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());  // food left in kilos
            double dogFood = double.Parse(Console.ReadLine());  // food for the dog for 1 day in kilos
            double catFood = double.Parse(Console.ReadLine());  // food for the cat for 1 day in kilos
            double turtleFood = double.Parse(Console.ReadLine());  // food for the turtle for 1 day in grams

            double dogFoodEaten = dogFood * days;
            double catFoodEaten = catFood * days;
            double turtleFoodEaten = (turtleFood * days) * 0.001;  // 1 gram = 0.001 kilograms

            double totalFoodEaten = dogFoodEaten + catFoodEaten + turtleFoodEaten;

            if (totalFoodEaten <= food)
            {
                double foodLeft = food - totalFoodEaten;
                Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
            }
            else
            {
                double foodLeft = totalFoodEaten - food;
                Console.WriteLine($"{Math.Ceiling(foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
