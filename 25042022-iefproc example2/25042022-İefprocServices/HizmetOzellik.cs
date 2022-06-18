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
    public partial class HizmetOzellik : Form
    {

        ServicesEntities servis = new ServicesEntities();
        public HizmetOzellik()
        {
            InitializeComponent();
        }

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

        private void HizmetOzellik_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = servis.Hizmetlers.ToList();
            comboBox1.ValueMember = "HizmetNo";
            comboBox1.DisplayMember = "HizmetNo";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            HizmetOzellikler hizmet = new HizmetOzellikler();
            hizmet.HizmetOzellikHizmetNo = Convert.ToInt32(comboBox1.Text);
            hizmet.HizmetAciklama = textBox2.Text;
            hizmet.HizmetOzellikEkstra = textBox3.Text;
            servis.HOEkle(hizmet.HizmetOzellikHizmetNo, hizmet.HizmetAciklama, hizmet.HizmetOzellikEkstra);
            servis.SaveChanges();
            Listele();
        }

        private void Listele()
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = servis.HOGor().ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            HizmetOzellikler hizmet = new HizmetOzellikler();
            int hizmetoz=Convert.ToInt32(textBox12.Text);
            hizmet.HizmetOzellikHizmetNo = Convert.ToInt32(comboBox1.Text);
            hizmet.HizmetAciklama = textBox2.Text;
            hizmet.HizmetOzellikEkstra = textBox3.Text;
            servis.HOG(hizmetoz,hizmet.HizmetOzellikHizmetNo, hizmet.HizmetAciklama, hizmet.HizmetOzellikEkstra);
            servis.SaveChanges();
            Listele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int hizmetno = Convert.ToInt32(textBox10.Text);


            if (AramaKOntrol(hizmetno))
            {
                var liste = from p in servis.HizmetOzelliklers
                            where p.HizmetOzellikNo == hizmetno
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
            var arama = from k in servis.HizmetOzelliklers
                        where k.HizmetOzellikNo == id
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

            HizmetOzellikler hizmet = new HizmetOzellikler();
            int hizmetno = Convert.ToInt32(textBox11.Text);
            servis.HOSil(hizmetno);
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
    }
}
