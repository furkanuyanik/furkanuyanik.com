namespace lesson_3_for_loop_and_switch_case
{
    partial class Form4
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
            this.lbl_Ay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Sayi
            // 
            this.txt_Sayi.Location = new System.Drawing.Point(156, 23);
            this.txt_Sayi.MaxLength = 2;
            this.txt_Sayi.Name = "txt_Sayi";
            this.txt_Sayi.Size = new System.Drawing.Size(100, 20);
            this.txt_Sayi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İki basamaklı bir sayı giriniz:";
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(15, 55);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(241, 23);
            this.btn_Bul.TabIndex = 2;
            this.btn_Bul.Text = "BUL";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazı ile:";
            // 
            // lbl_Ay
            // 
            this.lbl_Ay.AutoSize = true;
            this.lbl_Ay.Location = new System.Drawing.Point(140, 127);
            this.lbl_Ay.Name = "lbl_Ay";
            this.lbl_Ay.Size = new System.Drawing.Size(10, 13);
            this.lbl_Ay.TabIndex = 4;
            this.lbl_Ay.Text = "-";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.lbl_Ay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Sayi);
            this.Name = "Form4";
            this.Text = "furkanuyanik.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Sayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Ay;
    }
}