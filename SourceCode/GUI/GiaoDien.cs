using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index_Demo
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       private void fLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new fLogin();
            frm.ShowDialog();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đóng ứng dụng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void tiếpNhậnSảnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FSanh();
            frm.ShowDialog();
        }

        private void nhậnĐặtTiệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new DatTiecCuoi();
            frm.ShowDialog();
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuTiec();
            frm.ShowDialog();
        }

        private void traCứuHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new TraCuuHoaDon();
            frm.ShowDialog();
        }

        private void danhSáchSảnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new DS_Sanh();
            frm.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new DS_NhanVien();
            frm.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new HoaDon();
            frm.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new BaoCao();
            frm.ShowDialog();
        }

        private void thôngTinNhàHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new ThongTinNhaHang();
            frm.ShowDialog();
        }

        private void thôngTinDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Frm = new ThongTinDichVu();
            Frm.ShowDialog();
        }

        private void thôngTinSảnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Frm = new ThongTinSanh();
            Frm.ShowDialog();
        }

        private void thôngTinMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Frm = new ThongTinThucDon();
            Frm.ShowDialog();
        }
    }
}
