using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAExample1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(number1.Text);
            int b = int.Parse(number2.Text);
            int c = a + b;
            label1.Text = c.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int a = int.Parse(number1.Text);
            int b = int.Parse(number2.Text);
            int c = a - b;
            label1.Text = c.ToString();

        }

    }
}
