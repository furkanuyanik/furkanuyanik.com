namespace lesson_1_introduction_and_components
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
            this.gb_sayilari_topla = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_listeye_yazi_ekle = new System.Windows.Forms.GroupBox();
            this.lbl_yazi = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.listTextList = new System.Windows.Forms.ListBox();
            this.gb_sayilari_topla.SuspendLayout();
            this.gb_listeye_yazi_ekle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sayilari_topla
            // 
            this.gb_sayilari_topla.Controls.Add(this.lblResult);
            this.gb_sayilari_topla.Controls.Add(this.label3);
            this.gb_sayilari_topla.Controls.Add(this.btnSum);
            this.gb_sayilari_topla.Controls.Add(this.txtSecondNumber);
            this.gb_sayilari_topla.Controls.Add(this.txtFirstNumber);
            this.gb_sayilari_topla.Controls.Add(this.label2);
            this.gb_sayilari_topla.Controls.Add(this.label1);
            this.gb_sayilari_topla.Location = new System.Drawing.Point(12, 12);
            this.gb_sayilari_topla.Name = "gb_sayilari_topla";
            this.gb_sayilari_topla.Size = new System.Drawing.Size(483, 103);
            this.gb_sayilari_topla.TabIndex = 1;
            this.gb_sayilari_topla.TabStop = false;
            this.gb_sayilari_topla.Text = "Sayıları Topla";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(402, 48);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(10, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sonuç";
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(232, 32);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(74, 44);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "TOPLA";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Location = new System.Drawing.Point(111, 56);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSecondNumber.TabIndex = 3;
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(111, 32);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNumber.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İkinci Sayı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birinci Sayı:";
            // 
            // gb_listeye_yazi_ekle
            // 
            this.gb_listeye_yazi_ekle.Controls.Add(this.lbl_yazi);
            this.gb_listeye_yazi_ekle.Controls.Add(this.btnAdd);
            this.gb_listeye_yazi_ekle.Controls.Add(this.txtText);
            this.gb_listeye_yazi_ekle.Controls.Add(this.listTextList);
            this.gb_listeye_yazi_ekle.Location = new System.Drawing.Point(12, 121);
            this.gb_listeye_yazi_ekle.Name = "gb_listeye_yazi_ekle";
            this.gb_listeye_yazi_ekle.Size = new System.Drawing.Size(483, 167);
            this.gb_listeye_yazi_ekle.TabIndex = 8;
            this.gb_listeye_yazi_ekle.TabStop = false;
            this.gb_listeye_yazi_ekle.Text = "Listeye Yazı Ekle";
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.AutoSize = true;
            this.lbl_yazi.Location = new System.Drawing.Point(28, 29);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(30, 13);
            this.lbl_yazi.TabIndex = 4;
            this.lbl_yazi.Text = "Yazı:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(334, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(64, 26);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(264, 20);
            this.txtText.TabIndex = 1;
            // 
            // listTextList
            // 
            this.listTextList.FormattingEnabled = true;
            this.listTextList.Location = new System.Drawing.Point(31, 54);
            this.listTextList.Name = "listTextList";
            this.listTextList.Size = new System.Drawing.Size(417, 95);
            this.listTextList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 298);
            this.Controls.Add(this.gb_listeye_yazi_ekle);
            this.Controls.Add(this.gb_sayilari_topla);
            this.Name = "Form1";
            this.Text = "C# Ders 1: Form Ekranı ve Form Elemanları - 1";
            this.gb_sayilari_topla.ResumeLayout(false);
            this.gb_sayilari_topla.PerformLayout();
            this.gb_listeye_yazi_ekle.ResumeLayout(false);
            this.gb_listeye_yazi_ekle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sayilari_topla;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_listeye_yazi_ekle;
        private System.Windows.Forms.Label lbl_yazi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.ListBox listTextList;
    }
}

