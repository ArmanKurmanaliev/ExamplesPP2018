using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcFromCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int cnt = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Text = cnt.ToString();
                    cnt++;
                    btn.Location = new Point(j * 50 + 35, i * 50 + 60);
                    btn.Size = new Size(49, 49);
                    btn.Click += number_click;
                    Controls.Add(btn);
                }
            }
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;
        }
    }
}
