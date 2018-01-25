using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W3G3_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\a.akshabaev\Desktop\a.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\a.akshabaev\Desktop\output.txt");
            string s = sr.ReadLine();
            string[] token = s.Split();
            int mini = int.Parse(token[0]);
            for (int i = 1; i < token.Length; i++)
            {
                if (mini > int.Parse(token[i]))
                    mini = int.Parse(token[i]);
            }
            sw.WriteLine(mini);
            sw.Close();
        }
    }
}
