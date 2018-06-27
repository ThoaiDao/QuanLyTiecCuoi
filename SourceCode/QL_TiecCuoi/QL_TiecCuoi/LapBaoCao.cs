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

namespace QL_TiecCuoi
{
    public partial class LapBaoCao : Form
    {
        public LapBaoCao()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void comboBoxMaNguoiLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            ///string a = comboBoxMaNguoiLap.SelectedValue.ToString();
           // if (a != "System.Data.DataRowView")
            //{
               // string query = "select * from ThucDon where MaThucDon = '" + a + "'";
               // Console.WriteLine(query);
                //DataTable thucDon = provider.ExecuteQuery(query);
                //textBoxMonKhaiVi.Text = thucDon.Rows[0]["MonKhaiVi"].ToString();
                //textBoxMonChinh1.Text = thucDon.Rows[0]["MonChinh1"].ToString();
               
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Menu();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string formatDate = "MM/dd/yyyy";
            string query1 = "Insert into LapBaoCao ( NgayLap, TenNguoiLap, Thang,SoLuongTiec, DoanhThu) Values('"

                + dateTimePickerNgayLap.Value.ToString(formatDate) + "' , '"
                + textBoxTenNguoiLap.Text + "' , '"
                + textBoxThang.Text + "' , '"
                + textBoxSoLuongTiec.Text + "' , '"
                + textBoxDoanhThu.Text + "' )";
            provider.ExecuteWrite(query1);
            MessageBox.Show("Bạn đã lưu thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
        }

        private void textBoxTenNguoiLap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\!^\#^\$^\%^\&^\'^\(^\)^\*^\,^\-^\.^\/^\:^\;^\<^\=^\>^\?^\@^\[^\\^\]^\^_^\`^\{^\|^\}^\~]"))
            {
                  e.Handled = true;
            }
        }

        private void textBoxThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxSoLuongTiec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void textBoxDoanhThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
    }

