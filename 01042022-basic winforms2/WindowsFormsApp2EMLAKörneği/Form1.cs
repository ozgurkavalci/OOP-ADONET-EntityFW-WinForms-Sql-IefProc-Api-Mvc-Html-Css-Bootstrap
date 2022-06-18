using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2EMLAKörneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apartmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apartmanbil git=new Apartmanbil();
            git.Show();
            this.Hide();

        }

        private void villaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 villa=new Form2();    
            villa.Show();
            this.Hide();
        }

        private void dubleksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dubleks duble=new Dubleks();    
            duble.Show();
            this.Hide();
        }
    }
}
