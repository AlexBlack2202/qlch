using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Controllers
{
    class DangNhap
    {
        public static string CheckDangNhap(string _user, string _password)
        {
            try
            {
                Models.DangNhap dn = new Models.DangNhap(_user, _password);
                return dn.CheckDangNhap();
            }
            catch
            {
                return "";
            }

        }
    }
}
