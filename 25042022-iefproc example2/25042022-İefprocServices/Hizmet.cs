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
    public partial class Hizmet : Form
    {
        public Hizmet()
        {
            InitializeComponent();
        }
        ServicesEntities servis = new ServicesEntities();
        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hizmetler hizmet = new Hizmetler();
            hizmet.HizmetAdi = textBox1.Text;
            hizmet.HizmetTanimi = textBox2.Text;
            hizmet.HizmetFiyat = Convert.ToDecimal(textBox3.Text);
            servis.HEkle(hizmet.HizmetAdi,hizmet.HizmetTanimi,hizmet.HizmetFiyat);
            servis.SaveChanges();
            Listele();



            

        }

        private void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = servis.HGor().ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hizmetler hizmet = new Hizmetler();
            int hizmetno= Convert.ToInt32(textBox12.Text);
            hizmet.HizmetAdi = textBox1.Text;
            hizmet.HizmetTanimi = textBox2.Text;
            hizmet.HizmetFiyat = Convert.ToDecimal(textBox3.Text);
            servis.HG(hizmetno,hizmet.HizmetAdi, hizmet.HizmetTanimi, hizmet.HizmetFiyat);
            servis.SaveChanges();
            Listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hizmetler hizmet = new Hizmetler();
            int hizmetno = Convert.ToInt32(textBox11.Text);
            servis.HSil(hizmetno);
            servis.SaveChanges();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //Hizmetler hizmet = new Hizmetler();
            int hizmetno = Convert.ToInt32(textBox10.Text);
            

            if (AramaKOntrol(hizmetno))
            {
                var liste = from p in servis.Hizmetlers
                            where p.HizmetNo == hizmetno 
                            select p;
                dataGridView1.DataSource = liste.ToList();
                dataGridView1.Visible = true;

            }
            else
            {
                MessageBox.Show("Musterı ID sistemde kayıtlı değil.");
            }
            
        }

        public bool AramaKOntrol(int id)
        {
            var arama = from k in servis.Hizmetlers
                        where k.HizmetNo == id
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

        private void button10_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["HizmetNo"].Value.ToString();
            textBox1.Text = satir.Cells["HizmetAdi"].Value.ToString();
            textBox2.Text = satir.Cells["HizmetTanimi"].Value.ToString();
            textBox3.Text = satir.Cells["HizmetFiyat"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            //var arama = from k in servis.Hizmetlers orderby k.HizmetAdi ascending
            //            select k;
            //dataGridView1.Visible = true;
            //dataGridView1.DataSource = arama.ToList();



            dataGridView1.Visible = true;
            dataGridView1.DataSource = servis.HGor().ToList();
        }

        private void Hizmet_Load(object sender, EventArgs e)
        {
            textBox12.Enabled=false;
        }
    }
}
