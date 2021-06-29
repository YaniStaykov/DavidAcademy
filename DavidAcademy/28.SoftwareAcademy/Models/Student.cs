namespace _28.SoftwareAcademy
{
    using System.Collections.Generic;

    public class Student
    {
        public Student(int number, string firstName, string surname, string lastName)
        {
            this.Number = number;
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            Courses = new List<Course>();
        }

        public int Number { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public List<Course> Courses { get; set; }
        
        public void AddStudent(Course course)
        {
            Courses.Add(course);
        }
    }
}
