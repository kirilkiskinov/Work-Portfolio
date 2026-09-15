using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int apartmentVolume = width * length * height;

            int volume = 0;

            while (command != "Done")
            {
                int commandAsNumber = int.Parse(command);

                volume += commandAsNumber;

                if (volume >= apartmentVolume)
                {
                    break;
                }

                command = Console.ReadLine();

            }
            if (volume < apartmentVolume)
            {
                Console.WriteLine($"{apartmentVolume - volume} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {volume - apartmentVolume} Cubic meters more.");
            }
        }
    }
}
