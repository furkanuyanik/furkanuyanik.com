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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(txt_Sayi.Text);
            int bolen=Convert.ToInt32(txt_Bolen.Text);

            int sayi2 = sayi;

            int bolme_sayisi=0;
            for (int i = 0; i < sayi; i++)
            {
                if (sayi2-bolen>=0)
                {
                    sayi2 = sayi2 - bolen;
                    bolme_sayisi++;
                }
            }
            lbl_BolunmeSayisi.Text = bolme_sayisi.ToString();
            lbl_Kalani.Text = (sayi % bolen).ToString();
        }

        private void btn_GecisYap_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
