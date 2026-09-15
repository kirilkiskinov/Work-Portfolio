using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedThreshold = int.Parse(Console.ReadLine());

            int failsCounter = 0;
            int gradesSum = 0;
            int solvedProblemsCount = 0;
            string lastProblemName = "";


            while (failsCounter < failedThreshold)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    failsCounter++;
                }

                gradesSum += grade;

                solvedProblemsCount++;

                lastProblemName = problemName;
            }

            if (failsCounter == failedThreshold)
            {
                Console.WriteLine($"You need a break, {failsCounter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum * 1.0 / solvedProblemsCount:F2}");
                Console.WriteLine($"Number of problems: {solvedProblemsCount}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }           
        }
    }
}
