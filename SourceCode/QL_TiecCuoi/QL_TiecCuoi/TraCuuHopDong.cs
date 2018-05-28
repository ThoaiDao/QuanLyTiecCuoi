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
    public partial class TraCuuHopDong : Form
    {
        public TraCuuHopDong()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string valueFilter = textBoxHopDong.Text.ToString().Trim();
            string fieldFilter = "ThongTinKhachHang.MaKhachHang";
            if (radioButtonMaDatTiec.Checked)
            {
                fieldFilter = "MaKhachHang";
            }
            string query1 = "select *  from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id where " + fieldFilter + " like '%" + valueFilter + "%'";
            Console.Write(query1);
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuHopDong.DataSource = provider.ExecuteQuery(query1);
      
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuHopDong.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr1 = "Delete from ThongTinDatTiec where id='" + a + "'";
                provider.ExecuteDelete(deletedStr1);
                string deletedStr2 = "Delete from ThongTinKhachHang where id='" + a + "'";
                Console.Write(deletedStr1);
                Console.Write(deletedStr1);
                provider.ExecuteDelete(deletedStr2);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "select *  from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id";
                dataGridViewTraCuuHopDong.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuHopDong.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[0].Value.ToString().Trim());
                string makhachhang = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[1].Value.ToString().Trim());
                string ngaylap = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[2].Value.ToString().Trim());
                string tenkhachhang = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[3].Value.ToString().Trim());
                string tenchure = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[4].Value.ToString().Trim());
                string tencodau = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[5].Value.ToString().Trim());
                string diachi = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[6].Value.ToString().Trim());
                string dienthoai = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[7].Value.ToString().Trim());
                string email = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[8].Value.ToString().Trim());
                string ngaytochuc = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[9].Value.ToString().Trim());
                string tiencoc = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[10].Value.ToString().Trim());

                string ID = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[11].Value.ToString().Trim());
                string madattiec = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[12].Value.ToString().Trim().Trim());
                string loaisanh = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[13].Value.ToString().Trim());
                string madichvu = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[14].Value.ToString().Trim());
                string mathucdon = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[15].Value.ToString().Trim());  
                string soluongnhanvien = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[16].Value.ToString().Trim());
                string soluongban = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[17].Value.ToString().Trim());
                string trangthai = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[18].Value.ToString().Trim());
                string ca = Convert.ToString(dataGridViewTraCuuHopDong.Rows[CurrentIndex].Cells[19].Value.ToString().Trim());
               

                string updateStr1 = "Update ThongTinKhachHang set NgayLap='"
                   + ngaylap + "',TenKhachHang='"
                   + tenkhachhang + "',TenChuRe='"
                   + tenchure + "', TenCoDau='"
                   + tencodau + "', DiaChi='"
                   + diachi + "',DienThoai='"
                   + dienthoai + "', Email='"
                   + email + "', NgayToChuc='"
                   + ngaytochuc + "', TienCoc='"
                   + tiencoc+"'where id = '" + id + "'";
                provider.ExecuteUpdate(updateStr1);

                string updateStr2 = "Update ThongTinDatTiec set LoaiSanh='"
                   + loaisanh + "',MaDichVu='"
                   + madichvu + "', MaThucDon='"
                   + mathucdon + "', SoLuongNhanVien='"
                   + soluongnhanvien + "',SoLuongBan='"
                   + soluongban + "', TrangThai='"
                   + trangthai + "', Ca='"
                   + ca +"' where id = '" + ID + "'";
                //Console.WriteLine(updateStr2);
                provider.ExecuteUpdate(updateStr2);
                string query = "select *  from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id";
                dataGridViewTraCuuHopDong.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                MessageBox.Show("Lỗi, không sửa được");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "select *  from ThongTinkhachHang inner join ThongTinDatTiec on ThongTinKhachHang.id = ThongTinDatTiec.id";
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuHopDong.DataSource = provider.ExecuteQuery(query);
        }

        private void radioButtonMaKH_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
