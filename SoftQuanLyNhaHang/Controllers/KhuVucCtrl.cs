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
    class KhuVucCtrl
    {
        public static DataSet FillDataSet_getKhuVucByIdKhuVuc(string _idKhuVuc)
        {
            try
            {
                Models.KhuVucMod kvuc = new Models.KhuVucMod(_idKhuVuc);
                return kvuc.FillDataSet_getKhuVucByIdKhuVuc();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InSertKhuVuc(string _idKhuVuc, string _tenKhuVuc, string _dienGiai, string _trangThai)
        {
            try
            {
                Models.KhuVucMod _khuVuc = new Models.KhuVucMod(_idKhuVuc,_tenKhuVuc,_dienGiai,_trangThai);
                return _khuVuc.InsertKhuVuc();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateKhuVuc(string _idKhuVuc, string _tenKhuVuc, string _dienGiai, string _trangThai)
        {
            try
            {
                Models.KhuVucMod _khuVuc = new Models.KhuVucMod(_idKhuVuc, _tenKhuVuc, _dienGiai, _trangThai);
                return _khuVuc.UpdateKhuVuc();
            }
            catch
            {
                return 0;
            }
        }
        // Method Delete
        public static int DeleteKhuVuc(string _idKhuVuc)
        {
            try
            {
                Models.KhuVucMod _khuVuc = new Models.KhuVucMod(_idKhuVuc);
                return _khuVuc.DeleteKhuVuc();
            }
            catch
            {
                return 0;
            }

        }
    }
}
