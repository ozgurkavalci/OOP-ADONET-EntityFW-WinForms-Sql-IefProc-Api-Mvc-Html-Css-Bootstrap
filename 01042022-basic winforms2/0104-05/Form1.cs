using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0104_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apartmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apartman apt = new Apartman();
            apt.Show();
            this.Hide();
        }
    }
}
