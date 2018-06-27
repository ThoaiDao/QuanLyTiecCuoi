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
    public partial class ThemSanhMoi : Form
    {
        public object TenSanh { get; private set; }
        public object SoLuongBanToiDa { get; private set; }
        public object DonGiaToiThieu { get; private set; }
        public object GhiChu { get; private set; }
        public object ErrorProvider1 { get; private set; }

        public ThemSanhMoi()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThongTin();
            frm.ShowDialog();

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (textLoaiSanhThem.Text !="" && textTenSanhThem.Text!="" && textSLBanThem.Text !="" && textDGToiThieuThem.Text !="" )
            {
                try
                {
                    DataProvider provider = new DataProvider();
                    string query = "Insert into ThongTinSanh (LoaiSanh, TenSanh, SoLuongBanToiDa, DonGiaToiThieu, GhiChu) Values('" + textLoaiSanhThem.Text + "' , '" + textTenSanhThem.Text + "' , '" + textSLBanThem.Text + "' , '" + textDGToiThieuThem.Text + "' , '" + textGhiChuThem.Text + "')";
                    int idInsert = provider.ExecuteWrite(query);
                    Console.WriteLine("ID insert" + idInsert);
                    MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Lỗi, không thêm được");
                }
            }
            else
                MessageBox.Show("Lỗi, không thêm được");


        }

        private void textSLBanThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textDGToiThieuThem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textLoaiSanhThem_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
