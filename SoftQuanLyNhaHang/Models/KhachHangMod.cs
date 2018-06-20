using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoftQuanLyNhaHang.Models
{
    class KhachHangMod
    {
        protected string IdKhachHang { get; set; }
        protected string TenKhachHang { get; set; }
        protected string DienThoai { get; set; }
        protected string Email { get; set; }
        protected string DiaChi { get; set; }
        public KhachHangMod(string _IdKhachHang)
        {
            IdKhachHang = _IdKhachHang;
        }
        public KhachHangMod()
        { }
        public KhachHangMod(string _idkhachhang,string _tenkhachhang,string _dienthoai,string _email,string _diachi)
        {
            this.IdKhachHang=_idkhachhang;
            this.TenKhachHang = _tenkhachhang;
            this.DienThoai = _dienthoai;
            this.Email = _email;
            this.DiaChi = _diachi;

        }
        public int InsertKhachHang()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[5] { IdKhachHang, TenKhachHang, DienThoai,Email,DiaChi };
            i = Models.connection.Excute_Sql("spInsertKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateKhachHang()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[5] {  IdKhachHang, TenKhachHang, DienThoai,Email,DiaChi};
            i = Models.connection.Excute_Sql("spUpdateKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteKhachHang()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { IdKhachHang };
            i = Models.connection.Excute_Sql("spDeleteKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetKhachHang()
        {
            return Models.connection.FillDataSet("spgetKhachHang", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getKhachHangByIdKhachHang()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { IdKhachHang };
            ds = Models.connection.FillDataSet("spgetKhachHangByIdKhachHang", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
