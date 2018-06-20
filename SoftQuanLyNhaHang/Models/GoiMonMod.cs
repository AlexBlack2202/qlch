using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SoftQuanLyNhaHang.Models
{
    class GoiMonMod
    {
        protected string IdBan { get; set; }
        protected string TenThucDon { get; set; }
        protected decimal DonGiaTon { get; set; }
        protected int SoLuong { get; set; }
        protected DateTime ThoiGian { get; set; }
        protected decimal ThanhTien { get; set; }
        public GoiMonMod(string _IdBan)
        {
            IdBan = _IdBan;
        }
        public GoiMonMod()
        {

        }
        public GoiMonMod(string _idBan, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            this.IdBan = _idBan;
            this.TenThucDon = _TenThucDon;
            this.DonGiaTon = _DonGiaTon;
            this.SoLuong = _SoLuong;
            this.ThoiGian = _ThoiGian;
            this.ThanhTien = _ThanhTien;
        }
        public int InsertGoiMon()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdBan", "@TenThucDon", "@DonGiaTon", "@SoLuong", "@ThoiGian", "@ThanhTien" };
            object[] values = new object[6] { IdBan, TenThucDon, DonGiaTon, SoLuong, ThoiGian,ThanhTien };
            i = Models.connection.Excute_Sql("spInsertGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateGoiMon()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdBan", "@TenThucDon", "@DonGiaTon", "@SoLuong", "@ThoiGian", "@ThanhTien" };
            object[] values = new object[6] { IdBan, TenThucDon, DonGiaTon, SoLuong, ThoiGian,ThanhTien };
            i = Models.connection.Excute_Sql("spUpdateGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteGoiMon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            i = Models.connection.Excute_Sql("spDeleteGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetGoiMon()
        {
            return Models.connection.FillDataSet("spgetGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_GoiMon()
        {
            return Models.connection.FillDataSet("spgetDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_ChuaGoiMon()
        {
            return Models.connection.FillDataSet("spgetDanhSachBan_ChuaGoiMon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getGoiMonByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            ds = Models.connection.FillDataSet("spgetGoiMonByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SumThanhTien()
        {
            return Models.connection.FillDataSet("spgetSumThanhTien", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getTenThucDon()
        {
            return Models.connection.FillDataSet("spgetTenThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getIdBan()
        {
            return Models.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getMonDaGoi()
        {
            return Models.connection.FillDataSet("spXemGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getDonGiaThucDon()
        {
            DataSet ds = new DataSet();
            try
            {

                ds = Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
            }
            catch { }
            return ds;
            //return Models.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }
    }
}
