using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            double gradeSum = 0;
            double totalGrade = 0;
            double finalAssessment = 0;
            int gradesCounter = 0;
            
            while (input != "Finish")
            {
                for (int i = 1; i <= n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    gradeSum += grade;

                    gradesCounter++;
                }

                finalAssessment += gradeSum;

                totalGrade = gradeSum / n;

                Console.WriteLine($"{input} - {totalGrade:F2}.");                             

                gradeSum = 0;
                totalGrade = 0;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Student's final assessment is {finalAssessment / gradesCounter:F2}.");

        }
    }
}
