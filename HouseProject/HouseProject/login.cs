using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HouseProject
{
    public partial class login : Form
    {
        #region Global Vars 
        DataSet dts;
        ConectionClass.DBConnectionClass connectBBDD = new ConectionClass.DBConnectionClass();
        Form menu = new MainMenu.Menu();
        int i = 0;
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
        private void txtPassw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAcces();
            }
        }
        #endregion Events

        #region Methods
        private void LoginAcces()
        {
            try
            {          
                
                dts = connectBBDD.ComprobarUser(txtSerial.Text, txtPassw.Text);
                if (dts.Tables[0].Rows.Count == 1)
                {
                    menu.Show();
                }
                else
                {
                    errorProvider.SetError(txtPassw, "Credentials Error");
                    if (i >= 10)
                    {
                        System.Diagnostics.Process.Start("Reset.vbs");
                    }
                    i++;
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
