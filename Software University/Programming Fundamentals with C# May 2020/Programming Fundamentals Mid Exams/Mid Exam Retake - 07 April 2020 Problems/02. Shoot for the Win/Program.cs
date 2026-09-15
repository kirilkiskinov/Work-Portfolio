using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string input = Console.ReadLine();

            int shotTargets = 0;

            while (input != "End")
            {
                int indexToShoot = int.Parse(input);

                if (indexToShoot >= 0 && indexToShoot < targets.Length)
                {
                    int currentElement = targets[indexToShoot];

                    for (int i = 0; i < targets.Length; i++)
                    {                      
                        if (targets[i] <= currentElement) 
                        {
                            if (targets[i] == -1)
                            {                                
                                continue;
                            }
                            targets[i] += currentElement;
                        }
                        else if(targets[i] > currentElement) 
                        {
                            if (targets[i] == -1)
                            {                               
                                continue;
                            }
                            targets[i] -= currentElement;
                        }             
                    }

                    targets[indexToShoot] = -1;

                    shotTargets++;
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shotTargets} -> {string.Join(' ', targets)}");
        }
    }
}
