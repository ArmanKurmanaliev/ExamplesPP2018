using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3G2_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("Up");
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("Down");
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("Left");
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("Right");
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
