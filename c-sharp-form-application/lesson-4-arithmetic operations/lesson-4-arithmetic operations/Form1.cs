using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lesson_4_arithmetic_operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1.örnek
        private void btn_Bul_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txt_Sayi.Text);

            lbl_Sayi.Text = sayi.ToString();
            lbl_Karesi.Text = (sayi * sayi).ToString();
        }

        // 2.örnek
        private void btn_KDVBul_Click(object sender, EventArgs e)
        {
            if (rd_Gida.Checked==true || rd_Hediyelik.Checked==true)
            {
                double fiyati = Convert.ToInt32(txt_KDVsiz.Text);

                if (rd_Gida.Checked==true)
                {
                    double kdvli_fiyat = fiyati + (fiyati * 8) / 100;
                    lbl_KDVli.Text = kdvli_fiyat.ToString();
                }
                if (rd_Hediyelik.Checked == true)
                {
                    double kdvli_fiyat = fiyati + (fiyati * 18) / 100;
                    lbl_KDVli.Text = kdvli_fiyat.ToString();
                }
            }
            else
            {
                MessageBox.Show("Hata! İkisinden birini seçmelisiniz!");
            }
        }

        // 3. örnek
        private void btn_Yaptir_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;

            sayi1 = Convert.ToInt32(txt_Birinci.Text);
            sayi2 = Convert.ToInt32(txt_IkinciSayi.Text);

            lbl_toplami.Text = (sayi1 + sayi2).ToString();
            lbl_farki.Text = (sayi1 - sayi2).ToString();
            lbl_carpimi.Text = (sayi1 * sayi2).ToString();
            lbl_bolumu.Text = (sayi1 / sayi2).ToString();
        }
    }
}
