using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class grafico : Form
    {
        #region Global Vars
        DataSet dts;
        DataTable data;
        ConectionClass.DBConnectionClass connectBBDD = new ConectionClass.DBConnectionClass();
        SqlCommand command = new SqlCommand();
        

        #endregion Global Vars
        public grafico()
        {
            InitializeComponent();
        }

        private void grafico_Load(object sender, EventArgs e)
        {           
            dts = connectBBDD.graphdata();
            data = dts.Tables[0];
            string valor1 = "";

            foreach (DataRow row in data.Rows)
            {

                valor1 = Convert.ToString(row["ingresos"]);


            }
            lol.Text = valor1;

        }
    }
}
