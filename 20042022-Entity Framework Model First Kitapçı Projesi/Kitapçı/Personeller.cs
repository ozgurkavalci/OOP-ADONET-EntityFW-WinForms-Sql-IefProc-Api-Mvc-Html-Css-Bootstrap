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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        BookStoreContainer kitapci = new BookStoreContainer();
        private void Personeller_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;

            comboBox1.DataSource = kitapci.Sube.ToList();
            comboBox1.ValueMember = "SubeID";
            comboBox1.DisplayMember = "SubeID";
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

            Personel personel = new Personel();
            personel.PersonelAdSoyad = textBox1.Text;
            personel.PersonelYas = Convert.ToInt32(textBox2.Text);
            personel.PersonelTcNo = textBox3.Text;
            personel.PersonelMail = textBox4.Text;
            personel.PersonelTelefon = textBox5.Text;
            personel.PersonelAdres = textBox6.Text;
            personel.SubeSubeID = Convert.ToInt32(comboBox1.Text);
            kitapci.Personel.Add(personel);
            kitapci.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = kitapci.Personel.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Personel personel = new Personel();
            int guncelle = Convert.ToInt32(textBox12.Text);
            personel = kitapci.Personel.SingleOrDefault(a => a.PersonelID == guncelle);
            personel.PersonelAdSoyad = textBox1.Text;
            personel.PersonelYas = Convert.ToInt32(textBox2.Text);
            personel.PersonelTcNo = textBox3.Text;
            personel.PersonelMail = textBox4.Text;
            personel.PersonelTelefon = textBox5.Text;
            personel.PersonelAdres = textBox6.Text;
            personel.SubeSubeID = Convert.ToInt32(comboBox1.Text);           
            kitapci.SaveChanges();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int ara = Convert.ToInt32(textBox10.Text);


            if (AramaKOntrol(ara, textBox7.Text))
            {

                var liste = from p in kitapci.Personel
                            where p.PersonelID == ara || p.PersonelAdSoyad.ToLower() == textBox7.Text
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
            var arama = from k in kitapci.Personel
                        where k.PersonelID == id || k.PersonelAdSoyad.ToLower() == ad
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textBox11.Text);
            Personel musteri = new Personel();
            musteri = kitapci.Personel.SingleOrDefault(a => a.PersonelID == sil);
            kitapci.Personel.Remove(musteri);
            kitapci.SaveChanges();
            Listele();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox12.Clear();
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.ResetText();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["PersonelID"].Value.ToString();
            textBox1.Text = satir.Cells["PersonelAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["PersonelYas"].Value.ToString();
            textBox3.Text = satir.Cells["PersonelTcNo"].Value.ToString();
            textBox4.Text = satir.Cells["PersonelMail"].Value.ToString();
            textBox5.Text = satir.Cells["PersonelTelefon"].Value.ToString();
            textBox6.Text = satir.Cells["PersonelAdres"].Value.ToString();
            comboBox1.Text = satir.Cells["SubeSubeID"].Value.ToString();
        }
    }
}
