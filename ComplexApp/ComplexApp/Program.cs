using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // "5/6 1/2"
            string s = Console.ReadLine();
            string[] token = s.Split();
            // token[0] = "5/6"
            // token[1] = "1/2"
            string[] arr1 = token[0].Split('/'); // arr1[0] = '5' arr1[1] = '6'
            string[] arr2 = token[1].Split('/'); // arr2[0] = '1' arr2[1] = '2'

            Complex cmp1 = new Complex(int.Parse(arr1[0]), int.Parse(arr1[1]));
            Complex cmp2 = new Complex(int.Parse(arr2[0]), int.Parse(arr2[1]));
            // Complex cmp3 = cmp1.Add(cmp2); // (6, 8)
            Complex cmp3 = cmp1 + cmp2;
            // Complex cmp4 = cmp1 - cmp2;
            

            Console.WriteLine(cmp3);
            
            */
            // "1/2 4/5 5/7 3/8"
            string s = Console.ReadLine();
            string[] token = s.Split();
            Complex result = new Complex(0, 0);
            // for (int i = 0; i < token.Count(); i++)
            // t = token[i]
            foreach (string t in token)
            {
                string[] arr = t.Split('/');
                Complex cmp = new Complex(int.Parse(arr[0]), int.Parse(arr[1]));
                result = result + cmp;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
