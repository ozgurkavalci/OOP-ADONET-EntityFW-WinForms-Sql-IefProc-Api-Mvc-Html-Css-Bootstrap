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
    public partial class Araclar : Form
    {
        GaleriEntities gal = new GaleriEntities();
        public Araclar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arac arac = new Arac();
            arac.AracFiyat = Convert.ToDecimal(textBox1.Text);
            arac.AracAdet = Convert.ToInt32(textBox2.Text);
            arac.AracMarka = textBox4.Text;
            arac.AracModel = textBox4.Text;
            arac.AracYil = Convert.ToInt32(textBox5.Text);
            arac.AracOzellik = textBox6.Text;
            arac.AracMotorHacmi=Convert.ToInt32(textBox7.Text);
            arac.AracPaket = textBox8.Text;
            arac.AracRenk=textBox9.Text;    
            arac.SubeNo = comboBox1.SelectedIndex;  
            gal.Aracs.Add(arac);
            gal.SaveChanges();
            Listele();
        }

        public void Listele()
        {
            dataGridView1.DataSource = gal.Aracs.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Arac arac = new Arac();
            int guncelle = Convert.ToInt32(textBox12.Text);
            
            arac = gal.Aracs.SingleOrDefault(a => a.AracNo == guncelle);
            arac.AracFiyat = Convert.ToDecimal(textBox1.Text);
            arac.AracAdet = Convert.ToInt32(textBox2.Text);
            arac.AracMarka = textBox3.Text;
            arac.AracModel = textBox4.Text;
            arac.AracYil = Convert.ToInt32(textBox5.Text);
            arac.AracOzellik = textBox6.Text;
            arac.AracMotorHacmi = Convert.ToInt32(textBox7.Text);
            arac.AracPaket = textBox8.Text;
            arac.AracRenk = textBox9.Text;
            arac.SubeNo = Convert.ToInt32(comboBox1.Text);

            gal.SaveChanges();
            Listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int sil = Convert.ToInt32(textBox11.Text);
            Arac arac = new Arac();
            arac = gal.Aracs.SingleOrDefault(a => a.AracNo == sil);
            gal.Aracs.Remove(arac);
            gal.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox12.Text = satir.Cells["AracNo"].Value.ToString();
            textBox1.Text = satir.Cells["AracFiyat"].Value.ToString();
            textBox2.Text = satir.Cells["AracAdet"].Value.ToString();
            textBox3.Text = satir.Cells["AracMarka"].Value.ToString();
            textBox4.Text = satir.Cells["AracModel"].Value.ToString();
            textBox5.Text = satir.Cells["AracYil"].Value.ToString();
            textBox6.Text = satir.Cells["AracOzellik"].Value.ToString();
            textBox7.Text = satir.Cells["AracMotorHacmi"].Value.ToString();
            textBox8.Text = satir.Cells["AracPaket"].Value.ToString();
            textBox9.Text = satir.Cells["AracRenk"].Value.ToString();
            comboBox1.Text = satir.Cells["SubeNo"].Value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView1.DataSource = gal.Aracs.OrderBy(x => x.AracNo).ToList();
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
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            comboBox1.ResetText();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    

        }

        private void Araclar_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;    
            comboBox1.DataSource = gal.Subes.ToList();
            comboBox1.ValueMember = "SubeNo";
            comboBox1.DisplayMember = "SubeNo";
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = gal.Aracs.Where(x => x.AracModel.Contains(textBox4.Text)).ToList();

            int aracno = Convert.ToInt32(textBox10.Text);
            var a = gal.Aracs.Where(x => x.AracNo == aracno).ToList();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = a.ToList();
        }
    }
}
