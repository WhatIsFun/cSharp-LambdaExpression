using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_LambaExpressions
{
    internal class Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double GPA { get; set; }

        public Student (string Name, string Id, int Age, string Gender, double GPA)
        {
            this.Name = Name;
            this.Id = Id;
            this.Age = Age;
            this.Gender = Gender;
            this. GPA = GPA;
        }
        public override string ToString()
        {
            return $"Student Name: {Name}\nStudent ID: {Id}\nAge: {Age}\nGender: {Gender}\nGPA: {GPA}";
        }
    }
}
