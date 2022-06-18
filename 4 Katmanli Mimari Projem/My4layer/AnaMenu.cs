using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My4layer
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Studyolar studyolar = new Studyolar();
            studyolar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Merkezler merkezler = new Merkezler();
            merkezler.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gelistiriciler gelistiriciler = new Gelistiriciler();
            gelistiriciler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Oyunlar oyunlar = new Oyunlar();
            oyunlar.Show();
            this.Hide();
        }
    }
}
