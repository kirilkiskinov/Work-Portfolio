using System;

namespace Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int k = 1;

            while (k <= number)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }

            //for (int i = 1; i <= number; i = i * 2 + 1)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}



