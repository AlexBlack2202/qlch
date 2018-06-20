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
    class NhanVienCtrl 
    {
        public static DataSet FillDataSet_getNhanVienByIdNhanVien(string _idNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_idNhanVien);
                return nvien.FillDataSet_getNhanVienByIdNhanVien();

            }
            catch
            {
                return null;
            }
        } 
        public static DataSet FillDataSet_getSearchNVbyId(string _idNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_idNhanVien);
                return nvien.FillDataSet_getSearchNVbyId();

            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_FindNVByTen(string _tenNhanVien)
        {
            try
            {
                Models.NhanVienMod nvien = new Models.NhanVienMod(_tenNhanVien);
                return nvien.FillDataSet_FindNVByTen();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InSertNhanVien(string _idNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _dienthoaiNhanVien, string _emailNhanVien, string _diachiNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                return _nhanVien.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateNhanVien(string _idNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _dienthoaiNhanVien, string _emailNhanVien, string _diachiNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                return _nhanVien.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }   
            
        }
        // Method Delete
        public static int DeleteNhanVien(string _idNhanVien)
        {
            try
            {
                Models.NhanVienMod _nhanVien = new Models.NhanVienMod(_idNhanVien);
                return _nhanVien.DeleteNhanVien();
            }
            catch
            {
                return 0;
            }

        }
    }
}
