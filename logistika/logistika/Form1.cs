using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace logistika
{
    public partial class Form1 : Form
    {
        private
        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[] b = { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1 };
        int[] c = { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 };
        int[] d = { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
        private int checkOut1(int a, int b, int c, int d)
        {
            int r = a + b + c + d;
            if (r > 1)
            {
                r = 1;
            }
            return r;
        }
        private int checkOut2(int a, int b, int c, int d)
        {
            int r = a + b + c * d;
            if (r > 1)
            {
                r = 1;
            }
            return r;
        }
        private int checkOut3(int a, int b, int c, int d)
        {
            int r = a + b * c * d;
            if (r > 1)
            {
                r = 1;
            }
            return r;
        }
        private int checkOut4(int a, int c)
        {
            int r = a * c;
            if (r > 1)
            {
                r = 1;
            }
            return r;
        }
        private int checkOut5(int b, int a)
        {
            if (b == 0){
             b = 1;
            }

            else if ( b == 1){ 
             b = 0; 
            }
            int r = b + a;
            if (r > 1)
            {
                r = 1;
            }

            return r;       
        }

        private int checkOut6(int b, int a,int c)
        {
            if (a == 0)
            {
                a = 1;
            }

            else if (a == 1)
            {
                a = 0;
            }
            int r = a + b * c;
            if (r > 1)
            {
                r = 1;
            }

            return r;
        }
        private int checkOut7( int a, int d)
        {
            int r = a + d;
            if (r > 1)
            {
                r = 1;
            }

            return r;
        }
        private int checkOut8(int c, int d)
        {
            int r = d * c;
            if (r > 1)
            {
                r = 1;
            }

            return r;
        }
        private int checkOut9(int c, int d)
        {
            int r = d + c;
            if (r > 1)
            {
                r = 1;
            }

            return r;
        }
        private int checkOut10(int b, int d)
        {
            if (d == 0)
            {
                d = 1;
            }

            else if (d == 1)
            {
                d = 0;
            }
            if (b == 0)
            {
                b = 1;
            }

            else if (b == 1)
            {
                b = 0;
            }

            int r = d * b;
            if (r > 1)
            {
                r = 1;
            }

            return r;
        }
        private int checkOut11(int c, int d, int b)
        {
            int r = d * c * b;
            if (r > 1)
            {
                r = 1;
            }

            return r;
        }


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

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Length; i++) {
                listBox1.Items.Add(checkOut1(a[i], b[i], c[i], d[i]));
                listBox2.Items.Add(checkOut2(a[i], b[i], c[i], d[i]));
                listBox3.Items.Add(checkOut3(a[i], b[i], c[i], d[i]));
                listBox4.Items.Add(checkOut4(a[i], c[i]));
                listBox5.Items.Add(checkOut5(b[i], a[i]));
                listBox6.Items.Add(checkOut6(b[i], a[i], c[i]));
                listBox7.Items.Add(checkOut7(d[i], a[i]));
                listBox8.Items.Add(checkOut8(d[i], c[i]));
                listBox9.Items.Add(checkOut9(d[i], c[i]));
                listBox10.Items.Add(checkOut10(d[i], b[i]));
                listBox11.Items.Add(checkOut11(d[i], c[i], b[i]));
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(textBox1.Text);
            int b = Convert.ToInt16(textBox2.Text);
            int c = Convert.ToInt16(textBox3.Text);
            int d = Convert.ToInt16(textBox4.Text);

            textBox5.Text = checkOut1(a, b, c, d).ToString();
            textBox6.Text = checkOut2(a, b, c, d).ToString();
            textBox7.Text = checkOut3(a, b, c, d).ToString();
            textBox8.Text = checkOut4(a, c).ToString();
            textBox9.Text = checkOut5(b, a).ToString();
            textBox10.Text = checkOut6(b, a, c).ToString();
            textBox11.Text = checkOut7(d, a).ToString();
            textBox12.Text = checkOut8(d, c).ToString();
            textBox13.Text = checkOut9(d, c).ToString();
            textBox14.Text = checkOut10(b, d).ToString();
            textBox15.Text = checkOut11(b, c, d).ToString();


        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
