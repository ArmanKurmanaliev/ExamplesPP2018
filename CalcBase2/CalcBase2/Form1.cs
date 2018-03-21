using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcBase2
{
    public partial class Form1 : Form
    {
        Calc calc = new Calc();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void number_cliecked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s = calc.number_clicked(textBox1.Text, btn.Text);
            textBox1.Text = s;
        }

        private void op_clicked(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string s;
            if (btn.Text == "=")
                s = calc.equal(textBox1.Text);
            else
                s = calc.operation_clicked(textBox1.Text, btn.Text);
            textBox1.Text = s;
        }
    }
}
