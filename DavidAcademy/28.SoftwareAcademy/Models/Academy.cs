namespace _28.SoftwareAcademy
{
    using System.Collections.Generic;

    public class Academy
    {
        public Academy(string name)
        {
            this.Name = name;
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        public string Name { get; set; }

        public List<Student> Students { get; set; }

        public List<Course> Courses { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }


    }
}
