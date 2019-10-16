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
using System.Windows.Forms.DataVisualization.Charting;


namespace MainMenu
{
    public partial class grafico : Form
    {
        #region Global Vars   
        ConectionClass.DBConnectionClass connectBBDD = new ConectionClass.DBConnectionClass();
        DataSet dts;
        DataTable data;
        SqlCommand command = new SqlCommand();
        Series x = new Series();
        Series y = new Series();
        DateTime[] setsdate;
        DateTime date;
        public string query = "select * from graficoMoney";
        double[] setstotal;        
        double movement = 0;
        double total = 0;
        int i;      
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
            dts = connectBBDD.graphdata();
            data = dts.Tables[0];
            fillChar();
        }
        private void insertData()
        {
            DataRow rows = data.NewRow();                  
            rows["total"] = calculGraph();
            rows["date"] = txtdate.Text;
            rows["description"] = txtdescrip.Text;
            rows["bankingmovement"] = txtmovement.Text;
            data.Rows.Add(rows);
            connectBBDD.update(dts, query);
        }     
        private double calculGraph()
        {
            double _calculGraph = 0;                        
            foreach (DataRow row in data.Rows)
            {
                movement = Convert.ToDouble(txtmovement.Text);
                _calculGraph = Convert.ToDouble(row["total"]);
                for (i = 0; i < 1; i++)
                {
                    _calculGraph += movement;                   
                }            
            }            
            return _calculGraph;
        }
        private string fillChar()
        {
            string _fillChar = "";
            foreach (DataRow row in data.Rows)
            {
                total = Convert.ToDouble(row["total"]);
                date = Convert.ToDateTime(row["date"]);
                //Series x = grafMoney.Series.Add(total.ToString());
                Series y = grafMoney.Series.Add(date.ToString());
                y.Label = total.ToString();
                y.Points.Add(total);
               
            }

            

            return _fillChar;
        }
        #endregion Methods     

        #region Events
        private void butUpdate_Click(object sender, EventArgs e)
        {
            insertData();
        }
        #endregion Events
    }
}
 //coger mes de la cadena fecha
 //enum para los meses
 //ir sumando según el mes