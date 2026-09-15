using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            double socialScholarship = Math.Floor(minimumSalary * 0.35);
            double highGradeScholarship = Math.Floor(averageGrade * 25);

            if (income <= minimumSalary && averageGrade > 4.50 && averageGrade >= 5.50 && highGradeScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {highGradeScholarship} BGN");
            }
            else if (income <= minimumSalary && averageGrade > 4.50 && averageGrade >= 5.50 && highGradeScholarship < socialScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (income <= minimumSalary && averageGrade > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else if (averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {highGradeScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }        
    }
}
