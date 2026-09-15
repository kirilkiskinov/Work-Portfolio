using System;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number > number2)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number2);
            }
        }
    }
}
