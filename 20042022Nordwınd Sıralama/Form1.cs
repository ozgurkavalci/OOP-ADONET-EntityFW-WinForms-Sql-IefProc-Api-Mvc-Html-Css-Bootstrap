using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20042022Nordwınd_Sıralama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities islem=new NorthwindEntities();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindEntities islem = new NorthwindEntities();

            var sonuc = from urun in islem.Urunlers
                        join tedarikci in islem.Tedarikcilers on urun.TedarikciID equals
                        tedarikci.TedarikciID
                        select new
                        {
                            urun.UrunAdi,
                            urun.BirimFiyati,
                            urun.HedefStokDuzeyi,
                            tedarikci.SirketAdi,
                            tedarikci.Sehir,
                            tedarikci.Telefon
                        };
            dataGridView1.DataSource = sonuc.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sonuc = from urun in islem.Urunlers
                        orderby urun.BirimFiyati
                        select urun;
            dataGridView1.DataSource= sonuc.ToList();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sonuc= from urun in islem.Urunlers
                       orderby urun.UrunAdi descending
                       select urun; 
            dataGridView1.DataSource=sonuc.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //urunlerle kategoriler birlestir kafana göre cagır

            var sonuc = from kategori in islem.Kategorilers
                        join urun in islem.Urunlers on kategori.KategoriID equals urun.KategoriID
                        select new
                        {
                            urun.UrunAdi,
                            urun.UrunID,
                            urun.BirimFiyati,
                            kategori.KategoriAdi,
                            kategori.Tanimi
                        };
            dataGridView1.DataSource=sonuc.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var sonuc = from personel in 
                            islem.Personellers
                        join satis in islem.Satislars on 
                        personel.PersonelID equals satis.PersonelID

                        group satis by personel.Adi into grup
                        select new
                        {
                            personelAdi=grup.Key,
                            toplamsatis=grup.Count()


                        };
            dataGridView1.DataSource = sonuc.ToList();
        }
    }
}
