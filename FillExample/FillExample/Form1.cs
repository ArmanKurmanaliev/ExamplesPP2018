using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillExample
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Pen pen;
        Point prev, cur;
        Color initColor, fillColor;
        bool clicked;
        Queue<Point> q = new Queue<Point>();

        enum Tool
        {
            PEN,
            FILL
        }

        Tool tool = Tool.PEN;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            pen = new Pen(Color.Black);
            fillColor = Color.Red;
            clicked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void check(int x, int y)
        {
            if (x < 0 || x >= pictureBox1.Width || y < 0 || y >= pictureBox1.Height)
                return;

            if (bmp.GetPixel(x, y) == initColor)
            {
                q.Enqueue(new Point(x, y));
                bmp.SetPixel(x, y, fillColor);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            if (tool == Tool.FILL)
            {
                initColor = bmp.GetPixel(e.X, e.Y);
                bmp.SetPixel(e.X, e.Y, fillColor);
                q.Enqueue(e.Location);
                while (q.Count > 0)
                {
                    cur = q.Dequeue();
                    check(cur.X, cur.Y - 1);
                    check(cur.X + 1, cur.Y);
                    check(cur.X, cur.Y + 1);
                    check(cur.X - 1, cur.Y);
                    pictureBox1.Refresh();
                    Thread.Sleep(1);
                }
                
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
                g.DrawLine(pen, prev.X, prev.Y, cur.X, cur.Y);
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

        private void button3_Click(object sender, EventArgs e)
        {
            fillColor = (sender as Button).BackColor;
        }
    }
}
