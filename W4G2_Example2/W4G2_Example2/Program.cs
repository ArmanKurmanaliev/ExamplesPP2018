using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace W4G2_Example2
{
    class Program
    {
        static void F1()
        {
            Student a = new Student("aaa", "bbb", 3.2);
            StreamWriter sw = new StreamWriter("student.txt");
            sw.WriteLine(a.name);
            sw.WriteLine(a.surname);
            sw.WriteLine(a.gpa);
            sw.Close();
        }

        static void F2()
        {
            Student b = new Student();
            StreamReader sr = new StreamReader("student.txt");
            b.name = sr.ReadLine();
            b.surname = sr.ReadLine();
            b.gpa = double.Parse(sr.ReadLine());
            Console.WriteLine(b.surname);
            Console.ReadKey();        
        }

        static void F3()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Student a = new Student("Almas", "Toibayev", 3.2);
            a.subjects.Add(new Subject("PP1"));
            a.subjects.Add(new Subject("Algorithms and Data structures"));
            a.subjects.Add(new Subject("OOP"));

            xs.Serialize(fs, a);
            fs.Close();
        }

        static void F4()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student b = xs.Deserialize(fs) as Student;
            fs.Close();
            Console.WriteLine(b.subjects[1].name);
            Console.ReadKey();
        }

        static void F5()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            Student a = new Student("Almas", "Toibayev", 3.2);
            a.subjects.Add(new Subject("PP1"));
            a.subjects.Add(new Subject("Algorithms and Data structures"));
            a.subjects.Add(new Subject("OOP"));

            bf.Serialize(fs, a);
            fs.Close();
        }

        static void F6()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student b = bf.Deserialize(fs) as Student;
            Console.WriteLine(b.name + " " + b.subjects[1].name);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            F6(); 
        }
    }
}
