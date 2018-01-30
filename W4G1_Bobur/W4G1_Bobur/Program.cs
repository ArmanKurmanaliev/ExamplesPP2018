using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace W4G1_Bobur
{
    class Program
    {
        static void F1()
        {
            Student a = new Student("aaa", "bbb");
            a.gpa = 3.2;
            StreamWriter sw = new StreamWriter(@"student.txt");
            sw.WriteLine(a.name);
            sw.WriteLine(a.surname);
            sw.WriteLine(a.gpa);
            sw.Close();
        }

        static void F2()
        {
            StreamReader sr = new StreamReader(@"student.txt");
            Student b = new Student();
            string name = sr.ReadLine();
            string surname = sr.ReadLine();
            double gpa = double.Parse(sr.ReadLine());
            b.name = name;
            b.surname = surname;
            b.gpa = gpa;
            sr.Close();
            Console.WriteLine(b.name + " " + b.surname);
            Console.ReadKey();
        }

        static void F3()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            
            Student a = new Student("aaa", "bbb");
            Subject s1 = new Subject("PP1");
            Subject s2 = new Subject("Algorithms and Data Structres");
            Subject s3 = new Subject("OOP");
            a.subjects.Add(s1);
            a.subjects.Add(s2);
            a.subjects.Add(s3);


            try
            {
                xs.Serialize(fs, a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fs.Close();
            }
        }

        static void F4()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            Student b = xs.Deserialize(fs) as Student;
            Console.WriteLine(b.subjects[1].name);
            Console.ReadKey();
        }

        static void F5()
        {
            BinaryFormatter bf = new BinaryFormatter();
            Student a = new Student("aaa", "bbb");
            Subject s1 = new Subject("PP1");
            Subject s2 = new Subject("Algorithms and Data Structres");
            Subject s3 = new Subject("OOP");
            a.subjects.Add(s1);
            a.subjects.Add(s2);
            a.subjects.Add(s3);

            FileStream fs = new FileStream(@"data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bf.Serialize(fs, a);
            fs.Close();
        }

        static void F6()
        {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Student b = bf.Deserialize(fs) as Student;
            Console.WriteLine(b.subjects[2].name);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            F6();
        }
    }
}
