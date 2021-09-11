namespace lesson_3_for_loop_and_switch_case
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Faktoriyel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Cevap = new System.Windows.Forms.Label();
            this.btn_GecisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_Faktoriyel
            // 
            this.btn_Faktoriyel.Location = new System.Drawing.Point(156, 26);
            this.btn_Faktoriyel.Name = "btn_Faktoriyel";
            this.btn_Faktoriyel.Size = new System.Drawing.Size(104, 23);
            this.btn_Faktoriyel.TabIndex = 1;
            this.btn_Faktoriyel.Text = "Faktöriyelini Bul";
            this.btn_Faktoriyel.UseVisualStyleBackColor = true;
            this.btn_Faktoriyel.Click += new System.EventHandler(this.btn_Faktoriyel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faktöriyel : ";
            // 
            // lbl_Cevap
            // 
            this.lbl_Cevap.AutoSize = true;
            this.lbl_Cevap.Location = new System.Drawing.Point(153, 76);
            this.lbl_Cevap.Name = "lbl_Cevap";
            this.lbl_Cevap.Size = new System.Drawing.Size(10, 13);
            this.lbl_Cevap.TabIndex = 2;
            this.lbl_Cevap.Text = "-";
            // 
            // btn_GecisYap
            // 
            this.btn_GecisYap.Location = new System.Drawing.Point(230, 162);
            this.btn_GecisYap.Name = "btn_GecisYap";
            this.btn_GecisYap.Size = new System.Drawing.Size(54, 23);
            this.btn_GecisYap.TabIndex = 3;
            this.btn_GecisYap.Text = ">>";
            this.btn_GecisYap.UseVisualStyleBackColor = true;
            this.btn_GecisYap.Click += new System.EventHandler(this.btn_GecisYap_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.btn_GecisYap);
            this.Controls.Add(this.lbl_Cevap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Faktoriyel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "furkanuyanik.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Faktoriyel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Cevap;
        private System.Windows.Forms.Button btn_GecisYap;
    }
}