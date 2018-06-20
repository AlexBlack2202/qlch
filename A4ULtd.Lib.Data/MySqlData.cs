using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4ULtd.Lib.Data
{
    //[Serializable]
    //public class MySQLData : Data, IData
    //{
    //    private MySqlConnection objConnection = null;

    //    private MySqlCommand objCommand = null;

    //    private MySqlTransaction objTransaction = null;

    //    private string strTableName = "TableNameDefault";

    //    IDbCommand IData.ICommand
    //    {
    //        get
    //        {
    //            return this.objCommand;
    //        }
    //        set
    //        {
    //            this.objCommand = (MySqlCommand)value;
    //        }
    //    }

    //    IDbTransaction IData.ITransaction
    //    {
    //        get
    //        {
    //            return this.objTransaction;
    //        }
    //        set
    //        {
    //            this.objTransaction = (MySqlTransaction)value;
    //        }
    //    }

    //    IDbConnection IData.IConnection
    //    {
    //        get
    //        {
    //            return this.objConnection;
    //        }
    //        set
    //        {
    //            this.objConnection = (MySqlConnection)value;
    //        }
    //    }

    //    public MySQLData()
    //    {
    //    }

    //    public MySQLData(string strConnect)
    //    {
    //        this.strConnect = strConnect;
    //    }

    //    ~MySQLData()
    //    {
    //        if (this.IsConnected())
    //        {
    //            this.Disconnect();
    //        }
    //    }

    //    public void Dispose()
    //    {
    //        GC.SuppressFinalize(this);
    //    }

    //    public bool Connect()
    //    {
    //        bool result;
    //        if (this.IsConnected())
    //        {
    //            result = true;
    //        }
    //        else
    //        {
    //            if (this.objConnection == null)
    //            {
    //                this.objConnection = new MySqlConnection(this.strConnect);
    //            }
    //            this.objConnection.Open();
    //            result = true;
    //        }
    //        return result;
    //    }

    //    public bool Disconnect()
    //    {
    //        bool result;
    //        try
    //        {
    //            if (this.objCommand != null)
    //            {
    //                this.objCommand.Dispose();
    //            }
    //            this.objConnection.Close();
    //            result = true;
    //        }
    //        catch
    //        {
    //            result = false;
    //        }
    //        return result;
    //    }

    //    public bool IsConnected()
    //    {
    //        return this.objConnection != null && this.objConnection.State == ConnectionState.Open;
    //    }

    //    private MySqlCommand SetCommand(string strSQL)
    //    {
    //        if (this.objTransaction == null)
    //        {
    //            this.objCommand = new MySqlCommand(strSQL, this.objConnection);
    //        }
    //        else
    //        {
    //            this.objCommand = new MySqlCommand(strSQL, this.objConnection, this.objTransaction);
    //        }
    //        return this.objCommand;
    //    }

    //    private MySqlDataAdapter SetDataAdapter(string strSQL)
    //    {
    //        return new MySqlDataAdapter(strSQL, this.objConnection);
    //    }

    //    private MySqlDataAdapter SetDataAdapter(MySqlCommand objCommand)
    //    {
    //        return new MySqlDataAdapter(objCommand);
    //    }

    //    private MySqlDbType GetMySQLDataType(Globals.DATATYPE enDataType)
    //    {
    //        MySqlDbType result = MySqlDbType.Int32;
    //        switch (enDataType)
    //        {
    //            case Globals.DATATYPE.NUMBER:
    //                result = MySqlDbType.Int32;
    //                break;
    //            case Globals.DATATYPE.CHAR:
    //                result = MySqlDbType.VarChar;
    //                break;
    //            case Globals.DATATYPE.VARCHAR:
    //                result = MySqlDbType.VarChar;
    //                break;
    //            case Globals.DATATYPE.NVARCHAR:
    //                result = MySqlDbType.VarChar;
    //                break;
    //            case Globals.DATATYPE.NTEXT:
    //                result = MySqlDbType.LongText;
    //                break;
    //            case Globals.DATATYPE.BINARY:
    //                result = MySqlDbType.Binary;
    //                break;
    //            case Globals.DATATYPE.BLOB:
    //                result = MySqlDbType.Blob;
    //                break;
    //        }
    //        return result;
    //    }

    //    public void BeginTransaction()
    //    {
    //        if (!this.IsConnected())
    //        {
    //            this.Connect();
    //        }
    //        this.objTransaction = this.objConnection.BeginTransaction();
    //    }

    //    public void CommitTransaction()
    //    {
    //        if (this.objTransaction != null)
    //        {
    //            this.objTransaction.Commit();
    //        }
    //    }

    //    public void RollBackTransaction()
    //    {
    //        if (this.objTransaction != null)
    //        {
    //            this.objTransaction.Rollback();
    //            this.objTransaction = null;
    //        }
    //    }

    //    public void CreateNewSqlText(string strSQL)
    //    {
    //        this.objCommand = this.SetCommand(strSQL);
    //        this.objCommand.CommandType = CommandType.Text;
    //    }

    //    public IDataReader ExecQueryToDataReader(string strSQL)
    //    {
    //        return this.SetCommand(strSQL).ExecuteReader();
    //    }

    //    public Hashtable ExecQueryToHashtable(string strSQL)
    //    {
    //        IDataReader dataReader = this.ExecQueryToDataReader(strSQL);
    //        Hashtable result = Globals.ConvertHashTable(dataReader);
    //        dataReader.Close();
    //        return result;
    //    }

    //    public ArrayList ExecQueryToArrayList(string strSQL)
    //    {
    //        IDataReader dataReader = this.ExecQueryToDataReader(strSQL);
    //        ArrayList result = Globals.ConvertArrayList(dataReader);
    //        dataReader.Close();
    //        return result;
    //    }

    //    public string ExecQueryToString(string strSQL)
    //    {
    //        object obj = this.SetCommand(strSQL).ExecuteScalar();
    //        string result;
    //        if (obj == null)
    //        {
    //            result = string.Empty;
    //        }
    //        else
    //        {
    //            result = obj.ToString().Trim();
    //        }
    //        return result;
    //    }

    //    public byte[] ExecQueryToBinary(string strSQL)
    //    {
    //        return (byte[])this.SetCommand(strSQL).ExecuteScalar();
    //    }

    //    public void ExecUpdate(string strSQL)
    //    {
    //        this.SetCommand(strSQL).ExecuteNonQuery();
    //    }

    //    public void ExecUpdate(string strSQL, params IDataParameter[] objParameters)
    //    {
    //        this.SetCommand(strSQL);
    //        for (int i = 0; i < objParameters.Length; i++)
    //        {
    //            IDataParameter value = objParameters[i];
    //            this.objCommand.Parameters.Add(value);
    //        }
    //        this.objCommand.ExecuteNonQuery();
    //    }

    //    public void ExecUpdate(string strSQL, ArrayList arrParameters)
    //    {
    //        this.SetCommand(strSQL);
    //        foreach (IDataParameter value in arrParameters)
    //        {
    //            this.objCommand.Parameters.Add(value);
    //        }
    //        this.objCommand.ExecuteNonQuery();
    //    }

    //    public IDataAdapter ExecQueryToDataAdapter(string strSQL)
    //    {
    //        return this.SetDataAdapter(strSQL);
    //    }

    //    public DataTable ExecQueryToDataTable(string strSQL)
    //    {
    //        DataSet dataSet = new DataSet();
    //        this.SetDataAdapter(strSQL).Fill(dataSet);
    //        return dataSet.Tables[0];
    //    }

    //    public DataSet ExecQueryToDataSet(string strSQL)
    //    {
    //        DataSet dataSet = new DataSet();
    //        this.SetDataAdapter(strSQL).Fill(dataSet);
    //        return dataSet;
    //    }

    //    public void CreateNewStoredProcedure(string strStoreProName)
    //    {
    //        this.strTableName = strStoreProName;
    //        this.objCommand = this.SetCommand(strStoreProName);
    //        this.objCommand.CommandType = CommandType.StoredProcedure;
    //    }

    //    public void CreateNewStoredProcedure(string strStoreProName, int intTimeOut)
    //    {
    //        this.objCommand = this.SetCommand(strStoreProName);
    //        this.objCommand.CommandTimeout = intTimeOut;
    //        this.objCommand.CommandType = CommandType.StoredProcedure;
    //    }

    //    public void AddParameter(string strParameterName, object objValue)
    //    {
    //        var value = objValue;
    //        if (value == DBNull.Value)
    //            value = "";

    //        this.objCommand.Parameters.AddWithValue(strParameterName.Replace("@",string.Empty), value);
    //    }

    //    public void AddParameter(string strParameterName, object objValue, Globals.DATATYPE enDataType)
    //    {
    //        MySqlParameter mySqlParameter = new MySqlParameter(strParameterName.Replace("@", string.Empty), this.GetMySQLDataType(enDataType));
    //        mySqlParameter.Value = objValue;
    //        this.objCommand.Parameters.Add(mySqlParameter);
    //    }

    //    public void AddParameter(params object[] objArrParam)
    //    {
    //        for (int i = 0; i < objArrParam.Length / 2; i++)
    //        {
    //            this.AddParameter(objArrParam[i * 2].ToString().Trim(), objArrParam[i * 2 + 1]);
    //        }
    //    }

    //    public void AddParameter(Hashtable hstParameter)
    //    {
    //        IDictionaryEnumerator enumerator = hstParameter.GetEnumerator();
    //        while (enumerator.MoveNext())
    //        {
    //            this.AddParameter(enumerator.Key.ToString(), enumerator.Value);
    //        }
    //    }

    //    public IDataReader ExecStoreToDataReader()
    //    {
    //        return this.ExecStoreToDataReader("");
    //    }

    //    public IDataReader ExecStoreToDataReader(string strOutParameter)
    //    {
    //        return this.objCommand.ExecuteReader();
    //    }

    //    public Hashtable ExecStoreToHashtable()
    //    {
    //        return this.ExecStoreToHashtable("");
    //    }

    //    public Hashtable ExecStoreToHashtable(string strOutParameter)
    //    {
    //        return Globals.ConvertHashTable(this.objCommand.ExecuteReader());
    //    }

    //    public ArrayList ExecStoreToArrayList()
    //    {
    //        return this.ExecStoreToArrayList("");
    //    }

    //    public ArrayList ExecStoreToArrayList(string strOutParameter)
    //    {
    //        return Globals.ConvertArrayList(this.objCommand.ExecuteReader());
    //    }

    //    public string ExecStoreToString()
    //    {
    //        return this.ExecStoreToString("");
    //    }

    //    public string ExecStoreToString(string strOutParameter)
    //    {
    //        object obj = this.objCommand.ExecuteScalar();
    //        string result;
    //        if (obj == null)
    //        {
    //            result = "";
    //        }
    //        else
    //        {
    //            result = obj.ToString().Trim();
    //        }
    //        return result;
    //    }

    //    public byte[] ExecStoreToBinary()
    //    {
    //        return this.ExecStoreToBinary("");
    //    }

    //    public byte[] ExecStoreToBinary(string strOutParameter)
    //    {
    //        return (byte[])this.objCommand.ExecuteScalar();
    //    }

    //    public int ExecNonQuery()
    //    {
    //        return this.objCommand.ExecuteNonQuery();
    //    }

    //    public IDataAdapter ExecStoreToDataAdapter()
    //    {
    //        return this.ExecStoreToDataAdapter("");
    //    }

    //    public IDataAdapter ExecStoreToDataAdapter(string strOutParameter)
    //    {
    //        return this.SetDataAdapter(this.objCommand);
    //    }

    //    public DataTable ExecStoreToDataTable()
    //    {
    //        return this.ExecStoreToDataTable("");
    //    }

    //    public DataTable ExecStoreToDataTable(string strOutParameter)
    //    {
    //        DataTable dataTable = new DataTable(this.strTableName);
    //        this.SetDataAdapter(this.objCommand).Fill(dataTable);
    //        return dataTable;
    //    }

    //    public DataSet ExecStoreToDataSet()
    //    {
    //        return this.ExecStoreToDataSet(new string[]
    //        {
    //            ""
    //        });
    //    }

    //    public DataSet ExecStoreToDataSet(params string[] strOutParameter)
    //    {
    //        DataSet dataSet = new DataSet();
    //        this.SetDataAdapter(this.objCommand).Fill(dataSet);
    //        return dataSet;
    //    }
    //}
}
