using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25042022_İefprocServices
{
    public partial class Musteri : Form
    {
        ServicesEntities servis = new ServicesEntities();

        public Musteri()
        {
            InitializeComponent();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = servis.Hizmetlers.ToList();
            comboBox1.ValueMember = "HizmetNo";
            comboBox1.DisplayMember = "HizmetNo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.MusteriAdSoyad = textBox2.Text;
            musteriler.MusteriCinsiyet = textBox3.Text;
            musteriler.MusteriTelefon = textBox1.Text;
            musteriler.MusteriTcNo= textBox4.Text;  
            musteriler.MusteriAdres = textBox5.Text;
            musteriler.MusteriMail = textBox6.Text;
            musteriler.MusteriHizmetNo = Convert.ToInt32(comboBox1.Text);
            servis.MEkle(musteriler.MusteriAdSoyad, musteriler.MusteriCinsiyet, musteriler.MusteriTelefon, musteriler.MusteriTcNo, musteriler.MusteriAdres, musteriler.MusteriHizmetNo,musteriler.MusteriMail);
            servis.SaveChanges();
            Listele();

        }

        private void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = servis.MGor().ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            int musteriNo=Convert.ToInt32(textBox12.Text);
            musteriler.MusteriAdSoyad = textBox2.Text;
            musteriler.MusteriCinsiyet = textBox3.Text;
            musteriler.MusteriTelefon = textBox1.Text;
            musteriler.MusteriTcNo = textBox4.Text;
            musteriler.MusteriAdres = textBox5.Text;
            musteriler.MusteriMail = textBox6.Text;
            musteriler.MusteriHizmetNo = Convert.ToInt32(comboBox1.Text);
            servis.MG(musteriNo,musteriler.MusteriAdSoyad, musteriler.MusteriCinsiyet, musteriler.MusteriTelefon, musteriler.MusteriTcNo, musteriler.MusteriAdres, musteriler.MusteriHizmetNo, musteriler.MusteriMail);
            servis.SaveChanges();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int hizmetno = Convert.ToInt32(textBox10.Text);


            if (AramaKOntrol(hizmetno))
            {
                var liste = from p in servis.Musterilers
                            where p.MusteriNo == hizmetno
                            select p;
                dataGridView1.DataSource = liste.ToList();
                dataGridView1.Visible = true;

            }
            else
            {
                MessageBox.Show("Musterı No sistemde kayıtlı değil.");
            }

        }




        public bool AramaKOntrol(int id)
        {
            var arama = from k in servis.Musterilers
                        where k.MusteriNo == id
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
            
            int hizmetno = Convert.ToInt32(textBox11.Text);
            servis.MSil(hizmetno);
            servis.SaveChanges();
            Listele();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
