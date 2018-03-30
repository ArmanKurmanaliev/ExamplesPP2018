using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            Color color = button1.BackColor;
            pen = new Pen(color);
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawLine(pen, 10, 10, 200, 200);
        }
    }
}
