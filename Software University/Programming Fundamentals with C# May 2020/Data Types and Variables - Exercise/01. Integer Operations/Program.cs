//Read four integer numbers. Add first to the second, divide (integer) the sum by the 
//third number and multiply the result by the fourth number. Print the result.
//Constraints: 
//•	First number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]
//•	Second number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]
//•	Third number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]
//•	Fourth number will be in the range[-2, 147, 483, 648… 2, 147, 483, 647]

using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());          

            int result = ((first + second) / third) * fourth;

            Console.WriteLine(result);
        }
    }
}
