using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HouseProject
{
    public partial class login : Form
    {
        #region Variables Globales 
        DataSet dts;
        ConectionClass.DBConnectionClass connect = new ConectionClass.DBConnectionClass();       
        #endregion Variables Globales 

        #region constructor
        public login()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region Events
        private void butLogin_Click(object sender, EventArgs e)
        {
            LoginAcces();
        }
        #endregion Events

        #region Methods
        public void LoginAcces()
        {
            try
            {
                dts = connect.ComprobarUser(txtSerial.Text, txtPassw.Text);
                if (dts.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Welcome");
                }

            }
            catch (Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
        }
        #endregion Methods
    }
}
