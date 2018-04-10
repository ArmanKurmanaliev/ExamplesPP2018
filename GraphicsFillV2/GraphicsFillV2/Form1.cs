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

namespace GraphicsFillV2
{
    public partial class Form1 : Form
    {
        Queue<Point> q = new Queue<Point>();
        Bitmap bmp;
        Color fillColor, initColor;
        Graphics g;
        bool clicked;
        Point prev, cur;

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
            fillColor = Color.Red;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            clicked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Check(int x, int y) {
            if (x < 0 || y < 0 || x >= pictureBox1.Width || y >= pictureBox1.Height)
                return;

            if (bmp.GetPixel(x, y) == initColor)
            {
                bmp.SetPixel(x, y, fillColor);
                q.Enqueue(new Point(x, y));
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            if (tool == Tool.FILL)
            {
                initColor = bmp.GetPixel(e.X, e.Y);
                q.Enqueue(new Point(e.X, e.Y));
                bmp.SetPixel(e.X, e.Y, fillColor);

                while (q.Count > 0)
                {
                    Point cur = q.Dequeue();
                    Check(cur.X + 1, cur.Y);
                    Check(cur.X - 1, cur.Y);
                    Check(cur.X, cur.Y + 1);
                    Check(cur.X, cur.Y - 1);
                    pictureBox1.Refresh();
                    Thread.Sleep(1);
                }
                
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (clicked && tool == Tool.PEN)
            {
                g.DrawLine(new Pen(Color.Black), prev.X, prev.Y, cur.X, cur.Y);
                pictureBox1.Refresh();
                prev = cur;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
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
