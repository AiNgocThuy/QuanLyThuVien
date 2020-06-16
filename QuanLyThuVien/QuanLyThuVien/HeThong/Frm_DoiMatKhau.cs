using QuanLyBanHang_17SE111;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.HeThong
{
    public partial class Frm_DoiMatKhau : Form
    {
        public Frm_DoiMatKhau()
        {
            InitializeComponent();
        }
        BLL_HeThong bd;
        string err = string.Empty;
        int count = 0;
        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bd = new BLL_HeThong();
            if (Cls_Main.maTaiKhoan.Equals("1"))
            {
                gbCapLaiMatKhau.Enabled = true;
                LayDuLieuVaoCboThuthu();
            }
            else
            {
                gbCapLaiMatKhau.Enabled = false;
            }
        }

        private void LayDuLieuVaoCboThuthu()
        {
            DataTable dataTable = new DataTable();
            dataTable = bd.LayDuLieuVaoCboThuthu(ref err);
            cboThuthu.DataSource = dataTable;
            cboThuthu.DisplayMember = "TenNhanVien";
            cboThuthu.ValueMember = "MaNhanVien";
            cboThuthu.SelectedIndex = -1;
            cboThuthu.Text = "Chọn nhân viên";
        }

        private void bntCapLai_Click(object sender, EventArgs e)
        {
           /* if (cboThuthu.SelectedIndex >= 0)
            {
                if (bd.DoiMatKhau(ref err, ref count, cboThuthu.SelectedValue.ToString()))
                {
                    if (count > 0)
                    {
                        MessageBox.Show("Reset mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Reset mật khẩu không thành công\n" + err);
                    }
                }
                else
                {
                    MessageBox.Show("Reset mật khẩu không thành công\n" + err);
                }
            }*/
        }

        private void txtNhaplaimkmoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhaplaimkmoi_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhaplaimkmoi.Text))
            {
                if (!txtNhaplaimkmoi.Text.Equals(txtmatKhaumoi.Text))
                {
                    MessageBox.Show("Mật khẩu không khớp\n Xin vui lòng nhập lại");
                    txtNhaplaimkmoi.ResetText();
                    txtNhaplaimkmoi.Focus();
                }
                else
                {
                    txtmatKhaumoi.Enabled = false;
                    txtNhaplaimkmoi.Enabled = false;
                    bntDoiMatKhau.Enabled = true;
                }
            }
        }

        private void bntDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNhaplaimkmoi.Text))
            {
                if (!string.IsNullOrEmpty(txtmatKhaumoi.Text))
                {
                    if (bd.DoiMatKhau(ref err, ref count, Cls_Main.maNhanVien, txtmatKhaumoi.Text))
                    {
                        if (count > 0)
                        {
                            MessageBox.Show("Reset mật khẩu thành công");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Reset mật khẩu không thành công\n" + err);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Reset mật khẩu không thành công\n" + err);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng nhập lại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng nhập lại");
            }
        }
    }
}
    
