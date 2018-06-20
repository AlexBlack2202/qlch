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
    class PhanQuyenMod
    {
         protected string    IdTaiKhoan                      { get; set; }
         protected string    MatKhau { get; set; }
         protected string    IdNhanVien                     { get; set; }
        public PhanQuyenMod(string _IdTaiKhoan)
        {
            IdTaiKhoan = _IdTaiKhoan;
        }
        public PhanQuyenMod()
        {

        }
        public PhanQuyenMod(string _idTaiKhoan, string _matKhau, String  _idNhanVien)
        {

            this.IdTaiKhoan = _idTaiKhoan;
            this.MatKhau = _matKhau;
            this.IdNhanVien = _idNhanVien;
        }
        public int InsertPhanQuyen()
        {
            int i = 0;
            string[] paras = new string[3] { "@IdTaiKhoan", "@MatKhau", "@IdNhanVien"};
            object[] values = new object[3] { IdTaiKhoan, MatKhau, IdNhanVien };
            i = Models.connection.Excute_Sql("spInsertPhanQuyen", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdatePhanQuyen()
        {
            int i = 0;
            string[] paras = new string[3] { "@IdTaiKhoan", "@MatKhau", "@IdNhanVien"};
            object[] values = new object[3] { IdTaiKhoan, MatKhau, IdNhanVien };
            i = Models.connection.Excute_Sql("spUpdatePhanQuyen", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeletePhanQuyen()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdTaiKhoan" };
            object[] values = new object[1] { IdTaiKhoan };
            i = Models.connection.Excute_Sql("spDeletePhanQuyen", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetPhanQuyen()
        {
            return Models.connection.FillDataSet("spgetPhanQuyen", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getPhanQuyenByIdTaiKhoan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdTaiKhoan" };
            object[] values = new object[1] { IdTaiKhoan };
            ds = Models.connection.FillDataSet("spgetPhanQuyenByIdTaiKhoan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
