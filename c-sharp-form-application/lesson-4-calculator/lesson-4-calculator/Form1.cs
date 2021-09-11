using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lesson_4_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char isaret;
        bool birinci_basamak=false;
        double sayi1,sayi2;
        private void Yazdir(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)(sender)).Text;
        }

        private void btn_BasamakSil_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
            }
        }

        private void btn_Topla_Click(object sender, EventArgs e)
        {
            birinci_basamak = true;
            isaret = '+';
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Clear();
        }
        private void btn_Cikar_Click(object sender, EventArgs e)
        {
            birinci_basamak = true;
            isaret = '-';
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Clear();
        }
        private void btn_Carp_Click(object sender, EventArgs e)
        {
            birinci_basamak = true;
            isaret = '*';
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Clear();
        }

        private void btn_Bol_Click(object sender, EventArgs e)
        {
            birinci_basamak = true;
            isaret = '/';
            sayi1 = Convert.ToDouble(textBox1.Text);

            textBox1.Clear();
        }

        private void btn_Esittir_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);

            if (birinci_basamak == true)
            {
                if (isaret == '+')
                {
                    textBox1.Text = (sayi1 + sayi2).ToString();
                }
                if (isaret == '-')
                {
                    textBox1.Text = (sayi1 - sayi2).ToString();
                }
                if (isaret == '*')
                {
                    textBox1.Text = (sayi1 * sayi2).ToString();
                }
                if (isaret == '/')
                {
                    textBox1.Text = (sayi1 / sayi2).ToString();
                }
            }
            sayi2 = 0;
        }

        
    }
}
