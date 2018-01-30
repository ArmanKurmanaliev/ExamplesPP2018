using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4G1_Bobur_Example3
{
    class Snake
    {
        string sign;
        ConsoleColor color;
        List<Point> body;
        public int cnt;

        public Snake()
        {
            cnt = 0;
            sign = "*";
            color = ConsoleColor.Yellow;
            
            body = new List<Point>();
            body.Add(new Point(10, 10));
        }

        public void Move(int dx, int dy)
        {
            cnt++;
            if (cnt % 20 == 0)
                body.Add(new Point(0, 0));

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;



            if (body[0].x < 5)
                body[0].x = Console.WindowWidth - 5;
            if (body[0].x > Console.WindowWidth - 5)
                body[0].x = 5;
            if (body[0].y < 5)
                body[0].y = Console.WindowHeight - 5;
            if (body[0].y > Console.WindowHeight - 5)
                body[0].y = 5;
        }

        public void Draw()
        {
            int index = 0;
            foreach (Point p in body)
            {
                if (index == 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = color;

                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
                index++;
            }
        }
    }
}
