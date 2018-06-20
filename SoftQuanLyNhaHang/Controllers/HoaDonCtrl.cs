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
    class HoaDonCtrl
    {
        public static DataSet FillDataSet_getHoaDonByIdBan(string _idBan)
        {
            try
            {
                Models.HoaDonMod hd = new Models.HoaDonMod(_idBan);
                return hd.FillDataSet_getHoaDonByIdBan();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InSertHoaDon(string _idHoaDon, string _idNhanVien, string _idBan, DateTime _ngayLap, string _dienGiai, decimal _soTien)
        {
            try
            {
                Models.HoaDonMod _hDon = new Models.HoaDonMod(_idHoaDon, _idNhanVien, _idBan, _ngayLap, _dienGiai,_soTien);
                return _hDon.InsertHoaDon();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateHoaDon(string _idHoaDon, string _idNhanVien, string _idBan, DateTime _ngayLap, string _dienGiai, decimal _soTien)
        {
            try
            {
                Models.HoaDonMod _hDon = new Models.HoaDonMod(_idHoaDon, _idNhanVien, _idBan, _ngayLap, _dienGiai, _soTien);
                return _hDon.UpdateHoaDon();
            }
            catch
            {
                return 0;
            }

        }
        // Method Delete
        public static int DeleteHoaDon(string _idHoaDon)
        {
            try
            {
                Models.HoaDonMod _hDon = new Models.HoaDonMod(_idHoaDon);
                return _hDon.DeleteHoaDon();
            }
            catch
            {
                return 0;
            }

        }
    }
}
