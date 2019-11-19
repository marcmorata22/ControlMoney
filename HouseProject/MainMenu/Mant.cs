using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controlTxt;

namespace MainMenu
{
    public partial class Mant : Form
    {
        #region Global Vars  
        DataSet dts;
        ConectionClass.DBConnectionClass connectBBDD = new ConectionClass.DBConnectionClass();
        sdstxtbox txtbox;
        private bool news = false;
        public const string query = "select * from graficoMoney";
        public const string id = "id";
        #endregion Global Vars  

        #region Builder
        public Mant()
        {
            InitializeComponent();
        }
        #endregion Builder

        #region Events
        private void Mant_Load(object sender, EventArgs e)
        {
            txtbox = new sdstxtbox();
            dts = connectBBDD.graphdata();
            RellenarGrid(dts);
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!news)
                {
                    connectBBDD.update(dts, query);
                }
                else
                {
                    AñadirFila();
                    connectBBDD.update(dts, query);
                    BindDades();
                }
            }
            catch (DBConcurrencyException)
            {
                news = false;
                BindDades();
            }
        }
        private void butInsert_Click(object sender, EventArgs e)
        {
            news = true;
            QuitarBindDades();
        }
        #endregion Events        

        #region Methods             
        public void RellenarGrid(DataSet dts)
        {
            GridMant.DataSource = dts.Tables[0];
            this.GridMant.Columns[id].Visible = false;
            BindDades();
        }
        private void BindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is sdstxtbox)
                {
                    ((sdstxtbox)sdsControl).DataBindings.Clear();
                    ((sdstxtbox)sdsControl).DataBindings.Add("Text", dts.Tables[0], ((sdstxtbox)sdsControl).ColumnName.ToString());
                    ((sdstxtbox)sdsControl).Validated += new EventHandler(Validar);
                }
            }
        }
        private void QuitarBindDades()
        {
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is sdstxtbox)
                {
                    ((sdstxtbox)sdsControl).DataBindings.Clear();
                    sdsControl.Text = "";
                }
            }
        }
        private void AñadirFila()
        {
            string nomCamp = "";
            DataRow dr = dts.Tables[0].NewRow();
            foreach (Control sdsControl in this.Controls)
            {
                if (sdsControl is sdstxtbox)
                {
                    nomCamp = ((sdstxtbox)sdsControl).ColumnName;
                    dr[nomCamp] = sdsControl.Text;
                }
            }
            dts.Tables[0].Rows.Add(dr);
        }
        public void Validar(object sender, EventArgs e)
        {
            if (!news)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }
        #endregion Methods
        
    }
}
