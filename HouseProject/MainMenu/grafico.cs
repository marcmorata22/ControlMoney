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
        Series y = new Series();
        string query = "select * from graficoMoney";
        string month = "";
        double movement = 0;
        double total = 0;   
        bool regMonth;
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
                fillGrid(dts);
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
            try
            {                
                DataRow rows = data.NewRow();
                foreach (DataRow row in data.Rows)
                {
                    movement = Convert.ToDouble(txtmovement.Text);
                    total = Convert.ToDouble(row["total"]);
                    month = Convert.ToString(row["month"]);
                    regMonth = writeMonth(month);
                    if (regMonth == true)
                    {
                        MessageBox.Show("Usted ha escrito una clave de mes repetida, si no es el último movimiento bancario del mes deje la casilla vacía.");
                        txtmonth.Text = "";
                        break;
                    }
                }                
                rows["total"] = calculGraph(total, movement);
                rows["date"] = txtdate.Text;               
                rows["description"] = txtdescrip.Text;
                rows["bankingmovement"] = txtmovement.Text;
                rows["month"] = txtmonth.Text;
                if (regMonth == false)
                {
                    data.Rows.Add(rows);
                    connectBBDD.update(dts, query);
                }
            }
            catch(Exception Ge)
            {
                MessageBox.Show(Ge.Message + ", Porfavor inserte datos correctos");
            }
        }    
        private bool writeMonth(string month)
        {
            bool _writeMonth = false;
            if (txtmonth.Text.Equals(month) && txtmonth.Text != "")
            {                
                _writeMonth = true;
            }
            return _writeMonth;
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
        private void fillGrid(DataSet dts)
        {
            dgvGraph.DataSource = dts.Tables[0];
            dgvGraph.Columns["id"].Visible = false;            
        }
        #endregion Methods     

        #region Events
        private void butUpdate_Click(object sender, EventArgs e)
        {
            insertData();
            fillGrid(dts);
            txtdate.Text = "";
            txtdescrip.Text = "";
            txtmonth.Text = "";
            txtmovement.Text = "";
        }
        private void txtmovement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }        
        #endregion Events
    }
}