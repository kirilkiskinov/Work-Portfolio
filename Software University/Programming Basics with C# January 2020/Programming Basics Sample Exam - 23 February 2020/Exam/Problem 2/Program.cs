using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double astronoughtHeight = double.Parse(Console.ReadLine());

            double spaceshipVolume = width * length * height;

            double roomVolume = (astronoughtHeight + 0.40) * 2 * 2;

            double astronoughtCount = Math.Floor(spaceshipVolume / roomVolume);

            if (astronoughtCount >= 3 && astronoughtCount <= 10)
            {
                Console.WriteLine($"The spacecraft holds {astronoughtCount} astronauts.");
            }
            else if (astronoughtCount < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
