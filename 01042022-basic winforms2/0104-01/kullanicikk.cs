﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0104_01
{
    public partial class kullanicikk : Form
    {
        public kullanicikk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Görev : " + textBox1.Text);
            listBox1.Items.Add("Ünvan : " + textBox2.Text);
            listBox1.Items.Add("Maaş : "+textBox3.Text);
        }
    }
}
