using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G2_Example1
{
    class Program
    {
        public static void F1()
        {
            Console.WriteLine("hell world");
        }

        static void Main(string[] args)
        {
            F1();
            Class1 a = new Class1();
            Class1 b = new Class1();
            Class2 c = new Class2();
            Class2 d = new Class2();

            a.Add();
            b.Add();
            a.Add();
            b.Add();

            c.Add();
            d.Add();
            c.Add();
            d.Add();

            a.Print();
            b.Print();
            c.Print();
            d.Print();

            Console.WriteLine(Class2.cnt);
            Console.ReadKey();
        }
    }
}
