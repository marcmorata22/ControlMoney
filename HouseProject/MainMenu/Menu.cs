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
        Form graph = new MainMenu.grafico();
        public Menu()
        {
            InitializeComponent();
        }

        private void butgrafico_Click(object sender, EventArgs e)
        {
            graph.Show();
        }
    }
}