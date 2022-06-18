using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1eee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Personel> liste = new List<Personel>()
            {

               new Personel () {Ad="Fikret",Yasi=23},

               new Personel () {Ad="Fatih",Yasi=22},

               new Personel () {Ad="Merve",Yasi=20},

               new Personel () {Ad="Ayşe",Yasi=21},

               new Personel () {Ad="velican",Yasi=41},





            };

            //dataGridView1.DataSource=liste.Where(x => x.Ad== "Fikret").ToList();
            //Adı "Fikret" olanların listesini getirir.
            //liste.Where (x => x.Ad=="Fikret").ToList();

            //dataGridView1.DataSource= liste.OrderBy(x => x.Yasi).ToList();
            //Yasa göre sıralama yapar,sırasıyla 20,21,22,23 olanları getirir.(Artan sıralama)



            //dataGridView2.DataSource=liste.OrderBy(x => x.Yasi).Skip(2).ToList();
            //dataGridView1.DataSource=liste.OrderBy(x => x.Yasi).ToList();  

            //skip Kullanımı
            //Liste üzerinde istediğimiz satır sayisi kadar atlama yapar
            //Örnerğin skip(3) dediğimizde 0. 1. ve 2. elemanları atlar ve direk 3. elemandan başlar


            //dataGridView1.DataSource=liste.Where(x => x.Ad.Contains("a")).Take(2).ToList();
            //Burada adında "a" içeren elemanları getir dedik
            //Normalde "fatih" ve "ayşe" gelicekti ,ama Take(1) dediğimiz için yalnızca "fatih" gelecek


            //textBox1.Text=liste.Any(x=> x.Ad=="Ayşe").ToString();
            //Kayıt var olduğu için True değeri döner.



            //textBox1.Text=liste.FirstOrDefault(p=>p.Yasi==23).Ad;    //yasi 23 olanı goster.
            //textBox1.Text = liste.FirstOrDefault(p => p.Ad == "Fikret").Yasi.ToString();



            dataGridView1.DataSource=liste.Where(p=> p.Ad.StartsWith("M")).ToList();
            //Adı "M" ile başlayanları getirir. Sonuc size "Merve " oalrak gelir


            //textBox1.Text = liste.Sum(p => p.Yasi).ToString();
            //Liste üzerindeki bütün yaşları toplar ve geriye "127 "  sonucu döner


            textBox1.Text=liste.Where(x=>x.Yasi== liste.Max(y=> y.Yasi)).Select(p=>p.Ad).FirstOrDefault();
            //Yaşı Max olan personelin ismini getirir, sonuç "velican " olarak geri döner


            textBox1.Text = liste.Find(p => p.Yasi == 21).Ad.ToString();
            //Yaşı 21 olan kişinin adını getirir.Sonuç "Ayşe " olarak geri döner.







        }
    }
}
