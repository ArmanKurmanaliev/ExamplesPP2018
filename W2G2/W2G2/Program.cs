using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace W2G2
{
    class Program
    {
        public static void Ex1()
        {
            FileInfo f = new FileInfo(@"C:\Users\a.akshabaev\Desktop\Examples\a.txt");
            Console.WriteLine(f.Name);
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Directory);
        }

        public static void Ex2()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\a.akshabaev\Desktop\Examples");
            Console.WriteLine(d.Name);
            Console.WriteLine(d.FullName);
            Console.WriteLine(d.Parent);
        }

        public static void Ex3()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\a.akshabaev\Desktop\Examples");
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }

            DirectoryInfo[] directories = d.GetDirectories();
            foreach (DirectoryInfo directory in directories)
            {
                Console.WriteLine(directory.Name);
            }
        }

        public static void PrintEmptySpaces(int n)
        {
            for (int i = 0; i < n * 4; i++)
            {
                Console.Write(" ");
            }
        }

        public static void Ex4(DirectoryInfo d, int level)
        {
            try
            {
                FileInfo[] files = d.GetFiles();
                DirectoryInfo[] directories = d.GetDirectories();

                foreach (FileInfo file in files)
                {
                    PrintEmptySpaces(level);
                    Console.WriteLine(file.Name);
                }

                foreach (DirectoryInfo directory in directories)
                {
                    PrintEmptySpaces(level);
                    Console.WriteLine(directory.Name);
                    Ex4(directory, level + 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
        }
        
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\windows");
            Ex4(d, 1);
            Console.ReadKey();
        }
    }
}
