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
    class LoaiThucDonMod
    {
        protected string IdLoaiThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        public LoaiThucDonMod(string _IdLoaiThucDon)
        {
            IdLoaiThucDon = _IdLoaiThucDon;
        }
        public LoaiThucDonMod()
        { }
        public LoaiThucDonMod(string _idloaithucdon, string _tenloaithucdon, string _diengiai, string _trangthai)
        {
            this.IdLoaiThucDon = _idloaithucdon;
            this.TenLoaiThucDon = _tenloaithucdon;
            this.DienGiai = _diengiai;
            this.TrangThai = _trangthai;
        }
        public int InsertLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai"};
            object[] values = new object[4] { IdLoaiThucDon,TenLoaiThucDon,DienGiai,TrangThai };
            i = Models.connection.Excute_Sql("spInsertLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IdLoaiThucDon, TenLoaiThucDon, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteLoaiThucDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IdLoaiThucDon };
            i = Models.connection.Excute_Sql("spDeleteLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetLoaiThucDon()
        {
            return Models.connection.FillDataSet("spgetLoaiThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getTenLoaiThucDon()
        {
            return Models.connection.FillDataSet("spgetTenLoaiThucDon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getLoaiThucDonByIdLoaiThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IdLoaiThucDon };
            ds = Models.connection.FillDataSet("spgetLoaiThucDonByIdLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        
    }
}
