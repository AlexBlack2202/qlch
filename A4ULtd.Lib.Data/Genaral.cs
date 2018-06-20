using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4ULtd.Lib.Data
{
    public interface IData
    {
        IDbConnection IConnection
        {
            get;
            set;
        }

        IDbCommand ICommand
        {
            get;
            set;
        }

        IDbTransaction ITransaction
        {
            get;
            set;
        }

        void Dispose();

        bool Connect();

        bool Disconnect();

        bool IsConnected();

        void BeginTransaction();

        void CommitTransaction();

        void RollBackTransaction();

        IDataReader ExecQueryToDataReader(string strSQL);

        Hashtable ExecQueryToHashtable(string strSQL);

        ArrayList ExecQueryToArrayList(string strSQL);

        string ExecQueryToString(string strSQL);

        byte[] ExecQueryToBinary(string strSQL);

        void ExecUpdate(string strSQL);

        void ExecUpdate(string strSQL, params IDataParameter[] objParameters);

        void ExecUpdate(string strSQL, ArrayList arrParameters);

        IDataAdapter ExecQueryToDataAdapter(string strSQL);

        DataTable ExecQueryToDataTable(string strSQL);

        DataSet ExecQueryToDataSet(string strSQL);

        void CreateNewSqlText(string strSQL);

        void CreateNewStoredProcedure(string strStoreProName);

        void CreateNewStoredProcedure(string strStoreProName, int intTimeOut);

        void AddParameter(string strParameterName, object objValue);

        void AddParameter(string strParameterName, object objValue, Globals.DATATYPE enDataType);

        void AddParameter(params object[] objArrParam);

        void AddParameter(Hashtable hstParameter);

        IDataReader ExecStoreToDataReader();

        IDataReader ExecStoreToDataReader(string strOutParameter);

        Hashtable ExecStoreToHashtable();

        Hashtable ExecStoreToHashtable(string strOutParameter);

        ArrayList ExecStoreToArrayList();

        ArrayList ExecStoreToArrayList(string strOutParameter);

        string ExecStoreToString();

        string ExecStoreToString(string strOutParameter);

        byte[] ExecStoreToBinary();

        byte[] ExecStoreToBinary(string strOutParameter);

        int ExecNonQuery();

        IDataAdapter ExecStoreToDataAdapter();

        IDataAdapter ExecStoreToDataAdapter(string strOutParameter);

        DataTable ExecStoreToDataTable();

        DataTable ExecStoreToDataTable(string strOutParameter);

        DataSet ExecStoreToDataSet();

        DataSet ExecStoreToDataSet(params string[] strOutParameter);
    }
}
