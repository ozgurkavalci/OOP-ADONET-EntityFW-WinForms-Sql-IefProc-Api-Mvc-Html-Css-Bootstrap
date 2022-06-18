using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLayer;
using Entity;
using Facade;

namespace My4layer
{
    public partial class Studyolar : Form
    {
        public Studyolar()
        {
            InitializeComponent();
        }

        private void Studyolar_Load(object sender, EventArgs e)
        {

        }
        private void Liste()
        {
            List<EStudyo> studyolisteleme = BLStudyo.BLStudyoListele();
            dataGridView1.DataSource = studyolisteleme;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Tag = row.Cells["StudyoID"].Value.ToString();
            textBox1.Text = row.Cells["StudyoAdi"].Value.ToString();
            dateTimePicker1.Text = row.Cells["StudyoKurulusTarih"].Value.ToString();
            textBox2.Text = row.Cells["StudyoMerkez"].Value.ToString();
            textBox3.Text = row.Cells["StudyoNetDeger"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EStudyo eStudyo = new EStudyo();
            eStudyo.StudyoAdi = textBox1.Text;
            eStudyo.StudyoKurulusTarih = dateTimePicker1.Value;
            eStudyo.StudyoMerkez = textBox2.Text;
            eStudyo.StudyoNetDeger=Convert.ToDecimal(textBox3.Text);

            if (BLStudyo.BLStudyoEKleme(eStudyo)>0)
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
            EStudyo eStudyo=new EStudyo();
            eStudyo.StudyoID =Convert.ToInt32(textBox1.Tag);
            eStudyo.StudyoAdi=textBox1.Text;
            eStudyo.StudyoKurulusTarih=dateTimePicker1.Value;
            eStudyo.StudyoMerkez=textBox2.Text;
            eStudyo.StudyoNetDeger= Convert.ToDecimal(textBox3.Text);


            if (FStudyo.Guncelle(eStudyo)>0)
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
            EStudyo eStudyo = new EStudyo();
            eStudyo.StudyoID=Convert.ToInt32(textBox4.Text);

            if (BLStudyo.BLStudyoSilme(eStudyo)>0)
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
            EStudyo ara=new EStudyo();
            ara.StudyoAdi = textBox5.Text;

            
            List<EStudyo> listele = BLStudyo.BlStudyoAdiArama(ara);
            if (listele.Any())
            {
                dataGridView1.DataSource = listele;
            }

            else
            {
                MessageBox.Show("Bu adda bir veri yoktur.");

            }


            
                      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }
    }
}
