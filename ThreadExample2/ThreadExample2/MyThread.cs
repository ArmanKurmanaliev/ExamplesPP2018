using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample2
{
    class MyThread
    {
        Thread thread;

        public MyThread(string name, int num)
        {
            thread = new Thread(this.work);
            thread.Name = name;
            thread.Start(num);
        }

        public void work(object num)
        {
            for (int i = 0; i < (int)num; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                //Thread.Sleep(0);
            }
        }
    }
}
