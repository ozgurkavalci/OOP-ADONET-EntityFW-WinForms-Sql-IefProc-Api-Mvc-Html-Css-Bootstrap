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
    public partial class Musteriler : Form
    {
        public Musteriler()
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
            Customer c1 = new Customer();
            c1.MusteriAdSoyad = textBox1.Text;
            c1.MusteriCinsiyet = textBox2.Text;
            c1.MusteriTelefon = textBox3.Text;
            c1.MusteriTcNo= textBox4.Text;
            c1.MusteriAdres= textBox5.Text;
            c1.MusteriHizmetNo=Convert.ToInt32(comboBox1.Text);
            c1.MusteriMail= textBox6.Text;

            if (!Customers.Ekle(c1))
            {
                MessageBox.Show("Musteri Eklenemedi");

            }
            dataGridView1.DataSource = Customers.Listele();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            textBox12.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Customer c1 = new Customer();
            c1.MusteriNo = Convert.ToInt32(textBox12.Text);
            c1.MusteriAdSoyad = textBox1.Text;
            c1.MusteriCinsiyet = textBox2.Text;
            c1.MusteriTelefon = textBox3.Text;
            c1.MusteriTcNo = textBox4.Text;
            c1.MusteriAdres = textBox5.Text;
            c1.MusteriHizmetNo = Convert.ToInt32(comboBox1.Text);
            c1.MusteriMail = textBox6.Text;

            if (!Customers.Guncelle(c1))
            {
                MessageBox.Show("Musteri Guncellenemedi");

            }
            dataGridView1.DataSource = Customers.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            Customer sil = new Customer();

            sil.MusteriNo = (int)dataGridView1.CurrentRow.Cells["MusteriNo"].Value;
            if (!Customers.Sil(sil))
                MessageBox.Show("Silinmedi");
            dataGridView1.DataSource = Services.Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Customers.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["MusteriNo"].Value.ToString();
            textBox1.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["MusteriCinsiyet"].Value.ToString();
            textBox3.Text = satir.Cells["MusteriTelefon"].Value.ToString();
            textBox4.Text = satir.Cells["MusteriTcNo"].Value.ToString();
            textBox5.Text = satir.Cells["MusteriAdres"].Value.ToString();
            comboBox1.Text = satir.Cells["MusteriHizmetNo"].Value.ToString();
            textBox6.Text = satir.Cells["MusteriTelefon"].Value.ToString();
        }
    }
}
