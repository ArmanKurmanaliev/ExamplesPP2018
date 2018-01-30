using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W4G1_Bobur_Example3
{
    class Wall
    {
        List<Point> body;
        ConsoleColor color;
        string sign;

        public void ReadLevel1()
        {
            StreamReader sr = new StreamReader(@"C:\Users\a.akshabaev\Desktop\level1.txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
            }
        }

        public Wall()
        {
            body = new List<Point>();
            color = ConsoleColor.Magenta;
            sign = "o";
            ReadLevel1();
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
    }
}
