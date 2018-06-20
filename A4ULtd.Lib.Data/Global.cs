using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4ULtd.Lib.Data
{
    public class Globals
    {
        //public static string ERROR_LOG_FILE;

        //public Globals();

        //public static bool IsIE6 { get; }
        //public static string StartUpPath { get; set; }

        //public static string ApplicationVRoot();
        //public static ArrayList ConvertArrayList(IDataReader drReader);
        //public static string ConvertCurrency(long intPrice, string strCurrencyStyle);
        //public static Hashtable ConvertHashTable(IDataReader drReader);
        //public static string ConvertHTMLToExcelXML(string strHtml);
        //public static string ConvertISOToUnicode(string strSource);
        //public static string ConvertPrice(long intPrice);
        //public static string CutControlChars(string strInput);
        //public static string CutSpecialChars(string strInput);
        //public static string CutSpecialChars(string strInput, string strReplace);
        //public static string CutSpecialChars(string strInput, string strExp, string strReplace);
        //public static DataTable DataTableSelect(DataTable dtbSource, string filterExpression);
        //public static DataTable DataTableSelect(DataTable dtbSource, string filterExpression, int intTopRowNum);
        //public static DataTable DataTableSelect(DataTable dtbSource, string filterExpression, string strSort);
        //public static DataTable DataTableSelect(DataTable dtbSource, string filterExpression, string strSort, string strColumnUnique);
        //public static DataTable DataTableSelect(DataTable dtbSource, string filterExpression, string strSort, int intTopNumRow);
        //public static bool DownloadFile(string strLinkFile, string strSavePath, string strUsername = "", string strPassword = "");
        //public static string ExcelHeader();
        //public static string ExcelWorkSheetOptions();
        //public static void ExportToExcel(DataTable dtInput, string strFileName);
        //public static void ExportToExcel(DataSet dsInput, string[] strSheetName, string strFileName);
        //public static string FilterFile(string strFileName);
        //public static string FilterHtmlTab(string strParam);
        //public static string FilterSQLParamater(string strParam);
        //public static string FilterVietkey(string strSource);
        //public static string FormatN(object ob, int decimals);
        //public static string FormatURLText(string source);
        //public static string GetBoardSerial();
        //public static int GetIntRequest(string RequestKey, int intDefaultValue);
        //public static System.Web.UI.Control GetPostBackControl(System.Web.UI.Page page);
        //public static string GetStrRequest(string RequestKey, string strDefaultValue);
        //public static bool IsValidDate(string strDate);
        //public static bool IsValidDate(string strDate, string strFormat, bool bolConfig);
        //public static void ModifyWebConfig(string key, string value);
        //public static DateTime ParseDate(string strDate);
        //public static DateTime ParseDate(string strDate, string strFormat, bool bolConfig);
        //public static DateTime ParseDatetime(string strDatetime);
        //public static DateTime ParseDatetime(string strDatetime, string strFormat, bool bolConfig);
        //public static bool ResizeImage(string strResourceFile, int intHeight, int intWidth);
        //public static DataTable SelectDistinct(DataTable dtSourceTable, string strFieldName);
        //public static DataTable SelectDistinct(DataTable dtSourceTable, string strFieldName, string strFilterExp);
        //public static string UploadFile(System.Web.UI.WebControls.FileUpload fileUpload, string strPath, bool bolOverWrite, bool bolIncludeCreatedDate);

        public enum DATATYPE
        {
            NUMBER,
            CHAR,
            VARCHAR,
            NVARCHAR,
            NTEXT,
            BINARY,
            BLOB,
            CLOB,
            NCLOB
        }

        public static Hashtable ConvertHashTable(IDataReader drReader)
        {
            Hashtable hashtable = new Hashtable();
            if (drReader.Read())
            {
                for (int i = 0; i < drReader.FieldCount; i++)
                {
                    if (!hashtable.Contains(drReader.GetName(i)))
                    {
                        if (drReader[i] == null || drReader.IsDBNull(i))
                        {
                            hashtable.Add(drReader.GetName(i).ToUpper(), "");
                        }
                        else
                        {
                            hashtable.Add(drReader.GetName(i), drReader[i]);
                        }
                    }
                }
            }
            return hashtable;
        }

        public static ArrayList ConvertArrayList(IDataReader drReader)
        {
            ArrayList arrayList = new ArrayList();
            while (drReader != null && drReader.Read())
            {
                Hashtable hashtable = new Hashtable();
                for (int i = 0; i < drReader.FieldCount; i++)
                {
                    if (!hashtable.Contains(drReader.GetName(i)))
                    {
                        if (drReader.IsDBNull(i) || drReader[i] == null || drReader[i].ToString() == "")
                        {
                            hashtable.Add(drReader.GetName(i).ToUpper(), "");
                        }
                        else
                        {
                            hashtable.Add(drReader.GetName(i), drReader[i]);
                        }
                    }
                }
                arrayList.Add(hashtable);
            }
            return arrayList;
        }
    }
}
