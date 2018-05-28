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
    public partial class TraCuuHoaDon : Form
    {
        public TraCuuHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDSHoaDon.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from HoaDon where LoaiSanh='" + a + "'";
                provider.ExecuteDelete(deletedStr);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "select * from HoaDon";
                dataGridViewDSHoaDon.DataSource = provider.ExecuteQuery(query);
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
                int CurrentIndex = dataGridViewDSHoaDon.CurrentCell.RowIndex;
                string maHoaDon = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[0].Value.ToString());
                string maKhachHang = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[1].Value.ToString());
                string maDatTiec = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[2].Value.ToString());
                string thucDon = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[3].Value.ToString());
                string dichVu = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[4].Value.ToString());
                string tienThucDon = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[5].Value.ToString());
                string tienDichVu = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[6].Value.ToString());
                string tienPhat = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[7].Value.ToString());
                string tongTienHoaDon = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[8].Value.ToString());
                string tienCoc = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[9].Value.ToString());
                string tienConLai = Convert.ToString(dataGridViewDSHoaDon.Rows[CurrentIndex].Cells[10].Value.ToString());


                string updateStr = "Update HoaDon set MaHoaDon='"+ maHoaDon+"', MaKhachHang='" 
                    + maKhachHang + "',MaDatTiec='" 
                    + maDatTiec + "',ThucDon='" 
                    + thucDon + "',GhiChu='"
                    + dichVu + "',DichVu = '"
                    + tienThucDon + "', TienThucDon='"
                    + tienDichVu + "', TienDichVu='"
                    + tienPhat + "',TongTienHoaDon='"
                    + tongTienHoaDon + "',TienCoc='"
                    + tienCoc + "',TienConLai='"
                    + tienConLai + "'";

                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);
                
                string query = "select * from HoaDon";
                dataGridViewDSHoaDon.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string valueFilter = textBoxTimHoaDon.Text.ToString().Trim();
            string fieldFilter = "MaKhachHang";
            if (radioButtonMaHD.Checked) {
                fieldFilter = "MaHoaDon";
            }
            string query = "select * from HoaDon where " + fieldFilter + " like '%" + valueFilter + "%'";
            DataProvider provider = new DataProvider();
            dataGridViewDSHoaDon.DataSource = provider.ExecuteQuery(query);

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = "select *  from ThongTinkhachHang inner join ThongTinDatTiec1 on ThongTinKhachHang.MaKhachHang = ThongTinDatTiec1.MaKhachHang";
            DataProvider provider = new DataProvider();
            dataGridViewDSHoaDon.DataSource = provider.ExecuteQuery(query);
        }
    }
}
