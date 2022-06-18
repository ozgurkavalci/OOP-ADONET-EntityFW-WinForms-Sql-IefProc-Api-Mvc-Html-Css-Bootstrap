using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2204022_EFproc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OkulEntities baglanti=new OkulEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciler ekle=new Ogrenciler();
            ekle.Adsoyad = textBox1.Text;
            ekle.TcNo = textBox2.Text;
            ekle.Telefon= textBox3.Text;    
            ekle.Mail= textBox4.Text;
            ekle.Adres= textBox5.Text;

            baglanti.OAdd(ekle.Adsoyad, ekle.TcNo, ekle.Telefon, ekle.Mail, ekle.Adres);
            //baglanti.Ogrencilers.Add(ekle); 
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.OG().ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.OG().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag= satir.Cells["OgrenciNo"].Value.ToString();
            textBox1.Text = satir.Cells["AdSoyad"].Value.ToString();
            textBox2.Text = satir.Cells["TcNo"].Value.ToString();
            textBox3.Text = satir.Cells["Telefon"].Value.ToString();
            textBox4.Text = satir.Cells["Mail"].Value.ToString();
            textBox5.Text = satir.Cells["Adres"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(textBox1.Tag);
            baglanti.OSL(id);
            baglanti.SaveChanges();
            dataGridView1.DataSource=baglanti.OG().ToList();    

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Yenile
            Ogrenciler ekle = new Ogrenciler();
            int id = Convert.ToInt32(textBox1.Tag);
            
            ekle.Adsoyad = textBox1.Text;
            ekle.TcNo = textBox2.Text;
            ekle.Telefon = textBox3.Text;
            ekle.Mail = textBox4.Text;
            ekle.Adres = textBox5.Text;

            baglanti.OY(id,ekle.Adsoyad, ekle.TcNo, ekle.Telefon, ekle.Mail, ekle.Adres);
            //baglanti.Ogrencilers.Add(ekle); 
            baglanti.SaveChanges();
            dataGridView1.DataSource = baglanti.OG().ToList();
        }
    }
}
