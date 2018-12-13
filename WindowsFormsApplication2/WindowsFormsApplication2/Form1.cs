using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var firstnum = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var secnum = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Opera reg = new Opera();
            var firstnum = Convert.ToInt32(textBox1.Text);
            var secnum = Convert.ToInt32(textBox2.Text);
            res.Text= Convert.ToString(reg.ADD(firstnum,secnum));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opera reg = new Opera();
            var firstnum = Convert.ToInt32(textBox1.Text);
            var secnum = Convert.ToInt32(textBox2.Text);
            res.Text = Convert.ToString(reg.SUB(firstnum, secnum));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Opera reg = new Opera();
            var firstnum = Convert.ToInt32(textBox1.Text);
            var secnum = Convert.ToInt32(textBox2.Text);
            res.Text = Convert.ToString(reg.MULT(firstnum, secnum));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Opera reg = new Opera();
            var firstnum = Convert.ToInt32(textBox1.Text);
            var secnum = Convert.ToInt32(textBox2.Text);
            if (secnum == 0)
            {
                res.Text = "Math Error";
            }
            else
            {
                res.Text = Convert.ToString(reg.DIV(firstnum, secnum));
            }
        }
    }
}
