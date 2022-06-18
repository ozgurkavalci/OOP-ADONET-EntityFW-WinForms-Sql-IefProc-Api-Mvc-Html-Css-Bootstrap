using System;
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
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();    
            urunler.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subeler subeler = new Subeler();
            subeler.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Raporlar raporlar= new Raporlar();  
            raporlar.Show();
            this.Hide();
        }
    }
}
