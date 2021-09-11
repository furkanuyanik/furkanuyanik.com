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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Yazdir_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void btn_GecisYap_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Visible = false;
            form.ShowDialog();
            this.Close();
        }
    }
}
