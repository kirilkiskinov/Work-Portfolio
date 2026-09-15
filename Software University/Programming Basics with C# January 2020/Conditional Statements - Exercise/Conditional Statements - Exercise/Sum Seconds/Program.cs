using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime; //124

            int totalMinutes = totalTime / 60;

            int totalSeconds = totalTime % 60;

            Console.WriteLine($"{totalMinutes}:{totalSeconds:D2}"); //D2 means a decimal with two digits. Thus 6 becomes 06.
        }
    }
}
