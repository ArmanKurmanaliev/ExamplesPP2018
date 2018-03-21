using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExample1
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
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 2);
            g.DrawLine(pen, 100, 100, 200, 200);
            g.DrawRectangle(new Pen(Color.Blue, 5), 10, 10, 20, 30);

            g.DrawEllipse(pen, 10, 10, 20, 30);
            SolidBrush brush = new SolidBrush(Color.Cyan);

            g.FillRectangle(brush, 30, 40, 50, 50);
            g.FillEllipse(brush, 130, 140, 50, 50);
            g.DrawPie(pen, 230, 240, 50, 50, 30, 60);

            g.DrawString("hello world", new Font(FontFamily.GenericSansSerif, 18), brush, 100, 100);
        }
    }
}
