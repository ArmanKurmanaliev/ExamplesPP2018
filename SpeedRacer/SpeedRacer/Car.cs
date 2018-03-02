using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacer
{
    public class Car
    {
        public int x, y, speed;
        public Car() { }
        public Car(int _x, int _y, int _speed)
        {
            x = _x;
            y = _y;
            speed = _speed;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("O   O");
            Console.SetCursorPosition(x, y + 1);
            Console.WriteLine("*********");
            Console.SetCursorPosition(x, y + 2);
            Console.WriteLine("O   O");
        }

        public void Move()
        {
            x = x + speed;
        }

        public void Up()
        {
            y--;
        }

        public void Down()
        {
            y++;
        }
    }
}
