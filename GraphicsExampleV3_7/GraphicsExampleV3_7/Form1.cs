using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV3_7
{
    public partial class Form1 : Form
    {
        bool mouseClicked;
        Point prev, cur;
        Graphics g;
        Pen pen;

        public enum Tool
        {
            PEN,
            RECTANGLE
        };

        Tool tool;
        public Form1()
        {
            InitializeComponent();
            mouseClicked = false;
            g = this.CreateGraphics();
            tool = Tool.RECTANGLE;
            pen = new Pen(Color.Black);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            prev = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (mouseClicked == true && tool == Tool.PEN)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }

            if (mouseClicked == true && tool == Tool.RECTANGLE)
            {
                g.Clear(Color.White);
                int minx = Math.Min(prev.X, cur.X);
                int miny = Math.Min(prev.Y, cur.Y);
                int width = Math.Abs(prev.X - cur.X);
                int height = Math.Abs(prev.Y - cur.Y);

                // g.DrawEllipse(pen, minx, miny, width, height);
                g.DrawEllipse(pen, prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y);
            }
        }
    }
}
