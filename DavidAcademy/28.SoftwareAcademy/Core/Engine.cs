namespace _28.SoftwareAcademy.Core
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        public void Run()
        {
            Console.WriteLine("Please create an Academy.");
            Console.Write("Academy name:");
            string input = Console.ReadLine();

            Academy academy = new Academy(input);

            Console.WriteLine("Choose to add: Course or Student: ");
            input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                if (input.ToLower() == "course")
                {
                    try
                    {
                        Console.WriteLine("Input Course name and E-mail : ");
                        input = Console.ReadLine();
                        var inputParsed = input.Split();
                        var name = inputParsed[0];
                        var email = inputParsed[1];
                        Course course = new Course(name, email);
                        academy.AddCourse(course);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Wrong input.");
                    }
                }
                else if (input.ToLower() == "student")
                {
                    try
                    {
                        Console.WriteLine("Input Student number, First Name, Surname and Last Name : ");
                        input = Console.ReadLine();
                        var inputParsed = input.Split();
                        var number = int.Parse(inputParsed[0]);
                        var firstName = inputParsed[1];
                        var surname = inputParsed[2];
                        var lastName = inputParsed[3];
                        Student student = new Student(number, firstName, surname, lastName);
                        academy.AddStudent(student);                        
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("Wrong input.");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong input.");
                    }
                }

                Console.WriteLine("Choose to add: Academy, Course or Student or type End: ");
                input = Console.ReadLine();
            }
        }
        //TODO: Add studets to courses
    }
}
