using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4ULtd.Lib.Data
{
    public class Data
    {
        public enum DATABASETYPE
        {
            NONE,
            SQLSERVER,
            ORACLE,
            MySQL,
            MsAccess
        }
        protected const string DEFAULT_OUT_PARAMETER = "v_Out";
        protected const int DEFAULT_OUT_PARAMETER_LENGTH = 4000;
        protected static string strPassword3;
        protected string strConnect;

        private SqlConnection objSqlConnection;
        private SqlCommand objSqlCommand;
        public static Data.DATABASETYPE DataBaseType = Data.DATABASETYPE.NONE;

        public Data() { }

        public static Data.DATABASETYPE RegconizeStringConnect(string strConnect)
        {
            string[] array = new string[]
            {
                "Data Source",
                "User ID",
                "Password",
                "Unicode"
            };
            string[] array2 = new string[]
            {
                "Server",
                "DataBase",
                "UID",
                "Pwd",
                "Data Source",
                "User ID",
                "Password",
                "Initial Catalog"
            };
            string[] array3 = new string[]
            {
                "Server",
                "User ID",
                "Password",
                "DataBase"
            };
            string[] array4 = new string[]
            {
                "Provider",
                "Microsoft",
                "Jet",
                "OLEDB",
                "Data Source"
            };
            int num = 0;
            num += strConnect.ToUpper().Split(new string[]
            {
                "ORA"
            }, StringSplitOptions.None).Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (strConnect.ToUpper().Contains(array[i].ToUpper()))
                {
                    num++;
                }
            }
            int num2 = 0;
            num2 += strConnect.ToUpper().Split(new string[]
            {
                "SQL"
            }, StringSplitOptions.None).Length;
            for (int i = 0; i < array2.Length; i++)
            {
                if (strConnect.ToUpper().Contains(array2[i].ToUpper()))
                {
                    num2++;
                }
            }
            int num3 = 0;
            for (int i = 0; i < array3.Length; i++)
            {
                if (strConnect.ToUpper().Contains(array3[i].ToUpper()))
                {
                    num3++;
                }
            }
            int num4 = 0;
            for (int i = 0; i < array4.Length; i++)
            {
                if (strConnect.ToUpper().Contains(array4[i].ToUpper()))
                {
                    num4++;
                }
            }
            Data.DATABASETYPE result;
            if (num3 >= 4)
            {
                result = Data.DATABASETYPE.MySQL;
            }
            else if (num4 >= 5)
            {
                result = Data.DATABASETYPE.MsAccess;
            }
            else
            {
                result = ((num >= num2) ? Data.DATABASETYPE.ORACLE : Data.DATABASETYPE.SQLSERVER);
            }
            return result;
        }

        private static Data CreateData()
        {
            return null;
        }
        public static IData CreateData(string strConnect)
        {
            //Data objData = new Data();

            //objData.strConnect = strConnect;
            Data.DataBaseType = Data.RegconizeStringConnect( strConnect);
            IData result;

            result = new SQLData(strConnect);
           
            //switch (Data.DataBaseType)
            //{
            //    case Data.DATABASETYPE.SQLSERVER:
            //        result = new SQLData(strConnect);
            //        break;
            //    //case Data.DATABASETYPE.ORACLE:
            //    //    result = new OracleData(bolIsCrypt ? strConnect : Data.Encrypt(strConnect, Data.strPassword3));
            //    //    break;
            //    case Data.DATABASETYPE.MySQL:
            //        result = new MySQLData(strConnect);
            //        break;
            //    //case Data.DATABASETYPE.MsAccess:
            //    //    result = new AccessData(bolIsCrypt ? strConnect : Data.Encrypt(strConnect, Data.strPassword3));
            //    //    break;
            //    default:
            //        result = null;
            //        break;
            //}
            return result;

        }

        public void AddParameter(string strParameterName, object objValue)
        {
            // objSqlCommand.Parameters.Add(strParameterName);
            objSqlCommand.Parameters.AddWithValue(strParameterName, objValue);
        }

        public void CreateNewStoredProcedure(string strStoreProName)
        {
            objSqlCommand = new SqlCommand(strStoreProName, objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
        }

        public bool Disconnect()
        {
            if (objSqlConnection != null)
            {
                objSqlConnection.Close();
                return objSqlConnection.State == ConnectionState.Closed;
            }

            return false;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();

            if (objSqlCommand != null)
                objSqlCommand.Dispose();

            if (objSqlConnection != null)
                objSqlConnection.Dispose();
        }

        public int ExecNonQuery()
        {
            return objSqlCommand.ExecuteNonQuery();
        }

        public object ExecuteScalar()
        {
            return objSqlCommand.ExecuteScalar();
        }

        public DataTable ExecStoreToDataTable()
        {
            IDataReader objdataReader = objSqlCommand.ExecuteReader();

            DataTable objDataTable = new DataTable();

            objDataTable.Load(objdataReader);

            return objDataTable;
        }

        object objLock = new object();

        public int ExecNonQueryWithParam(string strStoreProName, Dictionary<string, string> dicValue)
        {
            int intErrorCode = 0;
            lock (objLock)
            {
                objSqlCommand = new SqlCommand(strStoreProName, objSqlConnection);
                objSqlCommand.CommandType = CommandType.StoredProcedure;
                if (dicValue != null && dicValue.Count > 0)
                {
                    foreach (KeyValuePair<string, string> objItem in dicValue)
                    {
                        objSqlCommand.Parameters.AddWithValue(objItem.Key, objItem.Value);
                    }
                }

                intErrorCode = objSqlCommand.ExecuteNonQuery();
            }

            return intErrorCode;

        }


        public string ExecStoreToString()
        {
            object objValue = objSqlCommand.ExecuteScalar();

            return "";
        }

        public bool IsConnected()
        {
            if (objSqlConnection == null)
                return false;
            return objSqlConnection.State == ConnectionState.Open;
        }

        public bool Connect()
        {
            lock (objLock)
            {
                if (objSqlConnection == null)
                {
                    objSqlConnection = new SqlConnection(strConnect);
                }

                if (objSqlConnection.State != ConnectionState.Open)
                {
                    objSqlConnection.Open();
                }
                return objSqlConnection.State == ConnectionState.Open;
            }
        }
    }
}
