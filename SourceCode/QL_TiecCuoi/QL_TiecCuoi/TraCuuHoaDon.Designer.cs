namespace QL_TiecCuoi
{
    partial class TraCuuHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuHoaDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTraCuuHoaDon = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTimHoaDon = new System.Windows.Forms.TextBox();
            this.radioButtonTenKH = new System.Windows.Forms.RadioButton();
            this.buttonTim = new System.Windows.Forms.Button();
            this.radioButtonMaHD = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuuHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonXem);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTimHoaDon);
            this.panel1.Controls.Add(this.radioButtonTenKH);
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.radioButtonMaHD);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 417);
            this.panel1.TabIndex = 11;
            // 
            // buttonXem
            // 
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXem.Location = new System.Drawing.Point(455, 116);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(75, 23);
            this.buttonXem.TabIndex = 13;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewTraCuuHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(10, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // dataGridViewTraCuuHoaDon
            // 
            this.dataGridViewTraCuuHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraCuuHoaDon.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewTraCuuHoaDon.Name = "dataGridViewTraCuuHoaDon";
            this.dataGridViewTraCuuHoaDon.Size = new System.Drawing.Size(690, 189);
            this.dataGridViewTraCuuHoaDon.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(614, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(490, 384);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 10;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(253, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Hóa Đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTimHoaDon
            // 
            this.textBoxTimHoaDon.Location = new System.Drawing.Point(278, 52);
            this.textBoxTimHoaDon.Name = "textBoxTimHoaDon";
            this.textBoxTimHoaDon.Size = new System.Drawing.Size(177, 20);
            this.textBoxTimHoaDon.TabIndex = 1;
            this.textBoxTimHoaDon.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButtonTenKH
            // 
            this.radioButtonTenKH.AutoSize = true;
            this.radioButtonTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTenKH.Location = new System.Drawing.Point(259, 78);
            this.radioButtonTenKH.Name = "radioButtonTenKH";
            this.radioButtonTenKH.Size = new System.Drawing.Size(121, 20);
            this.radioButtonTenKH.TabIndex = 4;
            this.radioButtonTenKH.TabStop = true;
            this.radioButtonTenKH.Text = "Mã Khách Hàng";
            this.radioButtonTenKH.UseVisualStyleBackColor = true;
            this.radioButtonTenKH.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(579, 116);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 6;
            this.buttonTim.Text = "Tìm ";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // radioButtonMaHD
            // 
            this.radioButtonMaHD.AutoSize = true;
            this.radioButtonMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaHD.Location = new System.Drawing.Point(392, 78);
            this.radioButtonMaHD.Name = "radioButtonMaHD";
            this.radioButtonMaHD.Size = new System.Drawing.Size(126, 20);
            this.radioButtonMaHD.TabIndex = 5;
            this.radioButtonMaHD.TabStop = true;
            this.radioButtonMaHD.Text = "Tên Khách Hàng";
            this.radioButtonMaHD.UseVisualStyleBackColor = true;
            // 
            // TraCuuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 431);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TraCuuHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuuHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTimHoaDon;
        private System.Windows.Forms.RadioButton radioButtonTenKH;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.RadioButton radioButtonMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewTraCuuHoaDon;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonXem;
    }
}