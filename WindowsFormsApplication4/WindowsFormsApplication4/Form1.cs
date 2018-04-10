using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Text = "";
            txt.Leave += txt_click;
            txt.Location = e.Location;
            pictureBox1.Controls.Add(txt);
        }

        private void txt_click(object sender, EventArgs e)
        {
            pictureBox1.Controls.Remove(sender as TextBox);
        }
    }
}
