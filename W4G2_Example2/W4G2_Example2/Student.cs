using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G2_Example2
{
    [Serializable]
    public class Student
    {
        public string name, surname;
        [NonSerialized]
        public double gpa;
        public List<Subject> subjects = new List<Subject>();

        public Student() { }
        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public Student(string name, string surname, double gpa)
        {
            this.name = name;
            this.surname = surname;
            this.gpa = gpa;
        }
    }
}
