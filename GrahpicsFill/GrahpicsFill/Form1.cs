using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrahpicsFill
{
    public partial class Form1 : Form
    {


        bool clicked = false;
        Point prev, cur;
        Bitmap bmp;
        Graphics g;
        enum Tool
        {
            PEN,
            FILL
        };
        Tool tool = Tool.PEN;
        Queue<Point> q = new Queue<Point>();
        Color init_color;
        Color fill_color;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            fill_color = Color.Red;
        }

        public void check(int x, int y)
        {
            if (x < 0 || x > bmp.Width || y < 0 || y > bmp.Height)
                return;
            if (bmp.GetPixel(x, y) == init_color)
            {
                bmp.SetPixel(x, y, fill_color);
                q.Enqueue(new Point(x, y));
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            if (tool == Tool.FILL)
            {
                int x = e.X;
                int y = e.Y;
                init_color = bmp.GetPixel(x, y);
                q.Enqueue(new Point(x, y));
                bmp.SetPixel(x, y, fill_color);
                while (q.Count != 0)
                {
                    Point p = q.Dequeue();
                    check(p.X - 1, p.Y);
                    check(p.X + 1, p.Y);
                    check(p.X, p.Y - 1);
                    check(p.X, p.Y + 1);
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (clicked && tool == Tool.PEN)
            {
                g.DrawLine(new Pen(Color.Black), prev.X, prev.Y, cur.X, cur.Y);
                prev = cur;
                pictureBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.FILL;
        }
    }
}
