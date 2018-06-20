using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SoftQuanLyNhaHang.Models
{
    class BanMod
    {
        protected string    IdBan                       { get; set; }
        protected string    TenKhuVuc                   { get; set; }
        protected string    TenBan                      { get; set; }
        protected string    DienGiai                    { get; set; }
        protected string    TrangThai                   { get; set; }
        public BanMod(string _IdBan)
        {
            IdBan = _IdBan;
        }
        public BanMod()
        {

        }
        public BanMod(string _idBan,string _tenKhuVuc,string _tenBan,string _dienGiai,string _trangThai)
        {
            this.IdBan=_idBan;
            this.TenKhuVuc = _tenKhuVuc;
            this.TenBan=_tenBan;
            this.DienGiai=_dienGiai;
            this.TrangThai=_trangThai;

        }
        public int InsertBan()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[5] { IdBan, TenKhuVuc, TenBan, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spInsertBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateBan()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdBan", "@TenKhuVuc", "@TenBan", "@DienGiai", "@TrangThai" };
            object[] values = new object[5] { IdBan, TenKhuVuc, TenBan, DienGiai, TrangThai };
            i = Models.connection.Excute_Sql("spUpdateBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteBan()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            i = Models.connection.Excute_Sql("spDeleteBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetBan()
        {
            return Models.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_GoiMon()
        {
            return Models.connection.FillDataSet("spViewDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetTenBan()
        {
            return Models.connection.FillDataSet("spgetTenBan", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getBanByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            ds = Models.connection.FillDataSet("spgetBanByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
