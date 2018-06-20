using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SoftQuanLyNhaHang.Models
{
    class DangNhap
    {
        protected string IdDangNhap { get; set; }
        protected string MatKhau { get; set; }
        public DangNhap()
        {

        }
        public DangNhap(string _idDangNhap, string _MatKhau)
        {
            IdDangNhap = _idDangNhap;
            MatKhau = _MatKhau;
        }
        public string CheckDangNhap()
        {
            string str = "";
            string[] paras = new string[2] { "@IdDangNhap", "@MatKhau" };
            object[] values = new object[2] { IdDangNhap, MatKhau };
            str = Models.connection.ExcuteScalar("spCheckDangNhap", CommandType.StoredProcedure, paras, values);
            return str;
        }    
    }
}
