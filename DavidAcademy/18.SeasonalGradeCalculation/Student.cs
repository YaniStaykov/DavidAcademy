namespace _18.SeasonalGradeCalculation
{   
    using System.Collections.Generic;    
    public class Student
    {
        public List<double> Grades { get; set; }
        public Student()
        {
            Grades = new List<double>();
        }
    }
}
