using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void kullanıcıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KK go=new KK();
            go.Show();
            this.Hide();
        }

        private void bankaHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH go=new KH();
            go.Show();
            this.Hide();
        }
    }
}
