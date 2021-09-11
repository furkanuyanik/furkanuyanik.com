namespace lesson_3_for_loop_and_switch_case
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Yazdir = new System.Windows.Forms.Button();
            this.btn_GecisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(76, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Yazdir
            // 
            this.btn_Yazdir.Location = new System.Drawing.Point(101, 113);
            this.btn_Yazdir.Name = "btn_Yazdir";
            this.btn_Yazdir.Size = new System.Drawing.Size(75, 23);
            this.btn_Yazdir.TabIndex = 1;
            this.btn_Yazdir.Text = "Yazdır";
            this.btn_Yazdir.UseVisualStyleBackColor = true;
            this.btn_Yazdir.Click += new System.EventHandler(this.btn_Yazdir_Click);
            // 
            // btn_GecisYap
            // 
            this.btn_GecisYap.Location = new System.Drawing.Point(229, 131);
            this.btn_GecisYap.Name = "btn_GecisYap";
            this.btn_GecisYap.Size = new System.Drawing.Size(54, 23);
            this.btn_GecisYap.TabIndex = 1;
            this.btn_GecisYap.Text = ">>";
            this.btn_GecisYap.UseVisualStyleBackColor = true;
            this.btn_GecisYap.Click += new System.EventHandler(this.btn_GecisYap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.btn_GecisYap);
            this.Controls.Add(this.btn_Yazdir);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "furkanuyanik.com";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Yazdir;
        private System.Windows.Forms.Button btn_GecisYap;
    }
}

