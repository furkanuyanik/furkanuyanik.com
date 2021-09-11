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
    public partial class IkinciOrnek : Form
    {
        public IkinciOrnek()
        {
            InitializeComponent();
        }

        int bjk = 0, gs = 0, fb = 0, ts = 0, toplam = 0;
        private void btn_Besiktas_Click(object sender, EventArgs e)
        {
            bjk++;
            toplam++;

            prog_BJK.Value = (bjk * 100) / toplam;
            prog_GS.Value = (gs * 100) / toplam;
            prog_FB.Value = (fb * 100) / toplam;
            prog_TS.Value = (ts * 100) / toplam;
        }

        private void btn_Galatasaray_Click(object sender, EventArgs e)
        {
            gs++;
            toplam++;

            prog_BJK.Value = (bjk * 100) / toplam;
            prog_GS.Value = (gs * 100) / toplam;
            prog_FB.Value = (fb * 100) / toplam;
            prog_TS.Value = (ts * 100) / toplam;
        }

        private void btn_Fenerbahce_Click(object sender, EventArgs e)
        {
            fb++;
            toplam++;

            prog_BJK.Value = (bjk * 100) / toplam;
            prog_GS.Value = (gs * 100) / toplam;
            prog_FB.Value = (fb * 100) / toplam;
            prog_TS.Value = (ts * 100) / toplam;
        }

        private void btn_Trabzonspor_Click(object sender, EventArgs e)
        {
            ts++;
            toplam++;

            prog_BJK.Value = (bjk * 100) / toplam;
            prog_GS.Value = (gs * 100) / toplam;
            prog_FB.Value = (fb * 100) / toplam;
            prog_TS.Value = (ts * 100) / toplam;
        }
    }
}
