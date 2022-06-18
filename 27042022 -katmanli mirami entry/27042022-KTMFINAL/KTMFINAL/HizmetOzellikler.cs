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
using BusinessORM;

namespace KTMFINAL
{
    public partial class HizmetOzellikler : Form
    {
        public HizmetOzellikler()
        {
            InitializeComponent();
        }

        private void HizmetOzellikler_Load(object sender, EventArgs e)
        {
            textBox12.Enabled = false;


            //ServiceFeatures.Doldur();
            //while (dr.Read())
            //{
            //    comboBox1.Items.Add(dr["HizmetNo"]);


            //}
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceFeature service = new ServiceFeature();
            service.HizmetOzellikHizmetNo = Convert.ToInt32(comboBox1.Text);
            service.HizmetAciklama = textBox2.Text;
            service.HizmetOzellikEkstra = textBox3.Text;

            

            if (!ServiceFeatures.Ekle(service))
            {
                MessageBox.Show("Hizmet Özelliği Eklenemedi");

            }
            dataGridView1.DataSource = ServiceFeatures.Listele();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceFeature service = new ServiceFeature();
            service.HizmetOzellikNo=Convert.ToInt32(textBox12.Text);
            service.HizmetOzellikHizmetNo = Convert.ToInt32(comboBox1.Text);
            service.HizmetAciklama = textBox2.Text;
            service.HizmetOzellikEkstra = textBox3.Text;



            if (!ServiceFeatures.Guncelle(service))
            {
                MessageBox.Show("Hizmet Özelliği Güncellenemedi");

            }
            dataGridView1.DataSource = ServiceFeatures.Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ServiceFeatures.Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            ServiceFeature service = new ServiceFeature();
            service.HizmetOzellikNo = Convert.ToInt32(textBox12.Text);

            if (!ServiceFeatures.Sil(service))
                MessageBox.Show("Silinmedi");
            dataGridView1.DataSource = ServiceFeatures.Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog(); 
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["HizmetOzellikNo"].Value.ToString();
            comboBox1.Text = satir.Cells["HizmetOzellikHizmetNo"].Value.ToString();
            textBox2.Text = satir.Cells["HizmetAciklama"].Value.ToString();
            textBox3.Text = satir.Cells["HizmetOzellikEsktra"].Value.ToString();
        }
    }
}
