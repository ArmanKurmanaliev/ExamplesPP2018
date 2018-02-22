using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExampleW7G2
{
    class Program
    {
        static void func()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
                //Thread.Sleep(0);
            }
        }
        static void F1()
        {

            Thread thread = new Thread(func);
            thread.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(0);
            }
            Console.ReadKey();

        }

        static void F2(object obj)
        {

            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            //F1();
            Thread thread1 = new Thread(F2);
            thread1.Name = "thread 1";
            thread1.Start(15);
            Thread thread2 = new Thread(F2);
            thread2.Name = "thread 2";
            thread2.Start(10);
            Console.ReadKey();
        }
    }
}
