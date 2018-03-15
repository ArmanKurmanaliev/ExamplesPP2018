using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int BTN_SIZE = 70;
        Button[,] btns = new Button[3,3];
        private void Form1_Load(object sender, EventArgs e)
        {
            
            int cnt = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Click += btn_click;
                    btns[i, j].Text = cnt.ToString();
                    btns[i, j].Font = new Font("Arial", 16);
                    cnt++;
                    btns[i, j].Size = new Size(BTN_SIZE, BTN_SIZE);
                    btns[i, j].Location = new Point(10 + j * BTN_SIZE, 30 + i * BTN_SIZE);
                    Controls.Add(btns[i, j]);
                }
            }

            //btns[1, 2].Font = new Font("Arial", 20);
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text = textBox1.Text + btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
