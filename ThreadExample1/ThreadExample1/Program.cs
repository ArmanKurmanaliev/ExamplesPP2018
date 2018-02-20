using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample1
{
    class Program
    {
        public static void func()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
                Thread.Sleep(0);
            }
        }

        public static void F2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(F2);
            //Thread thread2 = new Thread(F2);

            thread1.Start();
            //thread2.Start();
            // func();

            /*
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
                Thread.Sleep(0);
            }
             */ 
            Console.ReadKey();
        }
    }
}
