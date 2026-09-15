using System;

namespace Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numbersByTwo = 0;
            int numbersByThree = 0;
            int numbersByFour = 0;

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    numbersByTwo++;

                }
                if (currentNumber % 3 == 0)
                {
                    numbersByThree++;
                }
                if (currentNumber % 4 == 0)
                {
                    numbersByFour++;
                }

            }

            double p1 = numbersByTwo * 1.0 / n * 100;
            double p2 = numbersByThree * 1.0 / n * 100;
            double p3 = numbersByFour * 1.0 / n * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            
        }
    }
}
