using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapmakinesii
{
    

    public partial class Form1 : Form
    {
        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void numaralar(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += btn.Text;
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text) > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void buttontopla_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";

        }

        private void buttoncıkar_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void buttoncarp_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "x";
            label1.Text = textBox1.Text + "x";
            textBox1.Text = "0";

        }

        private void buttonbol_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "÷";
            label1.Text = textBox1.Text + "÷";
            textBox1.Text = "0";
        }

        private void buttonesittir_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
               textBox1.Text = Convert.ToString(x + y);
               label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (islem == "x")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (islem == "÷")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem == "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }
        }

        private void buttonkare_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void buttonkok_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);

        }

        private void buttonbirebol_Click(object sender, EventArgs e)
        {
            double bolumx = Convert.ToDouble(textBox1.Text);
            bolumx = 1/(bolumx);
            textBox1.Text = Convert.ToString(bolumx);
        }

        private void buttonmod_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
}
