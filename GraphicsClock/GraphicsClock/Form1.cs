using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsClock
{
    public partial class Form1 : Form
    {
        int xc, yc;
        int rh, rm, rs;
        int ah, am, asec;
        int x1, y1, x2, y2;
        DateTime d;

        public Form1()
        {
            InitializeComponent();
            xc = 100;
            yc = 100;
            rs = 50;
            asec = 270;
            am = 0;
            ah = 180;
            rm = 30;
            rh = 20;
            d = DateTime.Now;
            ah = d.Hour * 30 - 90;
            am = d.Minute * 6 - 90;
            asec = d.Second * 6 - 90;
            

        }

        public void DrawLines(Graphics g)
        {
            int r1 = 48;
            int r2 = 43;
            for (int i = 0; i <= 360; i += 6)
            {
                x1 = (int)(r1 * Math.Cos(i * Math.PI / 180));
                x2 = (int)(r2 * Math.Cos(i * Math.PI / 180));
                y1 = (int)(r1 * Math.Sin(i * Math.PI / 180));
                y2 = (int)(r2 * Math.Sin(i * Math.PI / 180));
                g.DrawLine(new Pen(Color.Purple), xc + x1, yc + y1, xc + x2, yc + y2);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            DrawLines(e.Graphics);
            e.Graphics.DrawEllipse(new Pen(Color.Blue), xc - rs, yc - rs, 2 * rs, 2 * rs);
            int xn_sec = (int)((rs - 10) * Math.Cos(asec * Math.PI / 180));
            int yn_sec = (int)((rs - 10) * Math.Sin(asec * Math.PI / 180));

            int xn_min = (int)(rm * Math.Cos(am * Math.PI / 180));
            int yn_min = (int)(rm * Math.Sin(am * Math.PI / 180));
            int xn_h = (int)(rh * Math.Cos(ah * Math.PI / 180));
            int yn_h = (int)(rh * Math.Sin(ah * Math.PI / 180));

            e.Graphics.DrawLine(new Pen(Color.Red), xc, yc, xc + xn_sec, yc + yn_sec);
            e.Graphics.DrawLine(new Pen(Color.Blue), xc, yc, xc + xn_min, yc + yn_min);
            e.Graphics.DrawLine(new Pen(Color.Green), xc, yc, xc + xn_h, yc + yn_h);
            //MessageBox.Show(Math.Cos(a * Math.PI / 180).ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            asec += 6;
            if (asec == 360)
                asec = 0;
            if (asec == 270)
                am += 6;
            if (am % 360 == 0)
                am = 0;
            if (am == 270)
            {
                ah += 30;
                am += 360;
            }
            if (ah == 360)
                ah = 0;
            pictureBox1.Refresh();
        }
    }
}
