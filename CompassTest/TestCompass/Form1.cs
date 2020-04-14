using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCompass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                userControl11.CurrentValue = 180;
            else
                userControl11.CurrentValue = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = userControl11.CurrentValue.ToString();
            textBox1.Text = text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar)) &&(!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                userControl11.ExpectedValue = int.Parse(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = userControl11.Difference.ToString();
        }
    }
}
