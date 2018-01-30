using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G1_Bobur
{
    [Serializable]
    public class Student
    {
        public string name, surname;
        public double gpa;
        public List<Subject> subjects;
         

        public Student() { }

        public Student(string _name, double _gpa)
        {
            name = _name;
            gpa = _gpa;
            subjects = new List<Subject>();
        }

        public Student(string _name, string _surname) {
            name = _name;
            surname = _surname;
            gpa = 2.3;
            subjects = new List<Subject>();
        }
    }
}
