using QL_TiecCuoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TiecCuoi
{
    public partial class TraCuuNhanVien : Form
    {
        public TraCuuNhanVien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valueFilter = textBoxTraCuuNhanVien.Text.ToString().Trim();
            string fieldFilter = "MaNhanVien";
            if (radioButtonTenNV.Checked)
            {
               
                fieldFilter = "TenNhanVien";
            }
            else if (radioButtonSDT.Checked)
           {
                fieldFilter = "SoDienThoai";
            }
            string query = "select * from NhanVien where " + fieldFilter + " like '%" + valueFilter + "%'";
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuNV.DataSource = provider.ExecuteQuery(query);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "select *  from NhanVien ";
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuNV.DataSource = provider.ExecuteQuery(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuNV.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr1 = "Delete from NhanVien where id='" + a + "'";
                provider.ExecuteDelete(deletedStr1);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "select * from NhanVien";
                dataGridViewTraCuuNV.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuNV.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[0].Value.ToString());
                string maNhanVien = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[1].Value.ToString());
                string tenNhanVien  = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[2].Value.ToString());
                string soDienThoai = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[3].Value.ToString());
                string diaChi = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[4].Value.ToString());
                string loaiSanh = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[5].Value.ToString());
                string chucVu = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[6].Value.ToString());
                string ca = Convert.ToString(dataGridViewTraCuuNV.Rows[CurrentIndex].Cells[7].Value.ToString());
               
                string updateStr = "Update NhanVien set TenNhanVien='" 
                    + tenNhanVien + "',SoDienThoai='"
                    + soDienThoai + "',DiaChi='" 
                    + diaChi + "', LoaiSanh ='"
                    + loaiSanh +"', ChucVu='"
                    +chucVu+"',Ca='"+ ca +"' where id = '" 
                    + id + "'";
                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);

                //string query = "select * from NhanVien";
               // dataGridViewTraCuuNV.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }
    }
}
