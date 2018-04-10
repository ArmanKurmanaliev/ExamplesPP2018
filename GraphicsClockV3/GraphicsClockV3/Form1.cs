using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsClockV3
{
    public partial class Form1 : Form
    {
        int r, rs, rm, rh, gs, gm, gh, xc, yc;
        public Form1()
        {
            InitializeComponent();
            r = 100;
            rs = 80;
            rm = 60;
            rh = 40;
            gs = 30;
            gm = 60;
            gh = 90;
            xc = this.Width / 2;
            yc = this.Height / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void DrawLine(Color c, Graphics gr, int r, int g)
        {
            int x = (int)(r * Math.Cos(g * Math.PI / 180));
            int y = (int)(r * Math.Sin(g * Math.PI / 180));
            gr.DrawLine(new Pen(c, 3), xc, yc, xc + x, yc + y);

        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i <= 360; i += 6)
            {
                int r1 = 85;
                int r2 = 95;
                int x1 = (int)(r1 * Math.Cos(i * Math.PI / 180));
                int x2 = (int)(r2 * Math.Cos(i * Math.PI / 180));
                int y1 = (int)(r1 * Math.Sin(i * Math.PI / 180));
                int y2 = (int)(r2 * Math.Sin(i * Math.PI / 180));
                g.DrawLine(new Pen(Color.Green), xc + x1, yc + y1, xc + x2, yc + y2);
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw(e.Graphics);
            e.Graphics.DrawEllipse(new Pen(Color.Blue), xc - r, yc - r, 2 * r, 2 * r);
            DrawLine(Color.Red, e.Graphics, rs, gs);
            DrawLine(Color.Blue, e.Graphics, rm, gm);
            DrawLine(Color.Yellow, e.Graphics, rh, gh);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gs += 6;
            if (gs % 360 == 0)
                gm += 6;
            if (gm % 360 == 0)
                gh += 30;
            Refresh();
        }
    }
}
