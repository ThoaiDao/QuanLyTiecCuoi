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
    public partial class ThongTinTiec : Form
    {
      

        public ThongTinTiec()
        {
            InitializeComponent();
            Show_ComboboxThucDon();
            Show_ComboboxDichVu();
   
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                Form frm = new Menu();
                frm.ShowDialog();
        }
        public void Show_ComboboxThucDon()
        {
            string query = "select * from ThucDon";
            DataProvider provider = new DataProvider();
            comboBoxThucDon.DataSource = provider.ExecuteQuery(query);
            comboBoxThucDon.DisplayMember = "MaThucDon";
            comboBoxThucDon.ValueMember = "MaThucDon";
        }
        public void Show_ComboboxDichVu()
        {
            string query = "select * from DichVu";
            DataProvider provider = new DataProvider();
            comboBoxDichVu.DataSource = provider.ExecuteQuery(query);
            comboBoxDichVu.DisplayMember = "MaDichVu";
            comboBoxDichVu.ValueMember = "MaDichVu";
        }
        
        private void ThongTinTiec_Load(object sender, EventArgs e)
        {

            this.Show_ComboboxThucDon();
            this.Show_ComboboxDichVu();
        }
        private void comboBoxThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string a = comboBoxThucDon.SelectedValue.ToString();
            if (a != "System.Data.DataRowView")
            {
                string query = "select * from ThucDon where MaThucDon = '" + a + "'";
                DataTable thucDon = provider.ExecuteQuery(query);
                textBoxMonKhaiVi.Text = thucDon.Rows[0]["MonKhaiVi"].ToString();
                textBoxMonChinh1.Text = thucDon.Rows[0]["MonChinh1"].ToString();
                textBoxMonChinh2.Text = thucDon.Rows[0]["MonChinh2"].ToString();
                textBoxMonChinh3.Text = thucDon.Rows[0]["MonChinh3"].ToString();
                textBoxLau.Text = thucDon.Rows[0]["Lau"].ToString();
                textBoxTrangMieng.Text = thucDon.Rows[0]["TrangMieng"].ToString();
                textBoxBia.Text = thucDon.Rows[0]["Bia"].ToString();
                textBoxNuocNgot.Text = thucDon.Rows[0]["NuocNgot"].ToString();
                
            }
           
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string a = comboBoxDichVu.SelectedValue.ToString();
            if (a != "System.Data.DataRowView")
            {
                string query = "select * from DichVu where MaDichVu = '" + a + "'";
                Console.WriteLine(query);
                DataTable dichVu = provider.ExecuteQuery(query);
                textBoxRuou.Text = dichVu.Rows[0]["Ruou"].ToString();
                textBoxBanhKem.Text = dichVu.Rows[0]["BanhKem"].ToString();
                textBoxMC.Text = dichVu.Rows[0]["Mc"].ToString();
                textBoxBanNhac.Text = dichVu.Rows[0]["BanNhac"].ToString();
                textBoxCaSi.Text = dichVu.Rows[0]["CaSi"].ToString();
                textBoxDJ.Text = dichVu.Rows[0]["Dj"].ToString();
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                checkBox5.Checked = true;
                checkBox6.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
            }
        }
    }

        
    }







