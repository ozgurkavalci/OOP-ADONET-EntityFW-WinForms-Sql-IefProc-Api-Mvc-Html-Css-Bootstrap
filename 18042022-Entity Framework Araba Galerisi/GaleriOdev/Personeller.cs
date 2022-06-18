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
    public partial class Personeller : Form
    {
        GaleriEntities gal = new GaleriEntities();
        public Personeller()
        {
            InitializeComponent();
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
            personel.SubeNo = Convert.ToInt32(comboBox1.Text);
            gal.Personels.Add(personel);
            gal.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            dataGridView1.DataSource = gal.Personels.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guncelle = Convert.ToInt32(textBox12.Text);

            Personel personel = new Personel();
            personel = gal.Personels.SingleOrDefault(a => a.PersonelNo == guncelle);
            personel.PersonelAdSoyad = textBox1.Text;
            personel.PersonelYas = Convert.ToInt32(textBox2.Text);
            personel.PersonelTcNo = textBox3.Text;
            personel.PersonelMail = textBox4.Text;
            personel.PersonelTelefon = textBox5.Text;
            personel.PersonelAdres = textBox6.Text;
            personel.SubeNo = Convert.ToInt32(comboBox1.Text);
            
            gal.SaveChanges();
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sil = Convert.ToInt32(textBox11.Text);
            Personel psil = new Personel();
            psil = gal.Personels.SingleOrDefault(a => a.PersonelNo == sil);
            gal.Personels.Remove(psil);
            gal.SaveChanges();
            Listele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani=new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Listele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            dataGridView1.DataSource = gal.Personels.OrderBy(x => x.PersonelAdSoyad).ToList();
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
            comboBox1.ResetText();  
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["PersonelNo"].Value.ToString();
            textBox1.Text = satir.Cells["PersonelAdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["PersonelYas"].Value.ToString();
            textBox3.Text = satir.Cells["PersonelTcNo"].Value.ToString();
            textBox4.Text = satir.Cells["PersonelMail"].Value.ToString();
            textBox5.Text = satir.Cells["PersonelTelefon"].Value.ToString();
            textBox6.Text = satir.Cells["PersonelAdres"].Value.ToString();
            comboBox1.Text = satir.Cells["SubeNo"].Value.ToString();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = gal.Subes.ToList();
            comboBox1.ValueMember = "SubeNo";
            comboBox1.DisplayMember = "SubeNo";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = gal.Personels.Where(x => x.PersonelAdSoyad.Contains(textBox1.Text)).ToList();

            int personelno = Convert.ToInt32(textBox12.Text);
            var a = gal.Personels.Where(x => x.PersonelNo == personelno).ToList();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = a.ToList();
        }
    }
}
