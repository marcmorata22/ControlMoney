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
        #region Global Vars    
        private string _ConnectionString;
        private string query;
        SqlConnection _SQLConnexion;
        DataSet dtsCli = new DataSet();
        #endregion Global Vars  


        #region Methods        
        public void GetConnexionString()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["ConectionClass.Properties.Settings.MONEYBBDDConnectionString"].ConnectionString;
        }

        public void Connect()
        {
            GetConnexionString();
            _SQLConnexion = new SqlConnection(_ConnectionString);
            _SQLConnexion.Open();

        }
        public DataSet ComprobarUser(string serial_num, string passw)
        {
            Connect();
            query = "Select serial_num, password from users where serial_num='" + serial_num + "'AND password='" + passw + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);            
            adapter.Fill(dtsCli);
            _SQLConnexion.Close();
            return dtsCli;
        }
        public DataSet graphdata()
        {
            Connect();
            query = "Select * From graficoMoney";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);           
            adapter.Fill(dtsCli);
            _SQLConnexion.Close();
            return dtsCli;
        }
        #endregion
    }
}
