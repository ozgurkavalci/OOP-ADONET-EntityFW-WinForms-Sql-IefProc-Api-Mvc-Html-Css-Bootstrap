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
    public partial class Merkezler : Form
    {
        public Merkezler()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
           AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show(); 
            this.Hide();


        }

        private void Merkezler_Load(object sender, EventArgs e)
        {

            List<EStudyo> studyolisteleme = BLStudyo.BLStudyoListele();

            comboBox1.DataSource = studyolisteleme;
            comboBox1.ValueMember = "StudyoID";
            comboBox1.DisplayMember = "StudyoID";

            comboBox2.DataSource = studyolisteleme;
            comboBox2.ValueMember = "StudyoAdi";
            comboBox2.DisplayMember = "StudyoAdi";

        }

        private void Liste()
        { 
           List<EMerkez> merkezListeleme= BLMerkez.BLMerkezListele();
            dataGridView1.DataSource = merkezListeleme;
                  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMerkez eMerkez = new EMerkez();
            
            eMerkez.MerkezLokasyon=textBox1.Text;
            eMerkez.MerkezKurulusTarihi = dateTimePicker1.Value;
            eMerkez.MerkezCalisanSayisi=Convert.ToInt32(textBox2.Text);
            eMerkez.MerkezYillikCiro=Convert.ToDecimal(textBox3.Text);
            eMerkez.StudyoID = Convert.ToInt32(comboBox1.Text);
            eMerkez.StudyoAdi= comboBox2.Text;

            if (BLMerkez.BLMerkezEkleme(eMerkez)>0)
            {
                MessageBox.Show("Ekleme islemi basarili");
            }
            else
            {
                MessageBox.Show("Ekleme islemi basarisiz");
            }
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["MerkezID"].Value.ToString();
            textBox1.Text = row.Cells["MerkezLokasyon"].Value.ToString();
            dateTimePicker1.Text = row.Cells["MerkezKurulusTarihi"].Value.ToString();
            textBox2.Text = row.Cells["MerkezCalisanSayisi"].Value.ToString();
            textBox3.Text = row.Cells["MerkezYillikCiro"].Value.ToString();
            comboBox1.Text= row.Cells["StudyoID"].Value.ToString();
            comboBox2.Text = row.Cells["StudyoAdi"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EMerkez eMerkez = new EMerkez();
            eMerkez.MerkezID= Convert.ToInt32(textBox1.Tag);
            eMerkez.MerkezLokasyon = textBox1.Text;
            eMerkez.MerkezKurulusTarihi = dateTimePicker1.Value;
            eMerkez.MerkezCalisanSayisi = Convert.ToInt32(textBox2.Text);
            eMerkez.MerkezYillikCiro = Convert.ToDecimal(textBox3.Text);
            eMerkez.StudyoID = Convert.ToInt32(comboBox1.Text);
            eMerkez.StudyoAdi = comboBox2.Text;

            if (FMerkez.Guncelle(eMerkez)>0)
            {
                MessageBox.Show("Basariyla Guncellendi");
            }
            else
            {
                MessageBox.Show("Guncelleme Islemi Basarisiz...");
            }

            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EMerkez eMerkez = new EMerkez();
            eMerkez.MerkezID = Convert.ToInt32(textBox4.Text);

            if (BLMerkez.BLMerkezSilme(eMerkez) > 0)
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
            EMerkez ara = new EMerkez();
            ara.MerkezLokasyon = textBox5.Text;


            List<EMerkez> listele = BLMerkez.BlMerkezLokasyonArama(ara);
            if (listele.Any())
            {
                dataGridView1.DataSource = listele;
            }

            else
            {

                MessageBox.Show("Bu lokasyonda bir veri yoktur.");

            }
        }
    }
}
