﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapçı
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
