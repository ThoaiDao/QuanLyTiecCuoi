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
    public partial class BaoCao : Form
    {
        public BaoCao()
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
            string a = comboBoxMaNguoiLap.SelectedValue.ToString();
            if (a != "System.Data.DataRowView")
            {
                string query = "select * from ThucDon where MaThucDon = '" + a + "'";
                Console.WriteLine(query);
                DataTable thucDon = provider.ExecuteQuery(query);
                //textBoxMonKhaiVi.Text = thucDon.Rows[0]["MonKhaiVi"].ToString();
                //textBoxMonChinh1.Text = thucDon.Rows[0]["MonChinh1"].ToString();
               
            }
        }
    }
}
