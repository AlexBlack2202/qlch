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
    class ThucDonCtrl
    {
        public static DataSet FillDataSet_getLoaiThucDonByIdThucDon(string _idThucDon)
        {
            try
            {
                Models.ThucDonMod Tdon = new Models.ThucDonMod(_idThucDon);
                return Tdon.FillDataSet_getLoaiThucDonByIdThucDon();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InsertThucDon(string _idThucdon,string _tenLoaithucdon,string _tenThucdon,string _donVitinh,float _soLuongton,float _donGiaton,float _tonToithieu,string _trangThai)
        {
            try
            {
                Models.ThucDonMod _Thucdon = new Models.ThucDonMod(_idThucdon,_tenLoaithucdon,_tenThucdon,_donVitinh,_soLuongton,_donGiaton,_tonToithieu,_trangThai);
                return _Thucdon.InsertThucDon();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateThucDon(string _idThucdon, string _tenLoaithucdon, string _tenThucdon, string _donVitinh, float _soLuongton, float _donGiaton, float _tonToithieu, string _trangThai)
        {
            try
            {
                Models.ThucDonMod _Thucdon = new Models.ThucDonMod(_idThucdon, _tenLoaithucdon, _tenThucdon, _donVitinh, _soLuongton, _donGiaton, _tonToithieu, _trangThai);
                return _Thucdon.UpdateThucDon();
            }
            catch
            {
                return 0;
            }

        }
        // Method Delete
        public static int DeleteThucDon(string _idThucDon)
        {
            try
            {
                Models.ThucDonMod _Thucdon = new Models.ThucDonMod(_idThucDon);
                return _Thucdon.DeleteThucDon();
            }
            catch
            {
                return 0;
            }

        }
    }
}
