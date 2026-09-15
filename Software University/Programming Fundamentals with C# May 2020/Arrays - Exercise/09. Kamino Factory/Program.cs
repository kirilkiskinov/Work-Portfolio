//The clone factory in Kamino got another order to clone troops. But this time you are tasked
//to find the best DNA sequence to use in the production. 
//You will receive the DNA length and until you receive the command "Clone them!" you will be
//receiving a DNA sequences of ones and zeroes, split by "!" (one or several).
//You should select the sequence with the longest subsequence of ones.If there are several
//sequences with same length of subsequence of ones, print the one with the leftmost starting
//index, if there are several sequences with same length and starting index, select the 
//sequence with the greater sum of its elements.
//After you receive the last command "Clone them!" you should print the collected information
//in the following format:
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"
//Input / Constraints:
//•	The first line holds the length of the sequences – integer in range[1…100];
//•	On the next lines until you receive "Clone them!" you will be receiving sequences
//(at least one) of ones and zeroes, split by "!" (one or several).
// Output:
//The output should be printed on the console and consists of two lines: 
//"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
//"{DNA sequence, joined by space}"

using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;

            int sequenceCounter = 0;
            int bestSequenceIndex = 0;

            int[] bestSequence = new int[n];

            while (input != "Clone them!")
            {
                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int length = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++) 
// currSeq.Length - 1 because on the last cycle the last index + 1 gives System.IndexOutOfRangeException
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        startIndex = i;
                    }

                    currentSequenceSum += currentSequence[i];
                }

                currentSequenceSum += currentSequence[n - 1]; 
// because we go through the for cycle only to currentSequence.Length - 1 
// and don't sum the last element;

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray(); // we say .ToArray() 
                    //because we want to create an array that points to a different memory in
                    //the Heap(if we don't do this and change an array[element] in the second 
                    //array we also change that element in the first array) 
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
