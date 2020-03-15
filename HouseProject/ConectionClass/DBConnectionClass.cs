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
        ControlMoneyEntities db = new ControlMoneyEntities();
        #endregion Global Vars  

        #region Methods
        public int getUser(string txtSerial, string txtPassw)
        {
            try
            {
                var _logins = (from l in db.logins
                               where l.username == txtSerial
                               where l.password == txtPassw
                               select l).Count();
                if (_logins == 1)
                {
                    return 1;
                }
            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
            return 0;
        }
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
