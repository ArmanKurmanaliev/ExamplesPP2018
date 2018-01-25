using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W3G2_Example4
{
    class Program
    {
        static void ShowDirectoryInfo(DirectoryInfo directory, int cursor)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            int index = 0;
            foreach (FileSystemInfo f in fss)
            {
                if (index == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine(f.Name);
                index++;
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\a.akshabaev\Desktop\Examples");
            int cursor = 0;
            ShowDirectoryInfo(directory, cursor);
            int n = directory.GetFileSystemInfos().Length;
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0)
                        cursor = n - 1;
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                        cursor = 0;
                }
                ShowDirectoryInfo(directory, cursor);
            }
        }
    }
}
