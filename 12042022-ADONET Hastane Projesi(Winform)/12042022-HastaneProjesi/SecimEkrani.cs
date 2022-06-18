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

namespace _12042022_HastaneProjesi
{
    public partial class SecimEkrani : Form
    {
        public SecimEkrani()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Hastane;uid=sa;pwd=1903");
        //SqlConnection conn = new SqlConnection("Server = DESKTOP - MO5HLC4\\SQLEXPRESS; Database=Hastane;Integrated Security = true");

        private void SecimEkrani_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PoliEkrani poliEkrani = new PoliEkrani();   
            poliEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorEkrani doktorEkrani = new DoktorEkrani(); 
            doktorEkrani.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaEkrani hastaEkrani = new HastaEkrani();    
            hastaEkrani.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeshisEkrani teshisEkrani=new TeshisEkrani();   
            teshisEkrani.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
