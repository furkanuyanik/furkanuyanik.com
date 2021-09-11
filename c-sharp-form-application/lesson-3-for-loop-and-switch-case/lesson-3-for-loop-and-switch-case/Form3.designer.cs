namespace lesson_3_for_loop_and_switch_case
{
    partial class Form3
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
            this.btn_Bul = new System.Windows.Forms.Button();
            this.txt_Sayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_BolunmeSayisi = new System.Windows.Forms.Label();
            this.lbl_Kalani = new System.Windows.Forms.Label();
            this.txt_Bolen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GecisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(28, 94);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(234, 23);
            this.btn_Bul.TabIndex = 0;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // txt_Sayi
            // 
            this.txt_Sayi.Location = new System.Drawing.Point(162, 41);
            this.txt_Sayi.Name = "txt_Sayi";
            this.txt_Sayi.Size = new System.Drawing.Size(100, 20);
            this.txt_Sayi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kaç defa çıkarıldı?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kalanı?";
            // 
            // lbl_BolunmeSayisi
            // 
            this.lbl_BolunmeSayisi.AutoSize = true;
            this.lbl_BolunmeSayisi.Location = new System.Drawing.Point(178, 150);
            this.lbl_BolunmeSayisi.Name = "lbl_BolunmeSayisi";
            this.lbl_BolunmeSayisi.Size = new System.Drawing.Size(10, 13);
            this.lbl_BolunmeSayisi.TabIndex = 2;
            this.lbl_BolunmeSayisi.Text = "-";
            // 
            // lbl_Kalani
            // 
            this.lbl_Kalani.AutoSize = true;
            this.lbl_Kalani.Location = new System.Drawing.Point(178, 174);
            this.lbl_Kalani.Name = "lbl_Kalani";
            this.lbl_Kalani.Size = new System.Drawing.Size(10, 13);
            this.lbl_Kalani.TabIndex = 3;
            this.lbl_Kalani.Text = "-";
            // 
            // txt_Bolen
            // 
            this.txt_Bolen.Location = new System.Drawing.Point(162, 67);
            this.txt_Bolen.Name = "txt_Bolen";
            this.txt_Bolen.Size = new System.Drawing.Size(100, 20);
            this.txt_Bolen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hangi Sayı Çıkarılacak?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hangi Sayıya Çıkarılacak?";
            // 
            // btn_GecisYap
            // 
            this.btn_GecisYap.Location = new System.Drawing.Point(241, 238);
            this.btn_GecisYap.Name = "btn_GecisYap";
            this.btn_GecisYap.Size = new System.Drawing.Size(43, 23);
            this.btn_GecisYap.TabIndex = 6;
            this.btn_GecisYap.Text = ">>";
            this.btn_GecisYap.UseVisualStyleBackColor = true;
            this.btn_GecisYap.Click += new System.EventHandler(this.btn_GecisYap_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_GecisYap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Kalani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_BolunmeSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Bolen);
            this.Controls.Add(this.txt_Sayi);
            this.Controls.Add(this.btn_Bul);
            this.Name = "Form3";
            this.Text = "furkanuyanik.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.TextBox txt_Sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_BolunmeSayisi;
        private System.Windows.Forms.Label lbl_Kalani;
        private System.Windows.Forms.TextBox txt_Bolen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GecisYap;
    }
}