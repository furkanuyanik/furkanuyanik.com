namespace lesson_2_user_login_and_switching_between_forms
{
    partial class BirinciOrnek
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
            this.btn_IkinciOrnek = new System.Windows.Forms.Button();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BirinciSayi = new System.Windows.Forms.TextBox();
            this.txt_IkinciSayi = new System.Windows.Forms.TextBox();
            this.txt_UcuncuSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_IkinciOrnek
            // 
            this.btn_IkinciOrnek.Location = new System.Drawing.Point(51, 149);
            this.btn_IkinciOrnek.Name = "btn_IkinciOrnek";
            this.btn_IkinciOrnek.Size = new System.Drawing.Size(177, 23);
            this.btn_IkinciOrnek.TabIndex = 15;
            this.btn_IkinciOrnek.Text = "İkinci örneğe geç";
            this.btn_IkinciOrnek.UseVisualStyleBackColor = true;
            this.btn_IkinciOrnek.Click += new System.EventHandler(this.btn_IkinciOrnek_Click);
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(51, 120);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(177, 23);
            this.btn_Bul.TabIndex = 14;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Üçüncü Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "İkinci Sayı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Birinci Sayı";
            // 
            // txt_BirinciSayi
            // 
            this.txt_BirinciSayi.Location = new System.Drawing.Point(128, 30);
            this.txt_BirinciSayi.Name = "txt_BirinciSayi";
            this.txt_BirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txt_BirinciSayi.TabIndex = 10;
            // 
            // txt_IkinciSayi
            // 
            this.txt_IkinciSayi.Location = new System.Drawing.Point(128, 55);
            this.txt_IkinciSayi.Name = "txt_IkinciSayi";
            this.txt_IkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txt_IkinciSayi.TabIndex = 9;
            // 
            // txt_UcuncuSayi
            // 
            this.txt_UcuncuSayi.Location = new System.Drawing.Point(128, 81);
            this.txt_UcuncuSayi.Name = "txt_UcuncuSayi";
            this.txt_UcuncuSayi.Size = new System.Drawing.Size(100, 20);
            this.txt_UcuncuSayi.TabIndex = 8;
            // 
            // BirinciOrnek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 225);
            this.Controls.Add(this.btn_IkinciOrnek);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_BirinciSayi);
            this.Controls.Add(this.txt_IkinciSayi);
            this.Controls.Add(this.txt_UcuncuSayi);
            this.Name = "BirinciOrnek";
            this.Text = "Küçük Büyük Sayıyı Bul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IkinciOrnek;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BirinciSayi;
        private System.Windows.Forms.TextBox txt_IkinciSayi;
        private System.Windows.Forms.TextBox txt_UcuncuSayi;
    }
}