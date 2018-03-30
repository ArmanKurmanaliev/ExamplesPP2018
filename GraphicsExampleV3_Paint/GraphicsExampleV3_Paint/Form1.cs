using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV3_Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        bool clicked;
        Point prev, cur;
        Pen pen;
        enum Tool {
            PEN,
            RECTANGLE
        };

        Tool tool = Tool.PEN;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            clicked = false;
            pen = new Pen(Color.Black);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == false)
                return;
            cur = e.Location;
            if (tool == Tool.PEN)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
            if (tool == Tool.RECTANGLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                g.DrawRectangle(pen, x, y, w, h);
            }
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.RECTANGLE;
        }

        private void colorBtn_Clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pen.Color = btn.BackColor;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (clicked && tool == Tool.RECTANGLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawRectangle(pen, x, y, w, h);
            }
        }
    }
}
