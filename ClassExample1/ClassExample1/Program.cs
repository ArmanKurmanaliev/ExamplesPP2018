using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1
{
    class Student
    {
        public String name, surname;
        public double gpa;

        public Student(String name, String surname)
        {
            this.name = name;
            this.surname = surname;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                Student student = new Student("Student_Name" + i, "Student_surname" + i);
                student.gpa = r.Next(2, 4) + r.NextDouble();
                students.Add(student);
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.name + " " + student.surname + " " + student.gpa);
            }
            Console.ReadKey();
        }
    }
}
