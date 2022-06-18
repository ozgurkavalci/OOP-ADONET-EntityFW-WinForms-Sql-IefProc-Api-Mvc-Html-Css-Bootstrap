using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOdev
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        GaleriEntities gal = new GaleriEntities();

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAdSoyad = textBox1.Text;
            musteri.MusteriTcNo= textBox2.Text;
            musteri.MusteriMail= textBox3.Text; 
            musteri.MusteriTelefon= textBox4.Text;
            musteri.MusteriAdres= textBox5.Text;
            musteri.AracNo = Convert.ToInt32(comboBox1.Text);
            gal.Musteris.Add(musteri);
            gal.SaveChanges();
            Listele();
            
            

            
        }

        public void Listele()
        {
            dataGridView1.DataSource = gal.Musteris.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guncelle=Convert.ToInt32(textBox10.Text);   
            Musteri musteri = new Musteri();
            musteri = gal.Musteris.SingleOrDefault(a=>a.MusteriNo == guncelle);
            musteri.MusteriAdSoyad = textBox1.Text;
            musteri.MusteriTcNo = textBox2.Text;
            musteri.MusteriMail = textBox3.Text;
            musteri.MusteriTelefon = textBox4.Text;
            musteri.MusteriAdres = textBox5.Text;
            musteri.AracNo = Convert.ToInt32(comboBox1.Text);
            gal.SaveChanges();
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textBox6.Text);
            Musteri musteri = new Musteri();
            musteri=gal.Musteris.SingleOrDefault(a=>a.MusteriNo==sil);
            gal.Musteris.Remove(musteri);
            gal.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox10.Text = satir.Cells["MusteriNo"].Value.ToString();
            textBox1.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["MusteriTcNo"].Value.ToString();
            textBox3.Text = satir.Cells["MusteriMail"].Value.ToString();
            textBox4.Text = satir.Cells["MusteriTelefon"].Value.ToString();
            textBox5.Text = satir.Cells["MusteriAdres"].Value.ToString();
            comboBox1.Text= satir.Cells["AracNo"].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {






            dataGridView1.DataSource = gal.Musteris.Where(x => x.MusteriAdSoyad.Contains(textBox9.Text)).ToList();

            int musterino = Convert.ToInt32(textBox8.Text);
            var a = gal.Musteris.Where(x => x.MusteriNo == musterino).ToList();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = a.ToList();




        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
            dataGridView1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = gal.Musteris.OrderBy(x => x.MusteriAdSoyad).ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox1.Clear();   
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.ResetText();  
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;


            comboBox1.DataSource = gal.Aracs.ToList();
            comboBox1.ValueMember = "AracNo";
            comboBox1.DisplayMember = "AracNo";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani=new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }
    }
}
