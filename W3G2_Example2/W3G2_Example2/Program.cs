using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// DirectoryInfo, FileInfo -> FileSystemInfo

namespace W3G2_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\a.akshabaev\Desktop\Examples");
            /*
            DirectoryInfo[] dirs = directory.GetDirectories();
            FileInfo[] files = directory.GetFiles();

            foreach (DirectoryInfo d in dirs)
            {
                Console.WriteLine(d.Name);
            }

            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
             */
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();

            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            foreach (FileSystemInfo f in fss)
            {
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("directory: " + f.Name);
                }
                if (f.GetType() == typeof(FileInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("file " + f.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
