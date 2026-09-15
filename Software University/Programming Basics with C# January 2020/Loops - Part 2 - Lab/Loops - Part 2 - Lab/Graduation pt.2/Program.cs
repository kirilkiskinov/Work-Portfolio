using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grade = double.Parse(Console.ReadLine());

            int level = 1;

            double sumOfGrades = 0;

            int exclusionCounter = 0;

            while (level <= 12)
            {
                if (grade >= 4)
                {
                    sumOfGrades += grade;

                    level++;

                    if (level == 13)
                    {
                        break;
                    }

                    grade = double.Parse(Console.ReadLine());

                }
                else
                {                                                        
                    exclusionCounter++;

                    if (exclusionCounter == 1)
                    {
                        break;
                    }

                    grade = double.Parse(Console.ReadLine());
                }
            }

            if (level == 13)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumOfGrades / 12:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {level} grade");
            }
        }
    }
}

