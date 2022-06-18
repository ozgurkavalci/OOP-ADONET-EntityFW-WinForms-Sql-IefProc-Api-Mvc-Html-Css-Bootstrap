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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        BookStoreContainer kitapci = new BookStoreContainer();

        private void Musteriler_Load(object sender, EventArgs e)
        {
            label16.Visible = false;    
            txtMSilAd.Visible = false;  
            dataGridView1.Visible = false;  
            textBox10.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show(); 
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri kullanici = new Musteri();
            kullanici.MusteriAdSoyad = textBox1.Text;
            kullanici.MusteriTcNO = textBox2.Text;
            kullanici.MusteriMail = textBox3.Text;
            kullanici.MusteriTelefon=textBox4.Text;
            kullanici.MusteriAdres=textBox5.Text;
            
            kitapci.Musteri.Add(kullanici);
            kitapci.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = kitapci.Musteri.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri kullanici=new Musteri();
            int guncelle = Convert.ToInt32(textBox10.Text);
            kullanici = kitapci.Musteri.SingleOrDefault(a => a.MusteriID == guncelle);
            kullanici.MusteriAdSoyad = textBox1.Text;
            kullanici.MusteriTcNO = textBox2.Text;
            kullanici.MusteriMail = textBox3.Text;
            kullanici.MusteriTelefon = textBox4.Text;
            kullanici.MusteriAdres = textBox5.Text;
                     
            kitapci.SaveChanges();
            Listele();
        }
        public bool AramaKOntrol(int id, string ad)
        { 
           var arama= from k in kitapci.Musteri
                      where k.MusteriID==id || k.MusteriAdSoyad.ToLower()== ad
                      select k;

            if (arama.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ara=Convert.ToInt32(txtMAraNo.Text);

           
            if (AramaKOntrol(ara,txtMAraAd.Text))
            {

                var liste = from p in kitapci.Musteri
                            where p.MusteriID == ara || p.MusteriAdSoyad.ToLower() == txtMAraAd.Text
                            select p;
                dataGridView1.DataSource = liste.ToList();
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Musterı ID veya Adı sistemde kayıtlı değil.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(txtMSilNo.Text);
            Musteri musteri = new Musteri();
            musteri = kitapci.Musteri.SingleOrDefault(a => a.MusteriID == sil);
            kitapci.Musteri.Remove(musteri);
            kitapci.SaveChanges();
            Listele();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox10.Text = satir.Cells["MusteriID"].Value.ToString();
            textBox1.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["MusteriTcNo"].Value.ToString();
            textBox3.Text = satir.Cells["MusteriMail"].Value.ToString();
            textBox4.Text = satir.Cells["MusteriTelefon"].Value.ToString();
            textBox5.Text = satir.Cells["MusteriAdres"].Value.ToString();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();   
            textBox3.Clear();   
            textBox4.Clear();   
            textBox5.Clear();   
            textBox10.Clear();  
            txtMAraAd.Clear();
            txtMAraNo.Clear();
            txtMSilAd.Clear();  
            txtMSilNo.Clear();  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }
    }
}
