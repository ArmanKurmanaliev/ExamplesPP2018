using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W3G1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\a.akshabaev\Desktop\Examples");
            DirectoryInfo[] ds = directory.GetDirectories();
            FileInfo[] fs = directory.GetFiles();
            /*
            foreach (DirectoryInfo d in ds)
            {
                Console.WriteLine(d.Name);
            }

            Console.WriteLine();

            foreach (FileInfo f in fs)
            {
                Console.WriteLine(f.Name);
            }
            */

            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            foreach (FileSystemInfo f in fss)
            {
                if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.WriteLine("Directory: " + f.Name);
                }
                else
                {
                    Console.WriteLine("File: " + f.FullName);
                }
            }
            Console.ReadKey();
        }
    }
}
