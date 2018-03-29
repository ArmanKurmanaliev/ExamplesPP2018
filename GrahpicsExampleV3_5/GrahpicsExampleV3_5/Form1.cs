using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrahpicsExampleV3_5
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Shape shape1 = new Shape(40, 50, 60, 60, Color.Red);
            Shape shape2 = new Shape(100, 30, 80, 80, Color.Blue);
            shape1.Draw(e.Graphics);
            shape2.Draw(e.Graphics);
        }

        string[] colors = { "yellow", "red", "blue", "cyan", "purple", "green" };

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, colors.Length);
            Shape shape = new Shape(e.X - 20, e.Y - 20, 40, 40, Color.FromName(colors[index]));
            shape.Draw(g);
        }

    }
}
