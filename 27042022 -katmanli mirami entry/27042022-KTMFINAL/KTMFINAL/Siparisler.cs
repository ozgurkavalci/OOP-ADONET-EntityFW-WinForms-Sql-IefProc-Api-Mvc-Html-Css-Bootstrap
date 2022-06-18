using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessORM.Entity;
using BusinessORM.Facade;
using System.Data.SqlClient;

namespace KTMFINAL
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Order o1 = new Order();
            o1.SiparisAdi = textBox1.Text;           
            o1.SiparisMusteriNo= Convert.ToInt32(comboBox1.Text);
            o1.SiparisAdres = textBox2.Text;
            o1.SiparisAciklama = textBox3.Text;

            if (!Orders.Ekle(o1))
            {
                MessageBox.Show("Siparis  Eklenemedi");

            }
            dataGridView1.DataSource = Orders.Listele();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            textBox12.Enabled=false;    
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Order o1 = new Order();
            o1.SiparisNo= Convert.ToInt32(textBox12.Text);
            o1.SiparisAdi = textBox1.Text;
            o1.SiparisMusteriNo = Convert.ToInt32(comboBox1.Text);
            o1.SiparisAdres = textBox2.Text;
            o1.SiparisAciklama = textBox3.Text;

            if (!Orders.Guncelle(o1))
            {
                MessageBox.Show("Siparis  Guncellenemedi");

            }
            dataGridView1.DataSource = Orders.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            Order sil = new Order();

            sil.SiparisNo = (int)dataGridView1.CurrentRow.Cells["SiparisNo"].Value;
            if (!Orders.Sil(sil))
                MessageBox.Show("Siparis Silinemedi");
            dataGridView1.DataSource = Orders.Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Orders.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir= dataGridView1.CurrentRow;
            textBox12.Text=satir.Cells["SiparisNo"].Value.ToString();
            textBox1.Text = satir.Cells["SiparisAdi"].Value.ToString();
            comboBox1.Text = satir.Cells["SiparisMusteriNo"].Value.ToString();
            textBox2.Text= satir.Cells["SiparisAdres"].Value.ToString();
            textBox3.Text= satir.Cells["SiparisAciklama"].Value.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }
    }
}
