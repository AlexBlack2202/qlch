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
    class KhachHangCtrl
    {
        public static DataSet FillDataSet_spgetKhachHangByIdKhachHang(string _idkhachhang)
        {
            try
            {
                Models.KhachHangMod khang = new Models.KhachHangMod(_idkhachhang);
                return khang.FillDataSet_getKhachHangByIdKhachHang();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InSertKhachHang(string _idKhachHang, string _tenKhachHang, string _dienthoai, string _email, string _diachi)
        {
            try
            {
                Models.KhachHangMod _khachHang = new Models.KhachHangMod(_idKhachHang, _tenKhachHang, _dienthoai, _email, _diachi);
                return _khachHang.InsertKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateKhachHang(string _idKhachHang, string _tenKhachHang, string _dienthoai, string _email, string _diachi)
        {
            try
            {
                Models.KhachHangMod _khachHang = new Models.KhachHangMod(_idKhachHang, _tenKhachHang, _dienthoai, _email, _diachi);
                return _khachHang.UpdateKhachHang();
            }
            catch
            {
                return 0;
            }

        }
        // Method Delete
        public static int DeleteKhachHang(string _idKhachHang)
        {
            try
            {
                Models.KhachHangMod _khachHang = new Models.KhachHangMod(_idKhachHang);
                return _khachHang.DeleteKhachHang();
            }
            catch
            {
                return 0;
            }

        }

    }
}
