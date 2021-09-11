using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_2_user_login_and_switching_between_forms
{
    public partial class BirinciOrnek : Form
    {
        public BirinciOrnek()
        {
            InitializeComponent();
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_BirinciSayi.Text);
            int sayi2 = Convert.ToInt32(txt_IkinciSayi.Text);
            int sayi3 = Convert.ToInt32(txt_UcuncuSayi.Text);

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                MessageBox.Show("En Büyük Sayı " + sayi1);
            }
            if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                MessageBox.Show("En Büyük Sayı " + sayi2);
            }
            if (sayi3 > sayi1 && sayi3 > sayi2)
            {
                MessageBox.Show("En Büyük Sayı " + sayi3);
            }

            if (sayi1 < sayi2 && sayi1 < sayi3)
            {
                MessageBox.Show("En Küçük Sayı " + sayi1);
            }
            if (sayi2 < sayi1 && sayi2 < sayi3)
            {
                MessageBox.Show("En Küçük Sayı " + sayi2);
            }
            if (sayi3 < sayi1 && sayi3 < sayi2)
            {
                MessageBox.Show("En Küçük Sayı " + sayi3);
            }
        }

        private void btn_IkinciOrnek_Click(object sender, EventArgs e)
        {
            IkinciOrnek frm = new IkinciOrnek();
            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
