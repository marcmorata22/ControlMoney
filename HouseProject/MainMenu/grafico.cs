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
        ConectionClass.DBConnectionClass connectBBDD = new ConectionClass.DBConnectionClass();
        DataSet dts;
        DataTable data;
        SqlCommand command = new SqlCommand();
        DateTime date;
        public string query = "select * from graficoMoney";
        string description;
        double movement = 0;             
        int i;
        
       
        #endregion Global Vars

        #region Builder
        public grafico()
        {
            InitializeComponent();
        }
        #endregion Builder

        #region Events
        private void butUpdate_Click(object sender, EventArgs e)
        {

        }
        #endregion Events

        #region Methods
        public void grafico_Load(object sender, EventArgs e)
        {
            dts = connectBBDD.graphdata();
            data = dts.Tables[0];
            insertData();
        }

        private void insertData()
        {
            DataRow rows = data.NewRow();
            rows["total"] = calculGraph();
            data.Rows.Add(rows);
            connectBBDD.update(dts, query);
        }       
       
        private double calculGraph()
        {
            double _calculGraph = 0;                        
            foreach (DataRow row in data.Rows)
            {         
                movement = Convert.ToDouble(row["bankingmovement"]);
                _calculGraph = Convert.ToDouble(row["total"]);
                for (i = 0; i < 1; i++)
                {
                    _calculGraph += movement;                   
                }            
            }            
            return _calculGraph;
        }
        #endregion Methods        
    }
}
 //coger mes de la cadena fecha
 //enum para los meses
 //ir sumando según el mes