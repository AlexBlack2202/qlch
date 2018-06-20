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
    class HoaDonMod
    {
        protected string    IdHoaDon                      { get; set; }
        protected string    IdNhanVien                     { get; set; }
        protected string    IdBan                       { get; set; }
        protected DateTime    NgayLap                   { get; set; }
        protected string    DienGiai                    { get; set; }
        protected decimal    SoTien                   { get; set; }
        public HoaDonMod(string _IdHoaDon)
        {
            IdHoaDon = _IdHoaDon;
        }
        public HoaDonMod()
        {

        }
        public HoaDonMod(string _idHoaDon, string _idNhanVien, string _idBan, DateTime _ngayLap, string _dienGiai, decimal _soTien)
        {
            this.IdHoaDon = _idHoaDon;
            this.IdNhanVien = _idNhanVien;
            this.IdBan = _idBan;
            this.NgayLap = _ngayLap;
            this.DienGiai = _dienGiai;
            this.SoTien = _soTien;

        }
        public int InsertHoaDon()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdHoaDon", "@IdNhanVien", "@IdBan", "@NgayLap", "@DienGiai", "@SoTien" };
            object[] values = new object[6] { IdHoaDon, IdNhanVien, IdBan, NgayLap, DienGiai, SoTien };
            i = Models.connection.Excute_Sql("spInsertHoaDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateHoaDon()
        {
            int i = 0;
            string[] paras = new string[6] { "@IdHoaDon", "@IdNhanVien", "@IdBan", "@NgayLap", "@DienGiai", "@SoTien" };
            object[] values = new object[6] { IdHoaDon, IdNhanVien, IdBan, NgayLap, DienGiai, SoTien };
            i = Models.connection.Excute_Sql("spUpdateHoaDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoaDon()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdHoaDon" };
            object[] values = new object[1] { IdHoaDon };
            i = Models.connection.Excute_Sql("spDeleteHoaDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetHoaDon()
        {
            return Models.connection.FillDataSet("spgetHoaDon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getHoaDonByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            ds = Models.connection.FillDataSet("spgetHoaDonByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
