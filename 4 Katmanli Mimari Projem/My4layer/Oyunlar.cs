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
    public partial class Oyunlar : Form
    {
        public Oyunlar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Oyunlar_Load(object sender, EventArgs e)
        {
            List<EDeveloper>  eDevelopers= BLDeveloper.BLDeveloperListele();
            
            comboBox1.DataSource= eDevelopers;
            comboBox1.ValueMember = "AdSoyad";
            comboBox1.DisplayMember = "AdSoyad";

            List<EStudyo> eStudyos=BLStudyo.BLStudyoListele();
            comboBox2.DataSource= eStudyos;
            comboBox2.ValueMember = "StudyoAdi";
            comboBox2.DisplayMember = "StudyoAdi";

        }
        private void Liste()
        { 
           List<EGame> liste= BLGame.BLGameListele();   
            dataGridView1.DataSource= liste;
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["OyunID"].Value.ToString();
            textBox1.Text = row.Cells["OyunTuru"].Value.ToString();
            textBox2.Text = row.Cells["OyunAdi"].Value.ToString();
            dateTimePicker1.Text = row.Cells["OyunCikisTarihi"].Value.ToString();
            textBox3.Text = row.Cells["OyunSatilanKopya"].Value.ToString();          
            comboBox1.Text = row.Cells["AdSoyad"].Value.ToString();
            comboBox2.Text = row.Cells["StudyoAdi"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EGame eGame = new EGame();

            eGame.OyunTuru = textBox1.Text;
            eGame.OyunAdi= textBox2.Text;
            eGame.OyunCikisTarihi = dateTimePicker1.Value;
            eGame.OyunSatilanKopya=Convert.ToInt32(textBox3.Text);
            eGame.AdSoyad = comboBox1.Text;
            eGame.StudyoAdi = comboBox2.Text;

            if (BLGame.BLGameEkleme(eGame) > 0)
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
            EGame eGame = new EGame();

            eGame.OyunID = Convert.ToInt32(textBox1.Tag);
            eGame.OyunTuru = textBox1.Text;
            eGame.OyunAdi = textBox2.Text;
            eGame.OyunCikisTarihi = dateTimePicker1.Value;
            eGame.OyunSatilanKopya = Convert.ToInt32(textBox3.Text);
            eGame.AdSoyad = comboBox1.Text;
            eGame.StudyoAdi = comboBox2.Text;

            if (FGame.Guncelle(eGame) > 0)
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

            EGame eGame = new EGame();
            eGame.OyunID = Convert.ToInt32(textBox4.Text);

            if (BLGame.BLGameSilme(eGame) > 0)
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
            EGame ara = new EGame();
            ara.OyunAdi = textBox5.Text;


            List<EGame> listele = BLGame.BlGameAdArama(ara);
            if (listele.Any())
            {
                dataGridView1.DataSource = listele;
            }

            else
            {
                MessageBox.Show("Bu Adda bir oyun yoktur.");

            }
        }
    }
}
