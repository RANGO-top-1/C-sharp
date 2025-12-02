using calkylitor;


namespace calkylitor
{

    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;

        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == ":")
            {
                res = dn1 / dn2;
            }
            n2 = true;
            textBox1.Text = res.ToString();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Double db = Double.Parse(textBox1.Text);
            Double dd = 1;
            for (Double d = 1; d <= db; d++)
                dd = dd * d;
            textBox1.Text = dd.ToString();
        }
    }


}      