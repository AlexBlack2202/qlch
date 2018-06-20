using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SoftQuanLyNhaHang.Controllers
{
    class PhanQuyenCtrl
    {
        public static DataSet FillDataSet_getPhanQuyenByIdTaiKhoan(string _idTaiKhoan)
        {
            try
            {
                Models.PhanQuyenMod pquyen = new Models.PhanQuyenMod(_idTaiKhoan);
                return pquyen.FillDataSet_getPhanQuyenByIdTaiKhoan();

            }
            catch
            {
                return null;
            }
        }

        // Method Add
        public static int InsertPhanQuyen(string _idTaiKhoan, string _matKhau, String _idNhanVien)
        {
            try
            {
                Models.PhanQuyenMod _phanQuyen = new Models.PhanQuyenMod(_idTaiKhoan,_matKhau,_idNhanVien);
                return _phanQuyen.InsertPhanQuyen();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdatePhanQuyen(string _idTaiKhoan, string _matKhau, String _idNhanVien)
        {
            try
            {
                Models.PhanQuyenMod _phanQuyen = new Models.PhanQuyenMod(_idTaiKhoan, _matKhau, _idNhanVien);
                return _phanQuyen.UpdatePhanQuyen();
            }
            catch
            {
                return 0;
            }
        }
        // Method Delete
        public static int DeletePhanQuyen(string _idTaiKhoan)
        {
            try
            {
                Models.PhanQuyenMod _phanQuyen = new Models.PhanQuyenMod(_idTaiKhoan);
                return _phanQuyen.DeletePhanQuyen();
            }
            catch
            {
                return 0;
            }

        }
    }
}
