using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3G2_Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    y--;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    y++;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    x--;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    x++;
                Console.Clear();
                Console.CursorVisible = false;
                try
                {
                    Console.SetCursorPosition(x, y);
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR!!!");
                    Console.ReadKey();
                }
                Console.WriteLine("*");
            }
        }
    }
}
