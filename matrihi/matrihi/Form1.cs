using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace matrihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string.IsNullOrWhiteSpace(textBox1.Text);
            string.IsNullOrWhiteSpace(textBox2.Text);
            string.IsNullOrWhiteSpace(textBox3.Text);
            string.IsNullOrWhiteSpace(textBox4.Text);
            string.IsNullOrWhiteSpace(textBox5.Text);
            string.IsNullOrWhiteSpace(textBox6.Text);

            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double num3 = double.Parse(textBox3.Text);
            double num4 = double.Parse(textBox4.Text);
            double num5 = double.Parse(textBox5.Text);
            double num6 = double.Parse(textBox6.Text);

            double r = (num1 * num5);
            double r2 = (num2 * num4);
            double r3 = r - r2;


            double y = (num1 * num6);
            double y2 = (num3 * num4);
            double y3 = y - y2;

            double x = (num6 * num2);
            double x2 = (num5 * num3);
            double x3 = x2 - x;

            double b = x3 / r3;
            double b2 = y3 / r3;

            label1.Text = $"X= {b}";
            label2.Text = $"Y= {b2}";
            label3.Text = $"Дельта={r3}";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
