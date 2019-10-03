using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class grafico : Form
    {
        #region Variables globales
        ConectionClass.DBConnectionClass connect = new ConectionClass.DBConnectionClass();
        #endregion Variables globales
        public grafico()
        {
            InitializeComponent();
        }

        private void grafico_Load(object sender, EventArgs e)
        {
            
        }
    }
}
