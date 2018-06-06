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
                int CurrentIndex = dataGridViewTraCuuHoaDon.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewTraCuuHoaDon.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr1 = "Delete from ThongTinDatTiec where ThongTinDatTiec.id='" + a + "'";
                provider.ExecuteDelete(deletedStr1);
                string deletedStr2 = "Delete from ThongTinKhachHang where ThongTinKhachHang.id='" + a + "'";
                Console.Write(deletedStr1);
                Console.Write(deletedStr1);
                provider.ExecuteDelete(deletedStr2);
                string deletedStr3 = "Delete from HoaDon where HoaDon.id='" + a + "'";
                provider.ExecuteDelete(deletedStr3);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                /*string query = @"Select h.id, h.MaHoaDon,t.MaDatTiec,p.MaKhachhang, p.TenKhachHang, s.DonGiaToiThieu as TienSanh, dv.GiaDichVu, td.GiaThucDon, h.TienPhat, h.TienCoc, h.TongTienHoaDon ,h.TienConLai
              from HoaDon h left join ThongTinKhachHang p on p.id = h.IDThongTinKhachHang
              left join ThongTinDatTiec t on t.id = h.IdMaDatTiec
              left join ThongTinSanh s on s.id = h.IdLoaiSanh
              left join DichVu dv on dv.id = h.IdDichVu
              left join ThucDon td on td.id = h.IdThucDon";
                dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(query);*/
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
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
            if (radioButtonMaHD.Checked)
            {
                fieldFilter = "TenKhachHang";
            }

            string query1 = @"Select h.id, h.MaHoaDon,t.MaDatTiec,p.MaKhachhang, p.TenKhachHang, s.DonGiaToiThieu as TienSanh, dv.GiaDichVu, td.GiaThucDon, h.TienPhat, h.TienCoc, h.TongTienHoaDon ,h.TienConLai
              from HoaDon h
              left join ThongTinKhachHang p on p.id = h.IDThongTinKhachHang
              left join ThongTinDatTiec t on t.id = h.IdMaDatTiec
              left join ThongTinSanh s on s.id = h.IdLoaiSanh
              left join DichVu dv on dv.id = h.IdDichVu
              left join ThucDon td on td.id = h.IdThucDon where " + fieldFilter + " like '%" + valueFilter + "%'";
            Console.Write(query1);
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(query1);

        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            string query = @"Select h.id, h.MaHoaDon,t.MaDatTiec,p.MaKhachhang, p.TenKhachHang, s.DonGiaToiThieu as TienSanh, dv.GiaDichVu, td.GiaThucDon, h.TienPhat, h.TienCoc, h.TongTienHoaDon ,h.TienConLai
              from HoaDon h
              left join ThongTinKhachHang p on p.id = h.IDThongTinKhachHang
              left join ThongTinDatTiec t on t.id = h.IdMaDatTiec
              left join ThongTinSanh s on s.id = h.IdLoaiSanh
              left join DichVu dv on dv.id = h.IdDichVu
              left join ThucDon td on td.id = h.IdThucDon";
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(query);

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }
    }
}
