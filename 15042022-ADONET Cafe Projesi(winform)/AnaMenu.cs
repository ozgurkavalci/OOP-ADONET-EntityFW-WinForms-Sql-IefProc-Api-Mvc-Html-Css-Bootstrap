using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _15042022_Pastane
{
    public partial class AnaMenu : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparisler siparisler = new Siparisler();   
            siparisler.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saticilar saticilar = new Saticilar();  
            saticilar.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();    
            urunler.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Raporlar raaporlar = new Raporlar();    
            raaporlar.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
