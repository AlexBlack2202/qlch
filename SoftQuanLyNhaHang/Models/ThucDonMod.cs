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
    class ThucDonMod
    {
        protected string IdThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected string DonViTinh { get; set; }
        protected float SoLuongTon {get;set;}
        protected float DonGiaTon {get;set;}
        protected float TonToiThieu {get;set;}
        protected string TrangThai { get; set; }
        public ThucDonMod(string _IdThucDon)
        {
            IdThucDon=_IdThucDon;
        }
        public ThucDonMod()
        { }
        public ThucDonMod(string _idThucdon,string _tenLoaithucdon,string _tenThucdon,string _donVitinh,float _soLuongton,float _donGiaton,float _tonToithieu,string _trangThai)
        {
            this.IdThucDon = _idThucdon;
            this.TenLoaiThucDon = _tenLoaithucdon;
            this.TenThucDon = _tenThucdon;
            this.DonViTinh = _donVitinh;
            this.SoLuongTon = _soLuongton;
            this.DonGiaTon = _donGiaton;
            this.TonToiThieu = _tonToithieu;
            this.TrangThai = _trangThai;
        }
        public int InsertThucDon()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdThucDon","@TenLoaiThucDon","@TenThucDon","@DonViTinh","@SoLuongTon","@DonGiaTon","@TonToiThieu","@TrangThai" };
            object[] values = new object[8] { IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu, TrangThai };
            i = Models.connection.Excute_Sql("spInsertThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateThucDon()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteThucDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IdThucDon };
            i = Models.connection.Excute_Sql("spDeleteThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetThucDon()
        {
            return Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetThucDonNotTTT()
        {
            return Models.connection.FillDataSet("spgetThucDonNotTTT", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getLoaiThucDonByIdThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IdThucDon };
            ds = Models.connection.FillDataSet("spgetThucDonByIdThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
