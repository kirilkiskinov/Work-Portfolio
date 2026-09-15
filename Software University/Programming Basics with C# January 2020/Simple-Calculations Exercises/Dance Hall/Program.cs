using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hallArea = (L * 100) * (W * 100);

            double dresser = (A * 100) * (A * 100);

            double bench = hallArea / 10;

            double freeSpace = hallArea - dresser - bench;

            double dancersCount = freeSpace / (40 + 7000);

            double dancersCountDown = Math.Floor(dancersCount);

            Console.WriteLine(dancersCountDown);
        }
    }
}
