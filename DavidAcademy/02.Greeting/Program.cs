namespace Greeting
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Student name = ");
            string studentName = Console.ReadLine();
            Console.Write("Course name = ");
            string courseName = Console.ReadLine();

            string message = $"Hello {studentName} and welcome to {courseName}!";
            Console.WriteLine(message);
        }
    }
}
