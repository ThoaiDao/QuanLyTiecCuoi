namespace QL_TiecCuoi
{
    partial class LapBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapBaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxThang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDoanhThu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayLap = new System.Windows.Forms.DateTimePicker();
            this.textBoxSoLuongTiec = new System.Windows.Forms.TextBox();
            this.textBoxTenNguoiLap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(283, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Báo Cáo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxThang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDoanhThu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePickerNgayLap);
            this.groupBox1.Controls.Add(this.textBoxSoLuongTiec);
            this.groupBox1.Controls.Add(this.textBoxTenNguoiLap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // textBoxThang
            // 
            this.textBoxThang.Location = new System.Drawing.Point(154, 104);
            this.textBoxThang.Name = "textBoxThang";
            this.textBoxThang.Size = new System.Drawing.Size(191, 22);
            this.textBoxThang.TabIndex = 15;
            this.textBoxThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxThang_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(26, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tháng";
            // 
            // textBoxDoanhThu
            // 
            this.textBoxDoanhThu.Location = new System.Drawing.Point(475, 66);
            this.textBoxDoanhThu.Name = "textBoxDoanhThu";
            this.textBoxDoanhThu.Size = new System.Drawing.Size(191, 22);
            this.textBoxDoanhThu.TabIndex = 13;
            this.textBoxDoanhThu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoanhThu_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(368, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doanh thu";
            // 
            // dateTimePickerNgayLap
            // 
            this.dateTimePickerNgayLap.Location = new System.Drawing.Point(154, 21);
            this.dateTimePickerNgayLap.Name = "dateTimePickerNgayLap";
            this.dateTimePickerNgayLap.Size = new System.Drawing.Size(191, 22);
            this.dateTimePickerNgayLap.TabIndex = 12;
            // 
            // textBoxSoLuongTiec
            // 
            this.textBoxSoLuongTiec.Location = new System.Drawing.Point(475, 26);
            this.textBoxSoLuongTiec.Name = "textBoxSoLuongTiec";
            this.textBoxSoLuongTiec.Size = new System.Drawing.Size(191, 22);
            this.textBoxSoLuongTiec.TabIndex = 11;
            this.textBoxSoLuongTiec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSoLuongTiec_KeyPress);
            // 
            // textBoxTenNguoiLap
            // 
            this.textBoxTenNguoiLap.AutoCompleteCustomSource.AddRange(new string[] {
            "Dương",
            "Phạm",
            "Trần",
            "Nguyễn",
            "Lê",
            "Trịnh",
            "Phan",
            "Vũ",
            "Võ",
            "Đặng",
            "Bùi",
            "Đỗ",
            "Hồ",
            "Ngô",
            "Đoàn",
            "Thân",
            "Trương",
            "Quách",
            "Bạch",
            "Lý",
            "Đào",
            "Hà",
            "Hoàng",
            "Huynh",
            "Hồ"});
            this.textBoxTenNguoiLap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxTenNguoiLap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTenNguoiLap.Location = new System.Drawing.Point(154, 62);
            this.textBoxTenNguoiLap.Name = "textBoxTenNguoiLap";
            this.textBoxTenNguoiLap.Size = new System.Drawing.Size(191, 22);
            this.textBoxTenNguoiLap.TabIndex = 9;
            this.textBoxTenNguoiLap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTenNguoiLap_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(368, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng tiệc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(26, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(26, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên người lập";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // LapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 280);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LapBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaoCao";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenNguoiLap;
        private System.Windows.Forms.TextBox textBoxSoLuongTiec;
        private System.Windows.Forms.TextBox textBoxThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}