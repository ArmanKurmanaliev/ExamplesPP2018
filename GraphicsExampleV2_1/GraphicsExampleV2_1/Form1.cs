using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            k = k + 1;
            label1.Text = k.ToString();
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 2);
            g.DrawLine(pen, 100, 100, 200, 200);
            g.DrawRectangle(new Pen(Color.Yellow, 5), 10, 10, 50, 40);
            g.DrawEllipse(pen, 10, 10, 50, 40);

            SolidBrush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, 150, 80, 40, 60);
        }
    }
}
