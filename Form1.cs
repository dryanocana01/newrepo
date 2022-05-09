using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap1test2
{
    public partial class Form1 : Form
    {
        private long result; 
        public Form1()
        {
            InitializeComponent();
            result = 0;
        }

        private void form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on "+ sender.ToString() + "??! Calm down!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click on "+ sender.ToString() + "??! Good job!");
        }

        private void digit0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void digit1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void asterisk_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void slash_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var res = cal(textBox1.Text);
            textBox1.Text += " = " + res.ToString();
        }

        private object cal(string text)
        {
            DataTable dt = new DataTable();
            var v = new object();
            try
            {
                v = dt.Compute(text, "");
            }
            catch(Exception e) {
                v = "NaN";
            }
            
            return v;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void openP_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void closeP_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void anybutton_Click(object sender, EventArgs e)
        {

        }

        private void example(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
    }
}
