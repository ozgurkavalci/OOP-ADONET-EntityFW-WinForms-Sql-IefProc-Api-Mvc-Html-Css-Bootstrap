﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Maas_sonrası_yeni_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            //groupbox1.Visible=False;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            int adet=Convert.ToInt32(numericUpDown1.Value);
            int fiyat=Convert.ToInt32(textBox1.Text);
            int sonuc = adet * fiyat;

            textBox2.Text=sonuc.ToString();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com.tr");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }
    }
}
