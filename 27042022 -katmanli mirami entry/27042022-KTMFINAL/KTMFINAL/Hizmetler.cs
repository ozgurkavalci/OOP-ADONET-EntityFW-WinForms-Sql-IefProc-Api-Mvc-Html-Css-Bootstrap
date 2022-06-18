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
    public partial class Hizmetler : Form
    {
        public Hizmetler()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.HizmetAdi = textBox1.Text;
            service.HizmetTanimi = textBox2.Text;
            service.HizmetFiyat = Convert.ToDecimal(textBox3.Text);

            if (!Services.Ekle(service))
            {
                MessageBox.Show("Hizmet  Eklenemedi");

            }
            dataGridView1.DataSource = Services.Listele();
        }

        private void Hizmetler_Load(object sender, EventArgs e)
        {
            textBox12.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.HizmetNo = Convert.ToInt32(textBox12.Text);
            service.HizmetAdi = textBox1.Text;
            service.HizmetTanimi = textBox2.Text;
            service.HizmetFiyat = Convert.ToDecimal(textBox3.Text);

            if (!Services.Guncelle(service))
            {
                MessageBox.Show("Hizmet Guncellenemedi.");

            }
            dataGridView1.DataSource = Services.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null) return;
            Service sil = new Service();

            sil.HizmetNo = (int)dataGridView1.CurrentRow.Cells["HizmetNo"].Value;
            if (!Services.Sil(sil))
                MessageBox.Show("Silinmedi");
            dataGridView1.DataSource = Services.Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Services.Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["HizmetNo"].Value.ToString();
            textBox1.Text = satir.Cells["HizmetAdi"].Value.ToString();
            textBox2.Text = satir.Cells["HizmetTanimi"].Value.ToString();
            textBox3.Text = satir.Cells["HizmetFiyat"].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
