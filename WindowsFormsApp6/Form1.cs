using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Multi(num1, num2));

        }

        private void addition_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Add(num1, num2));
        }

        private void division_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Divi(num1, num2));

        }

        private void substraction_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(Class1.Sub(num1, num2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
