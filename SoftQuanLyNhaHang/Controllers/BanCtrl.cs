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
    class BanCtrl
    {
         public static DataSet FillDataSet_getBanByIdBan(string _idBan)
        {
            try
            {
                Models.BanMod ban = new Models.BanMod(_idBan);
                return ban.FillDataSet_getBanByIdBan();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InSertBan(string _idBan, string _tenKhuVuc, string _tenBan, string _dienGiai, string _trangThai)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_idBan, _tenKhuVuc, _tenBan, _dienGiai, _trangThai);
                return _ban.InsertBan();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateBan(string _idBan, string _tenKhuVuc, string _tenBan, string _dienGiai, string _trangThai)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_idBan, _tenKhuVuc, _tenBan, _dienGiai, _trangThai);
                return _ban.UpdateBan();
            }
            catch
            {
                return 0;
            }

        }
        // Method Delete
        public static int DeleteBan(string _idBan)
        {
            try
            {
                Models.BanMod _ban = new Models.BanMod(_idBan);
                return _ban.DeleteBan();
            }
            catch
            {
                return 0;
            }

        }
    }
}
