using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConectionClass
{  
    public class DBConnectionClass
    {
        #region Variables Globales
       
        public enum DBType
        {
            Access,
            SQL_Server
        }
        private DBType _DBType;        
        private string _ConnectionString;        
        OleDbConnection _AccessConnexion;     
        SqlConnection _SQLConnexion;
        #endregion

        #region Properties
        private string _pConnectionString;
        /// <summary>
        /// String que contiene el ConnectionString
        /// </summary>
        public string pConnectionString
        {
            get { return _pConnectionString; }
            set { _pConnectionString = value; }
        }

        #endregion

        #region Constructores
        
        public DBConnectionClass(DBType DBtype, string ConnectionString)
        {
            this._DBType = DBtype;
            this._pConnectionString = ConnectionString;
        }
        #endregion

        #region Methods        
        public void GetConnexionString()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings[pConnectionString].ConnectionString;
        }
       
        public void Connect()
        {
            GetConnexionString();
            if (_DBType == DBType.Access)
            {
                _AccessConnexion = new OleDbConnection(_ConnectionString);
                _AccessConnexion.Open();
            }
            else if (_DBType == DBType.SQL_Server)
            {
                _SQLConnexion = new SqlConnection(_ConnectionString);
                _SQLConnexion.Open();
            }
        }       
        #endregion
    }
}
