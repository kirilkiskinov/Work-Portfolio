using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int goal = 10000;

            int stepsSum = 0;            

            while (input != "Going home")
            {
               int stepsInput = int.Parse(input);

                stepsSum += stepsInput;

                if (stepsSum >= goal)
                {                    
                    break;
                }

                input = Console.ReadLine();
            }

            if (stepsSum >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");               
            }
            else if (input == "Going home")
            {
                input = Console.ReadLine();

                int stepsInput = int.Parse(input);

                int totalSteps = stepsSum + stepsInput;

                if (totalSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
                else
                {
                    Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
                }
            }                     
        }
    }
}
