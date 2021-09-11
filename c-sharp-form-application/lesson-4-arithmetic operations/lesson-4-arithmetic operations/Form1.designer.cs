namespace lesson_4_arithmetic_operations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Karesi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Sayi = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KDVsiz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rd_Hediyelik = new System.Windows.Forms.RadioButton();
            this.rd_Gida = new System.Windows.Forms.RadioButton();
            this.btn_KDVBul = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_KDVli = new System.Windows.Forms.Label();
            this.txt_Birinci = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_IkinciSayi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Yaptir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_toplami = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_farki = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_carpimi = new System.Windows.Forms.Label();
            this.lbl_bolumu = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Sayi
            // 
            this.txt_Sayi.Location = new System.Drawing.Point(117, 15);
            this.txt_Sayi.Name = "txt_Sayi";
            this.txt_Sayi.Size = new System.Drawing.Size(138, 20);
            this.txt_Sayi.TabIndex = 0;
            this.txt_Sayi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bir sayı giriniz:";
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(22, 41);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(233, 23);
            this.btn_Bul.TabIndex = 2;
            this.btn_Bul.Text = "KARESİNİ BUL";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Karesi:";
            // 
            // lbl_Karesi
            // 
            this.lbl_Karesi.AutoSize = true;
            this.lbl_Karesi.Location = new System.Drawing.Point(200, 67);
            this.lbl_Karesi.Name = "lbl_Karesi";
            this.lbl_Karesi.Size = new System.Drawing.Size(13, 13);
            this.lbl_Karesi.TabIndex = 3;
            this.lbl_Karesi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sayı:";
            // 
            // lbl_Sayi
            // 
            this.lbl_Sayi.AutoSize = true;
            this.lbl_Sayi.Location = new System.Drawing.Point(88, 67);
            this.lbl_Sayi.Name = "lbl_Sayi";
            this.lbl_Sayi.Size = new System.Drawing.Size(13, 13);
            this.lbl_Sayi.TabIndex = 5;
            this.lbl_Sayi.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(359, 190);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbl_Sayi);
            this.tabPage1.Controls.Add(this.txt_Sayi);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_Bul);
            this.tabPage1.Controls.Add(this.lbl_Karesi);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 164);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Örnek";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_KDVli);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btn_KDVBul);
            this.tabPage2.Controls.Add(this.rd_Gida);
            this.tabPage2.Controls.Add(this.rd_Hediyelik);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_KDVsiz);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(351, 164);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Örnek";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_bolumu);
            this.tabPage3.Controls.Add(this.lbl_farki);
            this.tabPage3.Controls.Add(this.lbl_carpimi);
            this.tabPage3.Controls.Add(this.lbl_toplami);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.btn_Yaptir);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txt_IkinciSayi);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txt_Birinci);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(351, 164);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Örnek";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürünün KDVsiz Fiyatını Giriniz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürünün Sektörü Nedir?";
            // 
            // txt_KDVsiz
            // 
            this.txt_KDVsiz.Location = new System.Drawing.Point(175, 17);
            this.txt_KDVsiz.Name = "txt_KDVsiz";
            this.txt_KDVsiz.Size = new System.Drawing.Size(90, 20);
            this.txt_KDVsiz.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "TL";
            // 
            // rd_Hediyelik
            // 
            this.rd_Hediyelik.AutoSize = true;
            this.rd_Hediyelik.Location = new System.Drawing.Point(218, 45);
            this.rd_Hediyelik.Name = "rd_Hediyelik";
            this.rd_Hediyelik.Size = new System.Drawing.Size(123, 17);
            this.rd_Hediyelik.TabIndex = 4;
            this.rd_Hediyelik.TabStop = true;
            this.rd_Hediyelik.Text = "Hediyelik Eşya (%18)";
            this.rd_Hediyelik.UseVisualStyleBackColor = true;
            // 
            // rd_Gida
            // 
            this.rd_Gida.AutoSize = true;
            this.rd_Gida.Location = new System.Drawing.Point(144, 45);
            this.rd_Gida.Name = "rd_Gida";
            this.rd_Gida.Size = new System.Drawing.Size(70, 17);
            this.rd_Gida.TabIndex = 5;
            this.rd_Gida.TabStop = true;
            this.rd_Gida.Text = "Gıda (%8)";
            this.rd_Gida.UseVisualStyleBackColor = true;
            // 
            // btn_KDVBul
            // 
            this.btn_KDVBul.Location = new System.Drawing.Point(24, 73);
            this.btn_KDVBul.Name = "btn_KDVBul";
            this.btn_KDVBul.Size = new System.Drawing.Size(267, 23);
            this.btn_KDVBul.TabIndex = 6;
            this.btn_KDVBul.Text = "KDV\'li Fiyatını Bul";
            this.btn_KDVBul.UseVisualStyleBackColor = true;
            this.btn_KDVBul.Click += new System.EventHandler(this.btn_KDVBul_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ürünün KDV\'li Fiyatı :";
            // 
            // lbl_KDVli
            // 
            this.lbl_KDVli.AutoSize = true;
            this.lbl_KDVli.Location = new System.Drawing.Point(206, 118);
            this.lbl_KDVli.Name = "lbl_KDVli";
            this.lbl_KDVli.Size = new System.Drawing.Size(10, 13);
            this.lbl_KDVli.TabIndex = 8;
            this.lbl_KDVli.Text = "-";
            // 
            // txt_Birinci
            // 
            this.txt_Birinci.Location = new System.Drawing.Point(135, 30);
            this.txt_Birinci.Name = "txt_Birinci";
            this.txt_Birinci.Size = new System.Drawing.Size(70, 20);
            this.txt_Birinci.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Birinci Sayıyı Giriniz:";
            // 
            // txt_IkinciSayi
            // 
            this.txt_IkinciSayi.Location = new System.Drawing.Point(135, 55);
            this.txt_IkinciSayi.Name = "txt_IkinciSayi";
            this.txt_IkinciSayi.Size = new System.Drawing.Size(70, 20);
            this.txt_IkinciSayi.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "İkinci Sayıyı Giriniz:";
            // 
            // btn_Yaptir
            // 
            this.btn_Yaptir.Location = new System.Drawing.Point(61, 81);
            this.btn_Yaptir.Name = "btn_Yaptir";
            this.btn_Yaptir.Size = new System.Drawing.Size(105, 50);
            this.btn_Yaptir.TabIndex = 2;
            this.btn_Yaptir.Text = "4 Farklı İşlem Yaptır";
            this.btn_Yaptir.UseVisualStyleBackColor = true;
            this.btn_Yaptir.Click += new System.EventHandler(this.btn_Yaptir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(244, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Toplamı:";
            // 
            // lbl_toplami
            // 
            this.lbl_toplami.AutoSize = true;
            this.lbl_toplami.Location = new System.Drawing.Point(297, 46);
            this.lbl_toplami.Name = "lbl_toplami";
            this.lbl_toplami.Size = new System.Drawing.Size(10, 13);
            this.lbl_toplami.TabIndex = 3;
            this.lbl_toplami.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Farkı:";
            // 
            // lbl_farki
            // 
            this.lbl_farki.AutoSize = true;
            this.lbl_farki.Location = new System.Drawing.Point(297, 63);
            this.lbl_farki.Name = "lbl_farki";
            this.lbl_farki.Size = new System.Drawing.Size(10, 13);
            this.lbl_farki.TabIndex = 3;
            this.lbl_farki.Text = "-";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(244, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Çarpımı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(244, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Bölümü";
            // 
            // lbl_carpimi
            // 
            this.lbl_carpimi.AutoSize = true;
            this.lbl_carpimi.Location = new System.Drawing.Point(297, 81);
            this.lbl_carpimi.Name = "lbl_carpimi";
            this.lbl_carpimi.Size = new System.Drawing.Size(10, 13);
            this.lbl_carpimi.TabIndex = 3;
            this.lbl_carpimi.Text = "-";
            // 
            // lbl_bolumu
            // 
            this.lbl_bolumu.AutoSize = true;
            this.lbl_bolumu.Location = new System.Drawing.Point(297, 98);
            this.lbl_bolumu.Name = "lbl_bolumu";
            this.lbl_bolumu.Size = new System.Drawing.Size(10, 13);
            this.lbl_bolumu.TabIndex = 3;
            this.lbl_bolumu.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 191);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "yazilimindunyasi.com";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Karesi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Sayi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbl_KDVli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_KDVBul;
        private System.Windows.Forms.RadioButton rd_Gida;
        private System.Windows.Forms.RadioButton rd_Hediyelik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KDVsiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_bolumu;
        private System.Windows.Forms.Label lbl_farki;
        private System.Windows.Forms.Label lbl_carpimi;
        private System.Windows.Forms.Label lbl_toplami;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Yaptir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_IkinciSayi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Birinci;
    }
}

