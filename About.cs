﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace stock_management_system
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.Red;
        }

        private void label5_Leave(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Navy;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
