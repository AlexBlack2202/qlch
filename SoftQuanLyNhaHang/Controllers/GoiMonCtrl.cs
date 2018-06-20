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
    class GoiMonCtrl
    {
        public static DataSet FillDataSet_getGoiMonByIdBan(string _idBan)
        {
            try
            {
                Models.GoiMonMod gmon = new Models.GoiMonMod(_idBan);
                return gmon.FillDataSet_getGoiMonByIdBan();

            }
            catch
            {
                return null;
            }
        }
        
        // Method Add
        public static int InSertGoiMon(string _idBan, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian,decimal _ThanhTien)
        {
            try
            {
                Models.GoiMonMod _goiMon = new Models.GoiMonMod(_idBan,_TenThucDon,_DonGiaTon,_SoLuong,_ThoiGian,_ThanhTien);
                return _goiMon.InsertGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateGoiMon(string _idBan, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            try
            {
                Models.GoiMonMod _goiMon = new Models.GoiMonMod(_idBan, _TenThucDon, _DonGiaTon, _SoLuong, _ThoiGian,_ThanhTien);
                return _goiMon.UpdateGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        // Method Delete
        public static int DeleteGoiMon(string _idBan)
        {
            try
            {
                Models.GoiMonMod _goiMon = new Models.GoiMonMod(_idBan);
                return _goiMon.DeleteGoiMon();
            }
            catch
            {
                return 0;
            }

        }
    }
}
