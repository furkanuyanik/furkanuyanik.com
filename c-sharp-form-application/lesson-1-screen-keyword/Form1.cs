﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson_1_screen_keyword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int uzunluk = textBox1.Text.Length;
            if(uzunluk != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, uzunluk - 1);
            }
        }

        private void KeyboardKey_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }
    }
}
