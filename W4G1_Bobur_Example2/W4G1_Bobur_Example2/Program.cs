﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G1_Bobur_Example2
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 a = new Class1();
            Class1 b = new Class1();
            
            Class2 c = new Class2();
            Class2 d = new Class2();
            
            a.Add();
            b.Add();
            a.Add();
            b.Add();

            c.Add();
            c.Add();
            c.Add();
            c.Add();
            
            a.Print();
            b.Print();
            d.Print();

            Console.WriteLine(Class2.cnt);

            Console.ReadKey();

        }
    }
}
