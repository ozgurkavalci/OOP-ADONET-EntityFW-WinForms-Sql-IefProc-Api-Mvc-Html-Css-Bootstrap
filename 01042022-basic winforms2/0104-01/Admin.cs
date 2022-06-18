using System;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void kullanıcıKaydıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanicikk go = new kullanicikk();
            go.Show();
            this.Hide();
        }

        private void bankaHaraketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kh go = new kh();
            go.Show();
            this.Hide();
        }
    }
}
