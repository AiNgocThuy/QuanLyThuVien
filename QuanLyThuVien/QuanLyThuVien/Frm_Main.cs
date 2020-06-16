using QuanLyThuVien.HeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_Dangnhap = new Frm_DangNhap();
            frm_Dangnhap.ShowDialog();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ThuThu_Main frmthuthu = new Frm_ThuThu_Main();
            frmthuthu.MdiParent = this;
            frmthuthu.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau dmk = new Frm_DoiMatKhau();
            dmk.MdiParent = this;
            dmk.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
