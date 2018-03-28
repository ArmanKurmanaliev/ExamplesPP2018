﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExampleV2_6
{
    public partial class Form1 : Form
    {
        bool clicked;
        int prevX, prevY;
        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            clicked = false;
            g = CreateGraphics();
            pen = new Pen(Color.Black);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prevX = e.X;
            prevY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (clicked)
            {
                g.DrawLine(pen, prevX, prevY, e.X, e.Y);
                prevX = e.X;
                prevY = e.Y;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }
    }
}