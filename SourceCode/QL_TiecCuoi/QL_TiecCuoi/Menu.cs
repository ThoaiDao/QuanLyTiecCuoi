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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
               Application.Exit();
            }
        }

        private void lậpHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LapHopDong();
            frm.ShowDialog();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new NhanVien();
            frm.ShowDialog();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new LapHoaDon();
            frm.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuHoaDon();
            frm.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuHopDong();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuNhanVien();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new BaoCao();
            frm.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThongTin();
            frm.ShowDialog();
        }
    }
}
