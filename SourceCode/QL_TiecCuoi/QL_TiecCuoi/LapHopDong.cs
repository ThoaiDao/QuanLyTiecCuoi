using QL_TiecCuoi.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_TiecCuoi
{
    public partial class LapHopDong : Form
    {
        public LapHopDong()
        {
            InitializeComponent();
            Show_ComboboxTenNhanVien();
          
            Show_ComboboxLoaiSanh();
            Show_ComboboxCa();
            Show_ComboboxThucDon();
            Show_ComboboxDichVu();
            Show_ComboboxTrangThai();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            
                this.Hide();
                Form frm = new Menu();
                frm.ShowDialog();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn đã tính tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Hide();
                Form frm = new LapHopDong();
                frm.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Form frm = new LapHopDong();
                frm.ShowDialog();
         
        }
       
      
        private void button3_Click(object sender, EventArgs e)
        {
           // if(textBoxMaKhachHang.Text != "" && textBoxTenChuRe.Text !="")
            try
                {
                   
                    DataProvider provider = new DataProvider();
                    string formatDate = "MM/dd/yyyy";
                    string query1 = "Insert into ThongTinKhachHang ( NgayLap, TenKhachHang, TenChuRe, TenCoDau, DiaChi, DienThoai,EMail, NgayToChuc, TienCoc) Values('" 
                        //+ textBoxMaKhachHang.Text = KH.TangMaKhachHang(query) + "' , '"
                        + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                        + textBoxTenKhachHang.Text + "' , '"
                        + textBoxTenChuRe.Text + "' , '" 
                        + textBoxTenCoDau.Text + "' , '" 
                        + textBoxDiaChi.Text + "' , '" 
                        + textBoxDienThoai.Text + "', '" 
                        + textBoxEmail.Text + "', '"   
                        + dateTimePickerNgayToChuc.Value.ToString(formatDate) + "', '"
                        + textBoxTienCoc.Text + "')";
                int IdThongTinKhachHang = provider.ExecuteWrite(query1);
                string query2 = "Insert into ThongTinDatTiec (IDNhanVien,IDThongTinKhachHang,IdLoaiSanh,IdDichVu,IdThucDon,SoLuongNhanVien, SoLuongBan,TrangThai,Ca) Values("
                        + comboBoxTenNhanVien.SelectedValue.ToString().Trim() + ","
                        + IdThongTinKhachHang + ",'"
                        + comboBoxLoaiSanh.SelectedValue.ToString().Trim() + "','"
                        + comboBoxDichVu.SelectedValue.ToString().Trim() + "','"
                        + comboBoxThucDon.SelectedValue.ToString().Trim() + "','"
                        + textBoxSLNhanVien.Text + "' , '"
                        + textBoxSoLuongBan.Text+ "', '"
                        + comboBoxTrangThai.SelectedValue.ToString().Trim() +"','"
                        + comboBoxCa.SelectedValue.ToString().Trim() +"' )";
                    
                    provider.ExecuteWrite(query2);
                string query3 = "Insert into NhanVienTiepTan(TenNhanVien) values ( '"+ comboBoxTenNhanVien.SelectedValue.ToString().Trim()+"')";
                provider.ExecuteWrite(query3);
                MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Lỗi, không lưu được");
            }

        }
        public void Show_ComboboxTenNhanVien()
        {
            string query = "select * from NhanVienTiepTan";
            DataProvider provider = new DataProvider();
            comboBoxTenNhanVien.DataSource = provider.ExecuteQuery(query);
            comboBoxTenNhanVien.DisplayMember = "TenNhanVien";
            comboBoxTenNhanVien.ValueMember = "id";
        }
        public void Show_ComboboxLoaiSanh()
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            comboBoxLoaiSanh.DataSource = provider.ExecuteQuery(query);
            comboBoxLoaiSanh.DisplayMember = "LoaiSanh";
            comboBoxLoaiSanh.ValueMember = "id";
        }
     
        public void Show_ComboboxCa()
        {
            string query = "select * from Tiec";
            DataProvider provider = new DataProvider();
            comboBoxCa.DataSource = provider.ExecuteQuery(query);
            comboBoxCa.DisplayMember = "Ca";
            comboBoxCa.ValueMember = "Ca";
        }

        public void Show_ComboboxThucDon()
        {
            string query = "select * from ThucDon";
            DataProvider provider = new DataProvider();
            comboBoxThucDon.DataSource = provider.ExecuteQuery(query);
            comboBoxThucDon.DisplayMember = "MaThucDon";
            comboBoxThucDon.ValueMember = "id";
        }

        public void Show_ComboboxDichVu()
        {
            string query = "select * from DichVu";
            DataProvider provider = new DataProvider();
            comboBoxDichVu.DataSource = provider.ExecuteQuery(query);
            comboBoxDichVu.DisplayMember = "MaDichVu";
            comboBoxDichVu.ValueMember = "id";
        }

        public void Show_ComboboxTrangThai()
        {
            string query = "select * from Tiec";
            DataProvider provider = new DataProvider();
            comboBoxTrangThai.DataSource = provider.ExecuteQuery(query);
            comboBoxTrangThai.DisplayMember = "TrangThai";
            comboBoxTrangThai.ValueMember = "TrangThai";
        }
       
        private void comboBoxLoaiSanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void LapHopDong_Load(object sender, EventArgs e)
        {
            //DataProvider KH = new DataProvider();
           // string query = "Select * from ThongTinKhachHang";
           // textBoxMaKhachHang.Text = KH.TangMaKhachHang(query);
        }

        private void comboBoxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
