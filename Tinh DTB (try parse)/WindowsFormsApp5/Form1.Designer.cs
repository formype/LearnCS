namespace WindowsFormsApp5
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
            this.Toán = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToan = new System.Windows.Forms.TextBox();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtHoa = new System.Windows.Forms.TextBox();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.txtDtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btTinh = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Toán
            // 
            this.Toán.AutoSize = true;
            this.Toán.Location = new System.Drawing.Point(41, 35);
            this.Toán.Name = "Toán";
            this.Toán.Size = new System.Drawing.Size(32, 13);
            this.Toán.TabIndex = 0;
            this.Toán.Text = "Toán";
            this.Toán.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lý";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hóa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtToan
            // 
            this.txtToan.Location = new System.Drawing.Point(82, 32);
            this.txtToan.Name = "txtToan";
            this.txtToan.Size = new System.Drawing.Size(100, 20);
            this.txtToan.TabIndex = 3;
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(82, 65);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(100, 20);
            this.txtLy.TabIndex = 4;
            this.txtLy.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtHoa
            // 
            this.txtHoa.Location = new System.Drawing.Point(82, 99);
            this.txtHoa.Name = "txtHoa";
            this.txtHoa.Size = new System.Drawing.Size(100, 20);
            this.txtHoa.TabIndex = 5;
            this.txtHoa.TextChanged += new System.EventHandler(this.txtHoa_TextChanged);
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(128, 226);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(100, 20);
            this.txtXepLoai.TabIndex = 9;
            this.txtXepLoai.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDtb
            // 
            this.txtDtb.Location = new System.Drawing.Point(128, 193);
            this.txtDtb.Name = "txtDtb";
            this.txtDtb.Size = new System.Drawing.Size(100, 20);
            this.txtDtb.TabIndex = 8;
            this.txtDtb.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xếp loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điểm trung bình";
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(44, 143);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(75, 23);
            this.btTinh.TabIndex = 10;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(174, 143);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 11;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 391);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.txtDtb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoa);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.txtToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Toán);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Toán;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToan;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.TextBox txtHoa;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.TextBox txtDtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Button btXoa;
    }
}

