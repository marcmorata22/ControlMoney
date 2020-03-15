using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConectionClass
{
    public class DBConnectionClass
    {
        #region Global Vars           
        private string query;       
        #endregion Global Vars  


        #region Methods
        

        
        //public DataSet ComprobarUser(string serial_num, string passw)
        //{
        //    Connect();
        //    query = "Select serial_num, password from users where serial_num='" + serial_num + "'AND password='" + passw + "'";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);            
        //    adapter.Fill(dts);
        //    _SQLConnexion.Close();
        //    return dts;
        //}
        //public DataSet graphdata()
        //{
        //    Connect();
        //    query = "Select * From graficoMoney";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, _ConnectionString);           
        //    adapter.Fill(dts);
        //    _SQLConnexion.Close();
        //    return dts;
        //}
        //public void update(DataSet dts, string query)
        //{
        //    try
        //    {
        //        Connect();
        //        SqlDataAdapter adapterDts = new SqlDataAdapter(query, _ConnectionString);
        //        SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adapterDts);

        //        adapterDts.Update(dts);
        //    }
        //    catch (OleDbException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        #endregion
    }
}
