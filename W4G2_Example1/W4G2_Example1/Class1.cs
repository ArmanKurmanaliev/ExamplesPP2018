using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G2_Example1
{
    class Class1
    {
        public int cnt;
        public Class1()
        {
            cnt = 0;
        }
        
        public void Add()
        {
            cnt++;
        }

        public void Print()
        {
            Console.WriteLine(cnt);
        }
    }
}
