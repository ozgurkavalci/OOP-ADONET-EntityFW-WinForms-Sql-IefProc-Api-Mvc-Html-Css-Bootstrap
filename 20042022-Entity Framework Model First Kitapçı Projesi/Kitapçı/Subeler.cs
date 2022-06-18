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
    public partial class Subeler : Form
    {
        public Subeler()
        {
            InitializeComponent();
        }

        BookStoreContainer kitapci = new BookStoreContainer();

        private void Subeler_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            comboBox1.DataSource = kitapci.Urun.ToList();
            comboBox1.ValueMember = "UrunID";
            comboBox1.DisplayMember = "UrunID";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sube kullanici = new Sube();
            kullanici.SubeAdi = textBox1.Text;
            kullanici.SubeCiro =Convert.ToDecimal(textBox3.Text);
            kullanici.SubePersonelSayisi = Convert.ToInt32(textBox2.Text);
            kullanici.UrunUrunID = Convert.ToInt32(comboBox1.Text);
            

            kitapci.Sube.Add(kullanici);
            kitapci.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = kitapci.Sube.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sube kullanici = new Sube();
            int guncelle = Convert.ToInt32(textBox4.Text);
            kullanici = kitapci.Sube.SingleOrDefault(a => a.SubeID == guncelle);
            kullanici.SubeAdi = textBox1.Text;
            kullanici.SubeCiro = Convert.ToDecimal(textBox3.Text);
            kullanici.SubePersonelSayisi = Convert.ToInt32(textBox2.Text);
            kullanici.UrunUrunID = Convert.ToInt32(comboBox1.Text);
            kitapci.SaveChanges();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ara = Convert.ToInt32(textBox8.Text);


            if (AramaKOntrol(ara, textBox9.Text))
            {

                var liste = from p in kitapci.Sube
                            where p.SubeID == ara || p.SubeAdi.ToLower() == textBox9.Text
                            select p;
                dataGridView1.DataSource = liste.ToList();
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show("Şube ID veya Adı sistemde kayıtlı değil.");
            }
        }

        public bool AramaKOntrol(int id, string ad)
        {
            var arama = from k in kitapci.Sube
                        where k.SubeID == id || k.SubeAdi.ToLower() == ad
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox4.Text = satir.Cells["SubeID"].Value.ToString();
            textBox1.Text = satir.Cells["SubeAdi"].Value.ToString();
            textBox3.Text = satir.Cells["SubeCiro"].Value.ToString();
            textBox2.Text = satir.Cells["SubePersonelSayisi"].Value.ToString();
            comboBox1.Text= satir.Cells["UrunUrunID"].Value.ToString();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textBox6.Text);
            Sube musteri = new Sube();
            musteri = kitapci.Sube.SingleOrDefault(a => a.SubeID == sil);
            kitapci.Sube.Remove(musteri);
            kitapci.SaveChanges();
            Listele();
        }
    }
}
