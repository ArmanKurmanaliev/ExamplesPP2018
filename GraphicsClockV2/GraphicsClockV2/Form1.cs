using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsClockV2
{
    public partial class Form1 : Form
    {
        int xc, yc, r, rs, rm, rh, asec, am, ah;
        public Form1()
        {
            InitializeComponent();
            xc = this.Width / 2;
            yc = this.Height / 2;
            r = 70;
            rs = 55;
            rm = 50;
            rh = 30;
            DateTime date = DateTime.Now;
            ah = date.Hour * 30 - 90;
            am = date.Minute * 6 - 90;
            asec = date.Second * 6 - 90;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void DrawLines(Graphics g)
        {
            int r1 = 60;
            int r2 = 65;
            for (int i = 0; i <= 360; i += 6)
            {
                int x1 = (int)(r1 * Math.Cos(i * Math.PI / 180));
                int x2 = (int)(r2 * Math.Cos(i * Math.PI / 180));
                int y1 = (int)(r1 * Math.Sin(i * Math.PI / 180));
                int y2 = (int)(r2 * Math.Sin(i * Math.PI / 180));
                g.DrawLine(new Pen(Color.Red), x1 + xc, y1 + yc, x2 + xc, y2 + yc);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawLines(e.Graphics);
            Pen pen = new Pen(Color.Blue);
            e.Graphics.DrawEllipse(pen, xc - r, yc - r, 2 * r, 2 * r);
            int xs = (int)(rs * Math.Cos(asec * Math.PI / 180));
            int ys = (int)(rs * Math.Sin(asec * Math.PI / 180));

            int xm = (int)(rm * Math.Cos(am * Math.PI / 180));
            int ym = (int)(rm * Math.Sin(am * Math.PI / 180));

            int xh = (int)(rh * Math.Cos(ah * Math.PI / 180));
            int yh = (int)(rh * Math.Sin(ah * Math.PI / 180));

            e.Graphics.DrawLine(new Pen(Color.Red), xc, yc, xs + xc, ys + yc);
            e.Graphics.DrawLine(new Pen(Color.Green), xc, yc, xm + xc, ym + yc);
            e.Graphics.DrawLine(new Pen(Color.Purple), xc, yc, xh + xc, yh + yc);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            asec += 6;
            if (asec % 270 == 0)
                am += 6;
            if (am % 270 == 0)
                ah += 30;
            Refresh();
        }
    }
}
