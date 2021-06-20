namespace _28.SoftwareAcademy
{
    using System.Collections.Generic;

    public class Course
    {
        public Course(string name, string email)
        {
            this.Name = name;
            this.Email = email;
            Students = new List<Student>();
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public List<Student> Students { get; set; }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
    