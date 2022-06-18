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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        BookStoreContainer kitapci = new BookStoreContainer();

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

        public void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = kitapci.Urun.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Urun product = new Urun();
            product.UrunTuru = textBox1.Text;
            product.UrunKategori = textBox2.Text;
            product.UrunAdi = textBox3.Text;
            product.UrunCikisYili = Convert.ToInt32(textBox4.Text);
            product.UrunYazarAdi = textBox5.Text;
            product.UrunAdet=Convert.ToInt32(textBox6.Text);
            product.UrunFiyat=Convert.ToDecimal(textBox7.Text);
            product.MusteriMusteriID = Convert.ToInt32(comboBox1.Text);

            kitapci.Urun.Add(product);
            kitapci.SaveChanges();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urun product = new Urun();
            int guncelle = Convert.ToInt32(textBox12.Text);
            product = kitapci.Urun.SingleOrDefault(a => a.UrunID == guncelle);
            product.UrunTuru = textBox1.Text;
            product.UrunKategori = textBox2.Text;
            product.UrunAdi = textBox3.Text;
            product.UrunCikisYili = Convert.ToInt32(textBox4.Text);
            product.UrunYazarAdi = textBox5.Text;
            product.UrunAdet = Convert.ToInt32(textBox6.Text);
            product.UrunFiyat = Convert.ToDecimal(textBox7.Text);
            product.MusteriMusteriID = Convert.ToInt32(comboBox1.Text);
            kitapci.SaveChanges();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ara = Convert.ToInt32(textBox10.Text);


            if (AramaKOntrol(ara, textBox8.Text))
            {

                var liste = from p in kitapci.Urun
                            where p.UrunID == ara || p.UrunAdi.ToLower() == textBox8.Text
                            select p;
                dataGridView1.DataSource = liste.ToList();
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Urun ID veya Adı sistemde kayıtlı değil.");
            }
        }

        public bool AramaKOntrol(int id, string ad)
        {
            var arama = from k in kitapci.Urun
                        where k.UrunID == id || k.UrunAdi.ToLower() == ad
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

        private void button4_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textBox11.Text);
            Urun product = new Urun();
            product = kitapci.Urun.SingleOrDefault(a => a.UrunID == sil);
            kitapci.Urun.Remove(product);
            kitapci.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["UrunID"].Value.ToString();
            textBox1.Text = satir.Cells["UrunTuru"].Value.ToString();
            textBox2.Text = satir.Cells["UrunKategori"].Value.ToString();
            textBox3.Text = satir.Cells["UrunAdi"].Value.ToString();
            textBox4.Text = satir.Cells["UrunCikisYili"].Value.ToString();
            textBox5.Text = satir.Cells["UrunYazarAdi"].Value.ToString();
            textBox6.Text = satir.Cells["UrunAdet"].Value.ToString();
            textBox7.Text = satir.Cells["UrunFiyat"].Value.ToString();
            comboBox1.Text = satir.Cells["MusteriMusteriID"].Value.ToString();

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            


            comboBox1.DataSource = kitapci.Musteri.ToList();
            comboBox1.ValueMember = "MusteriID";
            comboBox1.DisplayMember = "MusteriID";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.ResetText();
            textBox10.Clear();
            textBox11.Clear();
            textBox8.Clear();


        }
    }
}
