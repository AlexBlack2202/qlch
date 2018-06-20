using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace A4ULtd.Lib.Data
{
    [Serializable]
    internal class SQLData : Data, IData
    {
        private SqlConnection objConnection = null;

        private SqlCommand objCommand = null;

        private SqlTransaction objTransaction = null;

        private string strTableName = "TableNameDefault";

        IDbCommand IData.ICommand
        {
            get
            {
                return this.objCommand;
            }
            set
            {
                this.objCommand = (SqlCommand)value;
            }
        }

        IDbTransaction IData.ITransaction
        {
            get
            {
                return this.objTransaction;
            }
            set
            {
                this.objTransaction = (SqlTransaction)value;
            }
        }

        IDbConnection IData.IConnection
        {
            get
            {
                return this.objConnection;
            }
            set
            {
                this.objConnection = (SqlConnection)value;
            }
        }

        public SQLData()
        {
        }

        public SQLData(string strConnect)
        {
            this.strConnect = strConnect;
        }

        ~SQLData()
        {
            if (this.IsConnected())
            {
                this.Disconnect();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Connect()
        {
            bool result;
            if (this.IsConnected())
            {
                result = true;
            }
            else
            {
                if (this.objConnection == null)
                {
                    this.objConnection = new SqlConnection(this.strConnect);
                }
                this.objConnection.Open();
                result = true;
            }
            return result;
        }

        public bool Disconnect()
        {
            bool result;
            try
            {
                if (this.objCommand != null)
                {
                    this.objCommand.Dispose();
                }
                this.objConnection.Close();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public bool IsConnected()
        {
            return this.objConnection != null && this.objConnection.State == ConnectionState.Open;
        }

        private SqlCommand SetCommand(string strSQL)
        {
            if (this.objTransaction == null)
            {
                this.objCommand = new SqlCommand(strSQL, this.objConnection);
            }
            else
            {
                this.objCommand = new SqlCommand(strSQL, this.objConnection, this.objTransaction);
            }
            return this.objCommand;
        }

        private SqlDataAdapter SetDataAdapter(string strSQL)
        {
            return new SqlDataAdapter(strSQL, this.objConnection);
        }

        private SqlDataAdapter SetDataAdapter(SqlCommand objCommand)
        {
            return new SqlDataAdapter(objCommand);
        }

        private SqlDbType GetSQLDataType(Globals.DATATYPE enDataType)
        {
            SqlDbType result = SqlDbType.Int;
            switch (enDataType)
            {
                case Globals.DATATYPE.NUMBER:
                    result = SqlDbType.Int;
                    break;
                case Globals.DATATYPE.CHAR:
                    result = SqlDbType.Char;
                    break;
                case Globals.DATATYPE.VARCHAR:
                    result = SqlDbType.VarChar;
                    break;
                case Globals.DATATYPE.NVARCHAR:
                    result = SqlDbType.NVarChar;
                    break;
                case Globals.DATATYPE.NTEXT:
                    result = SqlDbType.NText;
                    break;
                case Globals.DATATYPE.BINARY:
                    result = SqlDbType.Binary;
                    break;
            }
            return result;
        }

        public void BeginTransaction()
        {
            if (!this.IsConnected())
            {
                this.Connect();
            }
            this.objTransaction = this.objConnection.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if (this.objTransaction != null)
            {
                this.objTransaction.Commit();
            }
        }

        public void RollBackTransaction()
        {
            if (this.objTransaction != null)
            {
                this.objTransaction.Rollback();
                this.objTransaction = null;
            }
        }

        public void CreateNewSqlText(string strSQL)
        {
            this.objCommand = this.SetCommand(strSQL);
            this.objCommand.CommandType = CommandType.Text;
        }

        public IDataReader ExecQueryToDataReader(string strSQL)
        {
            return this.SetCommand(strSQL).ExecuteReader();
        }

        public Hashtable ExecQueryToHashtable(string strSQL)
        {
            IDataReader dataReader = this.ExecQueryToDataReader(strSQL);
            Hashtable result = Globals.ConvertHashTable(dataReader);
            dataReader.Close();
            return result;
        }

        public ArrayList ExecQueryToArrayList(string strSQL)
        {
            IDataReader dataReader = this.ExecQueryToDataReader(strSQL);
            ArrayList result = Globals.ConvertArrayList(dataReader);
            dataReader.Close();
            return result;
        }

        public string ExecQueryToString(string strSQL)
        {
            object obj = this.SetCommand(strSQL).ExecuteScalar();
            string result;
            if (obj == null)
            {
                result = string.Empty;
            }
            else
            {
                result = obj.ToString().Trim();
            }
            return result;
        }

        public byte[] ExecQueryToBinary(string strSQL)
        {
            return (byte[])this.SetCommand(strSQL).ExecuteScalar();
        }

        public void ExecUpdate(string strSQL)
        {
            this.SetCommand(strSQL).ExecuteNonQuery();
        }

        public void ExecUpdate(string strSQL, params IDataParameter[] objParameters)
        {
            this.SetCommand(strSQL);
            for (int i = 0; i < objParameters.Length; i++)
            {
                IDataParameter value = objParameters[i];
                this.objCommand.Parameters.Add(value);
            }
            this.objCommand.ExecuteNonQuery();
        }

        public void ExecUpdate(string strSQL, ArrayList arrParameters)
        {
            this.SetCommand(strSQL);
            foreach (IDataParameter value in arrParameters)
            {
                this.objCommand.Parameters.Add(value);
            }
            this.objCommand.ExecuteNonQuery();
        }

        public IDataAdapter ExecQueryToDataAdapter(string strSQL)
        {
            return this.SetDataAdapter(strSQL);
        }

        public DataTable ExecQueryToDataTable(string strSQL)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(strSQL).Fill(dataSet);
            return dataSet.Tables[0];
        }

        public DataSet ExecQueryToDataSet(string strSQL)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(strSQL).Fill(dataSet);
            return dataSet;
        }

        public void CreateNewStoredProcedure(string strStoreProName)
        {
            this.strTableName = strStoreProName;
            this.objCommand = this.SetCommand(strStoreProName);
            this.objCommand.CommandType = CommandType.StoredProcedure;
        }

        public void CreateNewStoredProcedure(string strStoreProName, int intTimeOut)
        {
            this.strTableName = strStoreProName;
            this.objCommand = this.SetCommand(strStoreProName);
            this.objCommand.CommandTimeout = intTimeOut;
            this.objCommand.CommandType = CommandType.StoredProcedure;
        }

        public void AddParameter(string strParameterName, object objValue)
        {
            this.objCommand.Parameters.AddWithValue(strParameterName, objValue);
        }

        public void AddParameter(string strParameterName, object objValue, Globals.DATATYPE enDataType)
        {
            SqlParameter sqlParameter = new SqlParameter(strParameterName, this.GetSQLDataType(enDataType));
            sqlParameter.Value = objValue;
            this.objCommand.Parameters.Add(sqlParameter);
        }

        public void AddParameter(params object[] objArrParam)
        {
            for (int i = 0; i < objArrParam.Length / 2; i++)
            {
                this.AddParameter(objArrParam[i * 2].ToString().Trim(), objArrParam[i * 2 + 1]);
            }
        }

        public void AddParameter(Hashtable hstParameter)
        {
            IDictionaryEnumerator enumerator = hstParameter.GetEnumerator();
            while (enumerator.MoveNext())
            {
                this.AddParameter(enumerator.Key.ToString(), enumerator.Value);
            }
        }

        public IDataReader ExecStoreToDataReader()
        {
            return this.ExecStoreToDataReader("");
        }

        public IDataReader ExecStoreToDataReader(string strOutParameter)
        {
            return this.objCommand.ExecuteReader();
        }

        public Hashtable ExecStoreToHashtable()
        {
            return this.ExecStoreToHashtable("");
        }

        public Hashtable ExecStoreToHashtable(string strOutParameter)
        {
            return Globals.ConvertHashTable(this.objCommand.ExecuteReader());
        }

        public ArrayList ExecStoreToArrayList()
        {
            return this.ExecStoreToArrayList("");
        }

        public ArrayList ExecStoreToArrayList(string strOutParameter)
        {
            return Globals.ConvertArrayList(this.objCommand.ExecuteReader());
        }

        public string ExecStoreToString()
        {
            return this.ExecStoreToString("");
        }

        public string ExecStoreToString(string strOutParameter)
        {
            object obj = this.objCommand.ExecuteScalar();
            string result;
            if (obj == null)
            {
                result = "";
            }
            else
            {
                result = obj.ToString().Trim();
            }
            return result;
        }

        public byte[] ExecStoreToBinary()
        {
            return this.ExecStoreToBinary("");
        }

        public byte[] ExecStoreToBinary(string strOutParameter)
        {
            return (byte[])this.objCommand.ExecuteScalar();
        }

        public int ExecNonQuery()
        {
            return this.objCommand.ExecuteNonQuery();
        }

        public IDataAdapter ExecStoreToDataAdapter()
        {
            return this.ExecStoreToDataAdapter("");
        }

        public IDataAdapter ExecStoreToDataAdapter(string strOutParameter)
        {
            return this.SetDataAdapter(this.objCommand);
        }

        public  DataTable ExecStoreToDataTable()
        {
            return this.ExecStoreToDataTable("");
        }

        public DataTable ExecStoreToDataTable(string strOutParameter)
        {
            DataTable dataTable = new DataTable();
            this.SetDataAdapter(this.objCommand).Fill(dataTable);
            return dataTable;
        }

        public DataSet ExecStoreToDataSet()
        {
            return this.ExecStoreToDataSet(new string[]
            {
                ""
            });
        }

        public DataSet ExecStoreToDataSet(params string[] strOutParameter)
        {
            DataSet dataSet = new DataSet();
            this.SetDataAdapter(this.objCommand).Fill(dataSet);
            return dataSet;
        }
    }
}
