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
    public partial class LapHopDong : Form
    {
        public LapHopDong()
        {
            InitializeComponent();
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
            if (MessageBox.Show("Bạn đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) ;
           
        }
    }
}
