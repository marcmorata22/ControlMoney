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
        double movement = 0;
        double money = 0;
        double total = 0;
        int i;
        DateTime date;
        #endregion Global Vars

        #region Builder
        public grafico()
        {
            InitializeComponent();
        }
        #endregion Builder

        #region Methods
        public void grafico_Load(object sender, EventArgs e)
        {
            calculgraph();
        }
        private double calculgraph()
        {
            double _calculgraph = 0;
            dts = connectBBDD.graphdata();
            data = dts.Tables[0];            
            foreach (DataRow row in data.Rows)
            {               
                movement = Convert.ToDouble(row["bankingmovement"]);
                date = Convert.ToDateTime(row["date"]);
                for (i = 0; i < 1; i++)
                {
                    money += movement;                    
                }            
            }
            return _calculgraph;
        }
        #endregion Methods
    }
}
