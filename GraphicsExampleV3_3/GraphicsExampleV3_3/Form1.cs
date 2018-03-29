using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphicsExampleV3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        GraphicsPath path = new GraphicsPath();
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            path.AddLine(10, 10, 50, 50);
            path.AddRectangle(new Rectangle(40, 50, 60, 80));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawPath(new Pen(Color.Red), path);
        }
    }
}
