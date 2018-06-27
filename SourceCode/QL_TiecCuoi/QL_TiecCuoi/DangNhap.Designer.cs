namespace QL_TiecCuoi
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelDangNhap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonDangNhap);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.labelDangNhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxMatKhau);
            this.panel1.Controls.Add(this.textBoxTenDangNhap);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 192);
            this.panel1.TabIndex = 0;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(250, 145);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(86, 27);
            this.buttonDangNhap.TabIndex = 9;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(147, 145);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(86, 27);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDangNhap
            // 
            this.labelDangNhap.AutoSize = true;
            this.labelDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelDangNhap.Location = new System.Drawing.Point(110, 16);
            this.labelDangNhap.Name = "labelDangNhap";
            this.labelDangNhap.Size = new System.Drawing.Size(134, 29);
            this.labelDangNhap.TabIndex = 7;
            this.labelDangNhap.Text = "Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.AcceptsReturn = true;
            this.textBoxMatKhau.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMatKhau.Location = new System.Drawing.Point(126, 100);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(209, 22);
            this.textBoxMatKhau.TabIndex = 3;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            this.textBoxMatKhau.UseWaitCursor = true;
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(126, 63);
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(209, 22);
            this.textBoxTenDangNhap.TabIndex = 0;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 194);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonThoat;
    }
}

