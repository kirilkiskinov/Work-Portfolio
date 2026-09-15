using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double averageNumber = numbers.Average();

            List<int> biggerThanAverage = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageNumber)
                {
                    biggerThanAverage.Add(numbers[i]);
                }                
            }

            if (biggerThanAverage.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            biggerThanAverage.Sort();
            biggerThanAverage.Reverse();

            if (biggerThanAverage.Count >= 5)
            {                
                List<int> top5 = biggerThanAverage.GetRange(0, 5);

                Console.WriteLine(string.Join(' ', top5));
            }
            else
            {
                Console.WriteLine(string.Join(' ', biggerThanAverage));
            }
        }
    }
}
