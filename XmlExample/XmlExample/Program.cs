using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //XmlSerializer xs = new XmlSerializer(typeof(Student));
            //Student student = new Student("Askar", "Akshabayev");
            /*try { 
                xs.Serialize(fs, student);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fs.Close();
            }*/

            BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, student);
            //fs.Close();

            FileStream fs1 = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Student b = bf.Deserialize(fs1) as Student;
            Console.WriteLine(b.name + b.surname);
            Console.ReadKey();
        }
    }
}
