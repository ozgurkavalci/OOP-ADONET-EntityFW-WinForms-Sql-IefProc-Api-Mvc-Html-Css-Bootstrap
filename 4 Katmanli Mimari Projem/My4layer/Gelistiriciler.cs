using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Entity;
using Facade;
using System.Data.SqlClient;

namespace My4layer
{
    public partial class Gelistiriciler : Form
    {
        public Gelistiriciler()
        {
            InitializeComponent();
        }

        private void Gelistiriciler_Load(object sender, EventArgs e)
        {
            List<EMerkez> merkezlisteleme = BLMerkez.BLMerkezListele();

            comboBox1.DataSource = merkezlisteleme;
            comboBox1.ValueMember = "MerkezID";
            comboBox1.DisplayMember = "MerkezID";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void button5_Click(object sender, EventArgs e)
        {
           AnaMenu anaMenu=new AnaMenu();
            anaMenu.Show();
            this.Hide();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["DeveloperID"].Value.ToString();
            textBox1.Text = row.Cells["AdSoyad"].Value.ToString();          
            textBox2.Text = row.Cells["Yas"].Value.ToString();
            textBox3.Text = row.Cells["Cinsiyet"].Value.ToString();
            textBox6.Text = row.Cells["Ulke"].Value.ToString();           
            dateTimePicker1.Text = row.Cells["IseBaslamaTarihi"].Value.ToString();
            textBox7.Text = row.Cells["UzmanlikAlani"].Value.ToString();
            comboBox1.Text = row.Cells["MerkezID"].Value.ToString();
            
        }

        private void Liste()
        { 
           List<EDeveloper> liste=new List<EDeveloper>();
            liste = BLDeveloper.BLDeveloperListele();
            dataGridView1.DataSource = liste;
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EDeveloper eDeveloper = new EDeveloper();

            eDeveloper.AdSoyad = textBox1.Text;
            eDeveloper.Yas=Convert.ToInt32(textBox2.Text);
            eDeveloper.Cinsiyet=textBox3.Text;  
            eDeveloper.Ulke=textBox6.Text;
            eDeveloper.IseBaslamaTarihi=dateTimePicker1.Value;
            eDeveloper.UzmanlikAlani = textBox7.Text;
            eDeveloper.MerkezID=Convert.ToInt32(comboBox1.Text);

            if (BLDeveloper.BLDeveloperEkleme(eDeveloper)>0)
            {
                MessageBox.Show("Ekleme islemi basarili");
            }
            else
            {
                MessageBox.Show("Ekleme islemi basarisiz");
            }

            Liste();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EDeveloper eDeveloper=new EDeveloper();

            eDeveloper.DeveloperID=Convert.ToInt32(textBox1.Tag);  
            eDeveloper.AdSoyad = textBox1.Text;
            eDeveloper.Yas = Convert.ToInt32(textBox2.Text);
            eDeveloper.Cinsiyet = textBox3.Text;
            eDeveloper.Ulke = textBox6.Text;
            eDeveloper.IseBaslamaTarihi = dateTimePicker1.Value;
            eDeveloper.UzmanlikAlani = textBox7.Text;
            eDeveloper.MerkezID = Convert.ToInt32(comboBox1.Text);

            if (FDeveloper.Guncelle(eDeveloper)>0)
            {
                MessageBox.Show("Guncelleme islemi basarili");
            }
            else
            {
                MessageBox.Show("Guncelleme islemi basarisiz");
            }
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EDeveloper eDeveloper = new EDeveloper();
            eDeveloper.DeveloperID = Convert.ToInt32(textBox4.Text);

            if (BLDeveloper.BLDeveloperSilme(eDeveloper) > 0)
            {
                MessageBox.Show("Silme Isleme Basarili");
            }
            else
            {
                MessageBox.Show("Silme Islemi Basarisiz");
            }
            Liste();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EDeveloper ara = new EDeveloper();
            ara.AdSoyad = textBox5.Text;


            List<EDeveloper> listele = BLDeveloper.BlDeveloperAdArama(ara);
            if (listele.Any())
            {
                dataGridView1.DataSource = listele;
            }

            else
            {
                MessageBox.Show("Bu Adda bir developer yoktur.");

            }
        }
    }
}
