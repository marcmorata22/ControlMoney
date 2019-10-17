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
        string[] listMonth = { "enero", "febrero", "marzo", "abril","mayo","junio","julio","agosto",
        "septiembre","octubre","noviembre","diciembre"};        
        DataSet dts;
        DataTable data;
        SqlCommand command = new SqlCommand();
        Series y = new Series();
        string query = "select * from graficoMoney";
        string month = "";
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
            try
            {
                dts = connectBBDD.graphdata();
                data = dts.Tables[0];
                fillChar();
            }
            catch(Exception Ge)
            {
                MessageBox.Show(Ge.Message);
            }
        }
        private string fillChar()
        {
            string _fillChar = "";           
            foreach (DataRow row in data.Rows)
            {
                total = Convert.ToDouble(row["total"]);
                month = Convert.ToString(row["month"]);                
                if (listMonth.Contains(month))
                {
                    y = grafMoney.Series.Add(month.ToString());
                    y.Points.Add(total);
                }               
            }
            return _fillChar;
        }        
        private void insertData()
        {
            foreach (DataRow row in data.Rows)
            {
                movement = Convert.ToDouble(txtmovement.Text);
                total = Convert.ToDouble(row["total"]);
            }
            DataRow rows = data.NewRow();                  
            rows["total"] = calculGraph(total,movement);
            rows["date"] = txtdate.Text;
            rows["description"] = txtdescrip.Text;
            rows["bankingmovement"] = txtmovement.Text;
            data.Rows.Add(rows);
            connectBBDD.update(dts, query);
        }     
        private double calculGraph(double total, double movement)
        {
            double _calculGraph = total;

            for (i = 0; i < 1; i++)
                {
                    _calculGraph += movement;                   
                }                                    
            return _calculGraph;
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