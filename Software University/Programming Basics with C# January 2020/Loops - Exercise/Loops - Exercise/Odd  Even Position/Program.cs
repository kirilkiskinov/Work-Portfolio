using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0.0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;


            for (int i = 1; i <= n; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += currentNum;

                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }

                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                }
                else
                {
                    oddSum += currentNum;

                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }

                    if (currentNum < oddMin)
                    {
                        oddMin = currentNum;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:F2},");

            if (oddMin != int.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
            }

            if (oddMax != int.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else
            {
                Console.WriteLine("OddMax=No,");
            }

            Console.WriteLine($"EvenSum={evenSum:F2},");

            if (evenMin != int.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
            }

            if (evenMax != int.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else
            {
                Console.WriteLine("EvenMax=No");
            }                                   
        }
    }
}
