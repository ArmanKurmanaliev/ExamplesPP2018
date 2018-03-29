using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV3_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp1, bmp2, bmp3, bmp4, bmp5;
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp1 = new Bitmap("4.jpg");
            bmp2 = new Bitmap(bmp1.Width, bmp1.Height);
            bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            bmp4 = new Bitmap(bmp1.Width, bmp1.Height);
            bmp5 = new Bitmap(bmp1.Width, bmp1.Height);

            for (int i = 0; i < bmp1.Width; i++)
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color color = bmp1.GetPixel(i, j);
                    int colorR = color.R;
                    int colorG = color.G;
                    int colorB = color.B;
                    int grey = (colorR + colorG + colorB) / 3;

                    bmp2.SetPixel(i, j, Color.FromArgb(colorR, 0, 0));
                    bmp3.SetPixel(i, j, Color.FromArgb(0, colorG, 0));
                    bmp4.SetPixel(i, j, Color.FromArgb(0, 0, colorB));

                    bmp5.SetPixel(i, j, Color.FromArgb(grey, grey, grey));

                }

            pictureBox1.Image = bmp1;
            pictureBox2.Image = bmp2;
            pictureBox3.Image = bmp3;
            pictureBox4.Image = bmp4;
            pictureBox5.Image = bmp5;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = bmp1.GetPixel(e.X, e.Y);
            label1.Text = color.R + " " + color.G + " " + color.B;
            bmp1.SetPixel(20, 30, Color.FromArgb(20, 30, 40));
        }
    }
}
