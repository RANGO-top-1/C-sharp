using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrihi2
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
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
            string.IsNullOrWhiteSpace(textBox7.Text);
            string.IsNullOrWhiteSpace(textBox8.Text);
            string.IsNullOrWhiteSpace(textBox9.Text);
            string.IsNullOrWhiteSpace(textBox10.Text);
            string.IsNullOrWhiteSpace(textBox11.Text);
            string.IsNullOrWhiteSpace(textBox12.Text);

            double x1 = double.Parse(textBox1.Text);
            double y1= double.Parse(textBox2.Text);
            double z1 = double.Parse(textBox3.Text);
            double r1 = double.Parse(textBox4.Text);
            double x2 = double.Parse(textBox5.Text);
            double y2 = double.Parse(textBox6.Text);
            double z2 = double.Parse(textBox7.Text);
            double r2 = double.Parse(textBox8.Text);
            double x3 = double.Parse(textBox9.Text);
            double y3 = double.Parse(textBox10.Text);
            double z3 = double.Parse(textBox11.Text);
            double r3 = double.Parse(textBox12.Text);
            // Это дельта обычная
            double delt = x1 * y2 * z3;
            double delt2 = x2 * z1 * y3;
            double delt3 = x3 * y1 * z2;

            double sum1 = delt + delt2 + delt3;

            double deltu = z1 * y2 * x3;
            double deltu1 = y3 * x1 * z2;
            double deltu2 = z3 * y1 * x2;

            double sum2 = deltu + deltu1 + deltu2;

            double nom = sum1 - sum2;
            // Дельта x
            double dx = r1 * y2 * z3 ;
            double dx2 = r2 * z1 * y3;
            double dx3 = r3 * y1 * z2;

            double sum3 = dx + dx2 + dx3;

            double dxu = z1 * y2 * r3;
            double dxu2 = r1 * y3 * z2;
            double dxu3 = y1 * r2 * z3;

            double sum4 = dxu + dxu2 + dxu3;

            double nom2 = sum3 - sum4;
            // Дельта y
            double dy = x1 * r2 * z3;
            double dy2 = x2 * z1 * r3;
            double dy3 = x3 * r1 * z2;

            double sum5 = dy + dy2 + dy3;

            double ady = z1 * r2 * x3;
            double ady2 = r3 * x1 * z2;
            double ady3 = z3 * r1 * x2;

            double sum6 = ady + ady2 + ady3;

            double nom3 = sum5 - sum6;
            // Дельта z
            double dz = x1 * y2 * r3;
            double dz2 = x2 * r1 * y3;
            double dz3 = x3 * y1 * r2;

            double sum7 =  dz + dz2 + dz3;

            double adz = r1 * y2 * x3;
            double adz2 = y3 * x1 * r2;
            double adz3 = r3 * y1 * x2;

            double sum8 = adz + adz2 + adz3;

            double nom4 = sum7 - sum8;

            label1.Text = $"{sum1}";
            label2.Text = $"{sum2}";
            label3.Text = $"{nom}";
            label4.Text = $"{sum3}";
            label5.Text = $"{sum4}";
            label6.Text = $"{nom2}";
            label7.Text = $"{sum5}";
            label8.Text = $"{sum6}";
            label31.Text = $"{nom3}";
            label32.Text = $"{sum7}";
            label33.Text = $"{sum8}";
            label34.Text = $"{nom4}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
