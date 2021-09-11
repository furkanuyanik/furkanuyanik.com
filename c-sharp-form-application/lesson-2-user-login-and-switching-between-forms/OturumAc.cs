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
    public partial class OturumAc : Form
    {
        public OturumAc()
        {
            InitializeComponent();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            if (txt_KullaniciAdi.Text == "admin" && txt_Sifre.Text == "123" && txt_Deger.Text == lblSifre.Text)
            {
                BirinciOrnek degisken_ismi = new BirinciOrnek();
                this.Visible = false;
                degisken_ismi.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Başarılı Değil!");
            }
        }

        private void OturumAc_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            lblSifre.Text = rastgele.Next(1000, 10000).ToString();
        }
    }
}
