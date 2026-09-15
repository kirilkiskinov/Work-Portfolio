using System;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberBorder = int.Parse(Console.ReadLine());
            int secondNumberBorder = int.Parse(Console.ReadLine());
            int thirdNumberBorder = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNumberBorder; i++)
            {
                if (i % 2 == 0)
                {
                    for (int m = 2; m <= secondNumberBorder; m++)
                    {
                        if (m == 2 || m == 3 || m == 5 || m == 7)
                        {
                            for (int n = 2; n <= thirdNumberBorder; n++)
                            {
                                if (n % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {m} {n}");
                                }
                            }
                        }                       
                    }
                }                
            }
        }
    }
}
