using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int Volume = int.Parse(Console.ReadLine()); // Volume of the pool in liters
            int P1 = int.Parse(Console.ReadLine()); // flow rate of the first pipe per hour
            int P2 = int.Parse(Console.ReadLine()); // flow rate of the second pipe per hour
            double H = double.Parse(Console.ReadLine()); // hours in which the worker is missing
            
            double firstPipeWork = H * P1;
            
            double secondPipeWork = H * P2;
            
            double totalPipesWork = firstPipeWork + secondPipeWork;
            
            double volumePercent = totalPipesWork * 100 / Volume;
            
            double firstPipePercent = firstPipeWork * 100 / totalPipesWork;
            
            double secondPipePercent = secondPipeWork * 100 / totalPipesWork;
            
            if (totalPipesWork <= Volume)
            {
                Console.WriteLine($"The pool is {volumePercent:F2}% full. Pipe 1: {firstPipePercent:F2}%. Pipe 2: {secondPipePercent:F2}%.");
            }
            else
            {
              Console.WriteLine($"For {H:F2} hours the pool overflows with {totalPipesWork - Volume:F2} liters.");
            }
        }
    }
}
