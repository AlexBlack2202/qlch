using A4ULtd.Lib.Data;
using SoftQuanLyNhaHang.Models;
using SoftQuanLyNhaHang.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Controllers
{
    public class ProductDAO
    {
        A4ULtd.Lib.Data.IData objData = Data.CreateData(Utils.Config.DBCon);
        public int AddProduct(string strbarcode, string strproductname, double sellprice)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_product_add");
                objData.AddParameter("@productid", strbarcode);
                objData.AddParameter("@productname", strproductname);
                objData.AddParameter("@sellprice", sellprice);
                objData.ExecStoreToString();
            }
            catch (Exception objEx)
            {
                return 1;
            }
            finally
            {
                objData.Disconnect();
            }

            return 0;
        }

        public bool UpdateProductSellPrice(string strbarcode, double sellprice)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_product_updatesellprice");
                objData.AddParameter("@productid", strbarcode);
                objData.AddParameter("@sellprice", sellprice);
                objData.ExecStoreToString();
            }
            catch (Exception objEx)
            {
                return false;
            }
            finally
            {
                objData.Disconnect();
            }

            return true;
        }

        public long InputVoucherAdd(int intcreateduserid, int intinputtype)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_input_voucher_add");
                objData.AddParameter("@inputtype", intinputtype);
                objData.AddParameter("@createduserid", intcreateduserid);
                string strValue = objData.ExecStoreToString();

                return Convert.ToInt64(strValue);
            }
            catch (Exception objEx)
            {
                return -1;
            }

            return -1;
        }

        public long OutputVoucherAdd(int intcreateduserid, int intoutputtype)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_outputvoucher_add");
                objData.AddParameter("@outputtype", intoutputtype);
                objData.AddParameter("@creatteduserid", intcreateduserid);
                string strValue = objData.ExecStoreToString();

                return Convert.ToInt64(strValue);
            }
            catch
            {
                return -1;
            }

            return -1;
        }



        public long InputVoucherDetailAdd(string productid, long inputvoucherid, double quantity, double retailprice)
        {
            long returnval = -1;
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_input_voucher_detail_add");
                objData.AddParameter("@productid", productid);
                objData.AddParameter("@inputvoucherid", inputvoucherid);
                objData.AddParameter("@quantity", quantity);
                objData.AddParameter("@price", retailprice);
                string strValue = objData.ExecStoreToString();

                returnval= Convert.ToInt64(strValue);
            }
            catch (Exception objEx)
            {
                returnval= - 1;
            }
            finally
            {
                objData.Disconnect();
            }

            return returnval;
        }

        public bool InputVoucherDetailAdd(DataTable tableData, long linputvoucherid)
        {
            bool returnValue = true;

            try
            {
                objData.BeginTransaction();

                for (int intRow = 0; intRow < tableData.Rows.Count; intRow++)
                {
                    string strProductID = tableData.Rows[intRow]["productid"].ToString();
                    double dbQuantity = Convert.ToDouble(tableData.Rows[intRow]["quantity"].ToString());
                    double dbRetailPrice = Convert.ToDouble(tableData.Rows[intRow]["InputPrice"].ToString());
                    long outputvoucherid = Convert.ToInt64(tableData.Rows[intRow]["outputvoucherid"].ToString());
                    objData.CreateNewStoredProcedure("pm_input_voucher_detail_add");
                    objData.AddParameter("@productid", strProductID);
                    objData.AddParameter("@inputvoucherid", linputvoucherid);
                    objData.AddParameter("@quantity", dbQuantity);
                    objData.AddParameter("@price", dbRetailPrice);
                    objData.AddParameter("@outputvoucherid", outputvoucherid);
                    
                    string strValue = objData.ExecStoreToString();
                }
                objData.CommitTransaction();
            }
            catch (Exception objEx)
            {
                objData.RollBackTransaction();
                returnValue = false;
            }
            finally
            {
                objData.Disconnect();
            }

            return returnValue;
        }


        public int OutputVoucherDetailAdd(DataTable tableData, long outvoucherid)
        {
            int returnValue = 0;
            try
            {
                objData.BeginTransaction();

                for (int intRow = 0; intRow < tableData.Rows.Count; intRow++)
                {
                    string productid = tableData.Rows[intRow]["productid"].ToString();

                    string quantity = tableData.Rows[intRow]["quantity"].ToString();
                    string retailprice = tableData.Rows[intRow]["saleprice"].ToString();
                    objData.CreateNewStoredProcedure("pm_outputvoucherdetail_add");
                    objData.AddParameter("@productid", productid);
                    objData.AddParameter("@outputvoucherid", outvoucherid);
                    objData.AddParameter("@quantity", quantity);
                    objData.AddParameter("@sellprice", retailprice);
                    string strValue = objData.ExecStoreToString();

                }
                objData.CommitTransaction();
            }
            catch (Exception objEx)
            {
                objData.RollBackTransaction();
                returnValue = 1;
            }
            finally
            {
                objData.Disconnect();
            }

            return returnValue;
        }

        public long OutputVoucherDetailAdd(string productid, long outvoucherid, double quantity, double retailprice)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_outputvoucherdetail_add");
                objData.AddParameter("@productid", productid);
                objData.AddParameter("@outputvoucherid", outvoucherid);
                objData.AddParameter("@quantity", quantity);
                objData.AddParameter("@sellprice", retailprice);
                string strValue = objData.ExecStoreToString();

                return Convert.ToInt64(strValue);
            }
            catch (Exception objEx)
            {
                return -1;
            }
            finally
            {
                objData.Disconnect();
            }

            return -1;
        }

        public Models.ProductBO getproductbybarcode(string barcode)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_product_getproductbybarcode");
                objData.AddParameter("@productid", barcode);

                DataTable objTable = objData.ExecStoreToDataTable();

                return objTable.ToList<ProductBO>().First();
            }
            catch
            {
                return null;
            }


        }


        public DataTable GetInventory()
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("bi_etl_inventory_getall");

                DataTable objTable = objData.ExecStoreToDataTable();

                return objTable;
            }
            catch (Exception objEx)
            {
                return null;
            }


        }

        public DataTable GetReportOutputByDate(DateTime dtBeginDate)
        {
            dtBeginDate = dtBeginDate.Date;
            DateTime dtEndDate = dtBeginDate.AddDays(1);
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_outputvoucherdetail_exportbydate");
                objData.AddParameter("@begindate", dtBeginDate);
                objData.AddParameter("@enddate", dtEndDate);
                DataTable objTable = objData.ExecStoreToDataTable();

                return objTable;
            }
            catch (Exception objEx)
            {
                return null;
            }


        }


        public DataTable GetReportInputByDate(DateTime dtBeginDate)
        {
            dtBeginDate = dtBeginDate.Date;
            DateTime dtEndDate = dtBeginDate.AddDays(1);
            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_outputvoucherdetail_inputbydate");
                objData.AddParameter("@begindate", dtBeginDate);
                objData.AddParameter("@enddate", dtEndDate);
                DataTable objTable = objData.ExecStoreToDataTable();

                return objTable;
            }
            catch (Exception objEx)
            {
                return null;
            }


        }

        public List<OutputVoucherDetailBO> getlistoutputvoucherdetail(long outputvoucherid)
        {

            try
            {
                objData.Connect();
                objData.CreateNewStoredProcedure("pm_outputvoucherdetail_getlist");
                objData.AddParameter("@outputvoucherid", outputvoucherid);

                DataTable objTable = objData.ExecStoreToDataTable();

                return objTable.ToList<OutputVoucherDetailBO>();
            }
            catch
            {
                return null;
            }


        }
    }
}
