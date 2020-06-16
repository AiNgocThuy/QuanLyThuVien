using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.HeThong
{
    public class BLL_HeThong
    {
        Database data;
        public BLL_HeThong()
        {
            data = new Database();
        }

        public DataTable KiemTraDangNhap(ref string err, string tenDangNhap, string matKhau)
        {
            return data.GetDataTable(ref err, "PSP_NhanVien_KiemTraDangNhap", CommandType.StoredProcedure,
                new SqlParameter("@TenDangNhap", tenDangNhap),
                new SqlParameter("@MatKhau", matKhau));
        }

        internal DataTable LayDuLieuVaoCboThuthu(ref string err)
        {
            throw new NotImplementedException();
        }

        internal bool DoiMatKhau(ref string err, ref int count, string maNhanVien, string text)
        {
            throw new NotImplementedException();
        }
    }
}
