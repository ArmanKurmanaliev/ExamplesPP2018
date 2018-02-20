using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class BigInt
    {
        public int[] a;
        public int len;
        public BigInt(string s)
        {
            this.a = new int[120];
            this.len = s.Length;
            int index = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                this.a[index] = s[i] - '0';
                index++;
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < this.len; i++)
            {
                s = (char)(this.a[i] + '0') + s;
            }
            return s;
        }

        public static BigInt operator +(BigInt t1, BigInt t2)
        {
            BigInt c = new BigInt("");
            c.len = Math.Max(t1.len, t2.len);
            int k = 0;
            for (int i = 0; i < c.len; i++)
            {
                c.a[i] = t1.a[i] + t2.a[i] + k;
                k = c.a[i] / 10;
                c.a[i] %= 10;
            }
            if (k > 0)
            {
                c.len++;
                c.a[c.len - 1] = k;
            }
            return c;
        }
    }
}
