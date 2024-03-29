﻿using System;
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
    public partial class Menu : Form
    {
        #region Builder
        public Menu()
        {
            InitializeComponent();
        }
        #endregion Builder

        #region Events
        private void butgrafico_Click(object sender, EventArgs e)
        {            
            Form graph = new MainMenu.grafico();
            graph.Show();
        }
        private void butMant_Click(object sender, EventArgs e)
        {
            Form Mant = new MainMenu.Mant();
            Mant.Show();
        }
        private void labExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion Events
    }
}
