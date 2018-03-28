using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrahpicsExampleV2_7
{
    public partial class Form1 : Form
    {
        Graphics g;
        int prevX, prevY;
        bool clicked;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            clicked = false;
            pen = new Pen(Color.Red, 3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                g.Clear(Color.White);
                int x = Math.Min(e.X, prevX);
                int y = Math.Min(e.Y, prevY);
                int w = Math.Abs(e.X - prevX);
                int h = Math.Abs(e.Y - prevY);
                g.DrawRectangle(pen, x, y, w, h);
            }
        }

    }
}
