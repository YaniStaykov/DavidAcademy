namespace _10.GradePointAverage
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>();
            double gradePointTotal = 0, gradePointAverage = 0;

            Console.Write("Enter grade = ");
            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                double inputParsed = double.Parse(input);
                
                if (inputParsed < 2 || inputParsed > 6)
                {
                    Console.WriteLine("Please enter a valid grade.");
                    continue;
                }
                else
                {
                    grades.Add(inputParsed);
                }

                Console.Write("Enter grade or type DONE to end: ");
            }

            foreach (var grade in grades)
            {
                gradePointTotal += grade;
            }

            gradePointAverage = gradePointTotal / grades.Count;

            Console.WriteLine($"The Grade Point Average of the class is: {gradePointAverage}");
        }
    }
}
