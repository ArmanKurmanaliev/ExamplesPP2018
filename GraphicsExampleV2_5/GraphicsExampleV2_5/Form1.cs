using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV2_5
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
            bmp1 = new Bitmap("3.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = bmp1;
            bmp2 = new Bitmap(bmp1.Width, bmp1.Height);
            bmp3 = new Bitmap(bmp1.Width, bmp1.Height);
            bmp4 = new Bitmap(bmp1.Width, bmp1.Height);
            bmp5 = new Bitmap(bmp1.Width, bmp1.Height);

            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    Color color = bmp1.GetPixel(i, j);
                    int R = color.R;
                    int G = color.G;
                    int B = color.B;
                    bmp2.SetPixel(i, j, Color.FromArgb(R, 0, 0));
                    bmp3.SetPixel(i, j, Color.FromArgb(0, G, 0));
                    bmp4.SetPixel(i, j, Color.FromArgb(R, 0, B));

                    int gray = (R + G + B) / 3;
                    bmp5.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            pictureBox2.Image = bmp2;
            pictureBox3.Image = bmp3;
            pictureBox4.Image = bmp4;
            pictureBox5.Image = bmp5;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
