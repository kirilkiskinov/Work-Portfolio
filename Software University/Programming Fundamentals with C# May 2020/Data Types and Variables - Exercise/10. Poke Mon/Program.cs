//A Poke Mon is a special type of pokemon which likes to Poke others. But at the end of the 
//day, the Poke Mon wants to keeps statistics, about how many pokes it has managed to make.
//The Poke Mon pokes his target, and then proceeds to poke another target.
//The distance between his targets reduces his poke power.
//You will be given the poke power the Poke Mon has, N – an integer.
//Then you will be given the distance between the poke targets, M – an integer.
//Then you will be given the exhaustionFactor Y – an integer.
//Your task is to start subtracting M from N until N becomes less than M, i.e.the Poke Mon 
//does not have enough power to reach the next target.
//Every time you subtract M from N that means you’ve reached a target and poked it successfully.
//COUNT how many targets you’ve poked – you’ll need that count.
//The Poke Mon becomes gradually more exhausted.IF N becomes equal to EXACTLY 50 % of its 
//original value, you must divide N by Y, if it is POSSIBLE.This DIVISION is between integers.
//If a division is not possible, you should NOT do it.Instead, you should continue subtracting.
//After dividing, you should continue subtracting from N, until it becomes less than M.
//When N becomes less than M, you must take what has remained of N and the count of targets 
//you’ve poked, and print them as output.
//Output:
//•	The output consists of 2 lines.
//•	On the first line print what has remained of N, after subtracting from it.
//•	On the second line print the count of targets, you’ve managed to poke.
//Constrains:
//•	The integer N will be in the range [1, 2.000.000.000].
//•	The integer M will be in the range [1, 1.000.000].
//•	The integer Y will be in the range [0, 9].
//•	Allowed time / memory: 16 MB / 100ms.

using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargetsDistance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());

            int pokedTargets = 0;
            int originalValueN = pokePower;

            while (pokePower >= pokeTargetsDistance)
            {
                pokePower -= pokeTargetsDistance;

                if (pokePower == originalValueN / 2)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }                    
                }

                pokedTargets++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
