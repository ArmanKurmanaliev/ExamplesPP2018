using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex cmp1 = new Complex(5, 6);
            Complex cmp2 = new Complex(1, 2);
            // Complex cmp3 = cmp1.Add(cmp2); // (6, 8)
            Complex cmp3 = cmp1 + cmp2;
            // Complex cmp4 = cmp1 - cmp2;
            

            Console.WriteLine(cmp3);
            Console.ReadKey();
        }
    }
}
