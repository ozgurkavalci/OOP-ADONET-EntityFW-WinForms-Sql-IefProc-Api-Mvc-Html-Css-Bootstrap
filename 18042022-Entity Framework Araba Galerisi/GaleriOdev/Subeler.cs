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
    public partial class Subeler : Form
    {

        GaleriEntities gal = new GaleriEntities();
        public Subeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sube sube = new Sube();
            sube.SubeAdi = textBox1.Text;
            sube.SubeCiro = Convert.ToDecimal(textBox3.Text);
            sube.CalisanSayisi =Convert.ToInt32(textBox2.Text);          
            sube.MusteriNo = Convert.ToInt32(comboBox1.Text);
            sube.PersonelNo = Convert.ToInt32(comboBox2.Text);

            gal.Subes.Add(sube);
            gal.SaveChanges();
            Listele();
        }
        public void Listele()
        {
            dataGridView1.DataSource = gal.Subes.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sube sube = new Sube();
            sube = gal.Subes.SingleOrDefault(a => a.SubeNo == Convert.ToInt32(textBox4.Text));
            sube.SubeAdi = textBox1.Text;
            sube.SubeCiro = Convert.ToDecimal(textBox2.Text);
            sube.CalisanSayisi = Convert.ToInt32(textBox3.Text);
            sube.MusteriNo = Convert.ToInt32(comboBox1.Text);
            sube.PersonelNo = Convert.ToInt32(comboBox2.Text);

            gal.Subes.Add(sube);
            gal.SaveChanges();
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int sil = Convert.ToInt32(textBox6.Text);
            Sube ssil = new Sube();
            ssil = gal.Subes.SingleOrDefault(a => a.SubeNo == sil);
            gal.Subes.Remove(ssil);
            gal.SaveChanges();
            Listele();
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
            dataGridView1.DataSource = gal.Subes.OrderBy(x => x.SubeAdi).ToList();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox4.Text = satir.Cells["SubeNo"].Value.ToString();
            textBox1.Text = satir.Cells["SubeAdi"].Value.ToString();
            textBox2.Text = satir.Cells["CalisanSayisi"].Value.ToString();
            textBox3.Text = satir.Cells["SubeCiro"].Value.ToString();

            comboBox1.Text = satir.Cells["MusteriNo"].Value.ToString();
            comboBox2.Text = satir.Cells["PersonelNo"].Value.ToString();


        }

        private void Subeler_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = gal.Musteris.ToList();
            comboBox1.ValueMember = "MusteriNo";
            comboBox1.DisplayMember = "MusteriNo";

            comboBox2.DataSource = gal.Personels.ToList();
            comboBox2.ValueMember = "PersonelNo";
            comboBox2.DisplayMember = "PersonelNo";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = gal.Subes.Where(x => x.SubeAdi.Contains(textBox9.Text)).ToList();

            int subeno = Convert.ToInt32(textBox8.Text);
            var a = gal.Subes.Where(x => x.SubeNo == subeno).ToList();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = a.ToList();
        }
    }
}
