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
        #region Global Vars 
        DataSet dts;
        ConectionClass.DBConnectionClass connectBBDD = new ConectionClass.DBConnectionClass();
        Form menu = new MainMenu.Menu();
        #endregion Global Vars

        #region constructor
        public login()
        {
            InitializeComponent();
        }
        #endregion constructor

        #region Events
        public void butLogin_Click(object sender, EventArgs e)
        {
            LoginAcces();
        }
        #endregion Events

        #region Methods
        private void LoginAcces()
        {
            try
            {
                labFail.Visible = false;
                dts = connectBBDD.ComprobarUser(txtSerial.Text, txtPassw.Text);
                if (dts.Tables[0].Rows.Count == 1)
                {
                    menu.Show();
                    MessageBox.Show("Welcome");
                }
                else
                {
                    labFail.Visible = true;                   
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
