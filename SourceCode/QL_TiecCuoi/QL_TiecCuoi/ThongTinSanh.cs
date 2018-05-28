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
using QL_TiecCuoi.DAO;
using Microsoft.VisualBasic;

namespace QL_TiecCuoi
{
    public partial class ThongTinSanh : Form
    {
        

        public object GhiChu { get; private set; }
        public object TenSanh { get; private set; }
        public object SoLuongBanToiDa { get; private set; }
        public object DonGiaToiThieu { get; private set; }
        public object Interaction { get; private set; }

        public ThongTinSanh()
        {
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form frm = new Menu();
                frm.ShowDialog();
        }
       
   
    

        private void button3_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            Form frm = new ThemSanhMoi();
            frm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "select * from ThongTinSanh";
            DataProvider provider = new DataProvider();
            dataGridViewDS_Sanh.DataSource = provider.ExecuteQuery(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr = "Delete from ThongTinSanh where id='" + a + "'";
                provider.ExecuteDelete(deletedStr);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "select * from ThongTinSanh";
                dataGridViewDS_Sanh.DataSource = provider.ExecuteQuery(query);
                //Console.Write(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                
            }
            catch 
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {

          
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewDS_Sanh.CurrentCell.RowIndex;
                string ID = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[0].Value.ToString());
                string loaisanh = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[1].Value.ToString());
                string tensanh = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[2].Value.ToString());
                string soluongbantoida = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[3].Value.ToString());
                string dongiatoithieu = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[4].Value.ToString());
                string ghichu = Convert.ToString(dataGridViewDS_Sanh.Rows[CurrentIndex].Cells[5].Value.ToString());

                string updateStr = "Update ThongTinSanh set TenSanh='" + tensanh + "',SoLuongBanToiDa='" + soluongbantoida + "',DonGiaToiThieu='" + dongiatoithieu + "',GhiChu='" + ghichu + "' where id = '"+ ID+"'";
                Console.Write(updateStr);
                provider.ExecuteUpdate(updateStr);
                
                string query = "select * from ThongTinSanh";
                dataGridViewDS_Sanh.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không sửa được");
            }




        }
       
       
    }
}

 
   
