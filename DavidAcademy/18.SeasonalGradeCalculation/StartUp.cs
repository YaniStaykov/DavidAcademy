namespace _18.SeasonalGradeCalculation
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {        
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int counter = 1;
            double totalSum = 0;

            Console.Write($"Please enter grade for student {counter}: ");

            while (true)
            {                
                Student student = new Student();
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                while (true)
                {
                    if (input.ToLower() == "done")
                    {
                        break;
                    }

                    double grade = double.Parse(input);

                    if (grade < 2 || grade > 6)
                    {
                        Console.WriteLine("Please enter a valid grade!");
                    }
                    else if (grade > 2 || grade < 6)
                    {
                        student.Grades.Add(grade);
                        Console.Write("Add another grade or type Done to end: ");
                    }

                    input = Console.ReadLine();
                }

                students.Add(student);

                counter++;
                Console.Write($"Enter grade for student {counter} or type Done to calculate: ");
            }

            counter = 1;

            foreach (var student in students)
            {
                double totalGradeSum = student.Grades.Sum(x => x);                
                double averageGrade = totalGradeSum / student.Grades.Count;
                totalSum += averageGrade;

                Console.WriteLine($"Student {counter} average grade is = {averageGrade:f2}");
                counter++;
            }

            double averageClassGrade = totalSum / students.Count();

            Console.WriteLine($"The average grade of the whole class is = {averageClassGrade:f2}");
        }
    }
}
