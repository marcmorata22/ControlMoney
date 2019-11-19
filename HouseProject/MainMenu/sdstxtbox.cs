using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlTxt
{
    public partial class sdstxtbox : TextBox
    {
        public sdstxtbox()
        {
            InitializeComponent();           
        }

        String _Nom;
        public String Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }
        private String _ColumnName;
        public String ColumnName
        {
            get { return _ColumnName; }
            set { _ColumnName = value; }
        }
        private Boolean _Requerit;
        public Boolean Requerit
        {
            get { return _Requerit; }
            set
            {
                _Requerit = value;
            }
        }
        private String _NomTaula;

        public String NomTaula
        {
            get { return _NomTaula; }
            set
            {
                _NomTaula = value;
            }
        }
    }
}
