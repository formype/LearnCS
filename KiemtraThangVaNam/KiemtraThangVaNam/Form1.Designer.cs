namespace KiemtraThangVaNam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.cbNamNhuan = new System.Windows.Forms.CheckBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btKiemTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(55, 13);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 2;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(55, 43);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 3;
            // 
            // cbNamNhuan
            // 
            this.cbNamNhuan.AutoSize = true;
            this.cbNamNhuan.Location = new System.Drawing.Point(16, 148);
            this.cbNamNhuan.Name = "cbNamNhuan";
            this.cbNamNhuan.Size = new System.Drawing.Size(94, 17);
            this.cbNamNhuan.TabIndex = 4;
            this.cbNamNhuan.Text = "Là năm nhuận";
            this.cbNamNhuan.UseVisualStyleBackColor = true;
            this.cbNamNhuan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(16, 188);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(463, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // btKiemTra
            // 
            this.btKiemTra.Location = new System.Drawing.Point(55, 96);
            this.btKiemTra.Name = "btKiemTra";
            this.btKiemTra.Size = new System.Drawing.Size(75, 23);
            this.btKiemTra.TabIndex = 6;
            this.btKiemTra.Text = "Kiểm tra";
            this.btKiemTra.UseVisualStyleBackColor = true;
            this.btKiemTra.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 438);
            this.Controls.Add(this.btKiemTra);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.cbNamNhuan);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.CheckBox cbNamNhuan;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btKiemTra;
    }
}

