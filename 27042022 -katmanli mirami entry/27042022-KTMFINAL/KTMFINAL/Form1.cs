﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessORM.Entity;
using BusinessORM.Facade;
using System.Data.SqlClient;

namespace KTMFINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hizmetler hizmetler = new Hizmetler();
            hizmetler.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
