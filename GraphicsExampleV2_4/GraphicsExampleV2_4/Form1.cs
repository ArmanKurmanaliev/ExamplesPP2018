using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV2_4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Shape shape;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            shape = new Shape(50, 50, 40, 40, Color.Blue);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            shape.Draw(g);
        }

        string[] colors = {"blue", "red", "cyan", "yellow", "black", "purple"};

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, colors.Length);
            shape = new Shape(e.X - 20, e.Y - 20, 40, 40, Color.FromName(colors[index]));
            shape.Draw(g);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, colors.Length);
            shape = new Shape(e.X - 20, e.Y - 20, 40, 40, Color.FromName(colors[index]));
            shape.Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) {
                g.DrawString("Hello world, A", new Font("Arial", 20), new SolidBrush(Color.Red), 40, 60);
            }
        }
    }
}
