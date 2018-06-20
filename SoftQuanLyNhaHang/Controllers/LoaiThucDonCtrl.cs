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
    class LoaiThucDonCtrl
    {
        public static DataSet FillDataSet_getLoaiThucDonByIdLoaiThucDon(string _idLoaiThucDon)
        {
            try
            {
                Models.LoaiThucDonMod LTdon = new Models.LoaiThucDonMod(_idLoaiThucDon);
                return LTdon.FillDataSet_getLoaiThucDonByIdLoaiThucDon();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InsertLoaiThucDon(string _idloaithucdon, string _tenloaithucdon, string _diengiai, string _trangthai)
        {
            try
            {
                Models.LoaiThucDonMod _lThucDon = new Models.LoaiThucDonMod(_idloaithucdon,_tenloaithucdon,_diengiai,_trangthai);
                return _lThucDon.InsertLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateLoaiThucDon(string _idloaithucdon, string _tenloaithucdon, string _diengiai, string _trangthai)
        {
            try
            {
                Models.LoaiThucDonMod _lThucDon = new Models.LoaiThucDonMod(_idloaithucdon, _tenloaithucdon, _diengiai, _trangthai);
                return _lThucDon.UpdateLoaiThucDon();
            }
            catch
            {
                return 0;
            }

        }
        // Method Delete
        public static int DeleteLoaiThucDon(string _idLoaiThucDon)
        {
            try
            {
                Models.LoaiThucDonMod _lThucDon = new Models.LoaiThucDonMod(_idLoaiThucDon);
                return _lThucDon.DeleteLoaiThucDon();
            }
            catch
            {
                return 0;
            }

        }
    }
}
