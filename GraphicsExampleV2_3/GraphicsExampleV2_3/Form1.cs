using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV2_3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Tank tank;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            tank = new Tank(50, 50, 50, 50);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawPath(new Pen(Color.Blue), tank.gp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tank.Move();
            g.Clear(Color.White);
            g.DrawPath(new Pen(Color.Blue), tank.gp);
        }
    }
}
