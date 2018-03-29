using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tank tank;
        Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            tank = new Tank(10, 50, 50, 50, Color.Red);
            g = CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // tank.Draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            tank.Move();
            tank.Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                tank.d = Tank.Direction.DOWN;
            if (e.KeyCode == Keys.D)
                tank.d = Tank.Direction.RIGHT;
        }
    }
}
