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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            int onlar = Convert.ToInt32(txt_Sayi.Text.Substring(0, 1));
            int birler = Convert.ToInt32(txt_Sayi.Text.Substring(1, 1));

                switch (onlar)
                {
                    case 1: lbl_Ay.Text = "On"; break;
                    case 2: lbl_Ay.Text = "Yirmi"; break;
                    case 3: lbl_Ay.Text = "Otuz"; break;
                    case 4: lbl_Ay.Text = "Kırk"; break;
                    case 5: lbl_Ay.Text = "Elli"; break;
                    case 6: lbl_Ay.Text = "Altmış"; break;
                    case 7: lbl_Ay.Text = "Yetmiş"; break;
                    case 8: lbl_Ay.Text = "Seksen"; break;
                    case 9: lbl_Ay.Text = "Doksan"; break;
                }

                switch (birler)
                {
                    case 1: lbl_Ay.Text += " Bir"; break;
                    case 2: lbl_Ay.Text += " İki"; break;
                    case 3: lbl_Ay.Text += " Üç"; break;
                    case 4: lbl_Ay.Text += " Dört"; break;
                    case 5: lbl_Ay.Text += " Beş"; break;
                    case 6: lbl_Ay.Text += " Altı"; break;
                    case 7: lbl_Ay.Text += " Yedi"; break;
                    case 8: lbl_Ay.Text += " Sekiz"; break;
                    case 9: lbl_Ay.Text += " Dokuz"; break;
                }
            }
        }
    }