using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlExample
{
    [Serializable]
    public class Student
    {
        public string name, surname;
        [NonSerialized]
        public double gpa;
        public Point point;
        public Student() { }
        public Student(string _name, string _surname)
        {
            name = _name;
            surname = _surname;
            gpa = 2.3;
            point = new Point(5, 6);
        }
    }
}
