using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace SpeedRacer
{
    class Program
    {
        
        
        public static int n;
        
        public static void ReadAllCars(Game g)
        {
            StreamReader sr = new StreamReader("input.txt");
            n = int.Parse(sr.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string x = sr.ReadLine();
                string[] a = x.Split();
                Car car = new Car(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]));
                g.cars.Add(car);
            }
            sr.Close();
        }
        
        public static double min;
        public static int index;
        
        public static void CalucalateMin(Game g)
        {
            min = (100 - g.cars[0].x) * 1.0 / g.cars[0].speed;
            index = 0;
            for (int i = 1; i < n; i++)
            {
                if (min > (100 - g.cars[i].x) * 1.0 / g.cars[i].speed)
                {
                    min = (100 - g.cars[i].x) * 1.0 / g.cars[i].speed;
                    index = i;
                }
            }
        }

        static void MoveAllCars(object game)
        {
            Game g = (Game)game;
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < n; i++)
                {
                    g.cars[i].Draw();
                    g.cars[i].Move();
                }
                Thread.Sleep(1000);
            }
        }
        
        static void Main(string[] args)
        {
            Game g = new Game();
            ReadAllCars(g);
            CalucalateMin(g);
            StreamWriter sw = new StreamWriter("output.txt");
            sw.Write(index);
            sw.Close();
            Thread t = new Thread(MoveAllCars);
            t.Start(g);

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    g.cars[2].Up();
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    g.cars[2].Down();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Game));
                    FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    xs.Serialize(fs, g);
                    fs.Close();
                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Game));
                    FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    g = xs.Deserialize(fs) as Game;
                    fs.Close();
                    t.Abort();
                    t = new Thread(MoveAllCars);
                    t.Start(g);
                }
            }
            
        }
    }
}
