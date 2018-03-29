using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV3_1
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
            k++;
            label1.Text = k.ToString();
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawLine(pen, 10, 10, 150, 200);
            e.Graphics.DrawRectangle(new Pen(Color.Blue), 20, 20, 40, 50);
            e.Graphics.DrawEllipse(new Pen(Color.Green, 3), 20, 20, 40, 50);
            e.Graphics.DrawPie(new Pen(Color.Yellow, 5), 20, 20, 40, 50, 30, 40);

            SolidBrush brush = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(brush, 30, 40, 50, 60);
        }
    }
}
