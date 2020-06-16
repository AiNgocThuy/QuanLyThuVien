
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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        BLL_HeThong bd;
        DataTable dataTable;
        string err = string.Empty;
        private void DangNhap_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if(DangNhap(txtUser.Text, txtPasswork.Text))
            {
                
                Frm_Main frmain = new Frm_Main();
                frmain.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai \n " + err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool DangNhap(string tenDangNhap, string matKhau)
        {
            dataTable = new DataTable();
            dataTable = bd.KiemTraDangNhap(ref err, tenDangNhap, matKhau);
            if (dataTable.Rows.Count > 0)
            {
                if (dataTable.Rows[0]["code"].ToString().Equals("1"))
                {
                    QuanLyBanHang_17SE111.Cls_Main.tenNhanVien = dataTable.Rows[0]["HoTenNV"].ToString();
                    QuanLyBanHang_17SE111.Cls_Main.maTaiKhoan = dataTable.Rows[0]["MaTaiKhoan"].ToString();
                    //Cls_Main.maNhanVien = dataTable.Rows[0]["MaNhanVien"].ToString();
                    return true;
                }
            }
            return false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

   
}
