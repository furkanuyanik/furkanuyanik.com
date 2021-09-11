using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lesson_3_for_loop_and_switch_case
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Faktoriyel_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int cevap = 1;

            for (int i = 1; i <= sayi; i++)
            {
                cevap = cevap * i;
            }

            lbl_Cevap.Text = cevap.ToString();
        }

        private void btn_GecisYap_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }

    }
}
