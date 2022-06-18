using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7042022_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //C# Interface, yapısı gereği diğer sınıflara yol gösterici ,rehberlik yapmak için oluşturulan,kendisinden implement
            // edilen bir sınıfa doldurulması zorunlu olan bazı özelliklerin aktarılmasını sağlayan bir kavramdır

            // sınıf yapılarınımız birden fazla interface ile implement edilebilir
            // içerisinde metot oluşumları ve propertyler dışında kod blokları bulunmaz
            //Interface yapılarınımızda bulunan tüm özellikşer public olarak kabul edilir

            // Bir İnterface (arayüz) yapısını başka bir interface tarafından türetebiliriz

            //SInıflar implement ettiği interface içerisindeki bulunan tüm özellikleri impelement etmek zroundadır.

            listBox1.Visible = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Show();
            Musteriler custom1= new Musteriler(); 
            custom1.Mno=Convert.ToInt32(textBox1.Text);
            custom1.Madsoyad = textBox2.Text;
            custom1.Telefon = maskedTextBox1.Text;
            custom1.Mail = textBox3.Text;
            custom1.Adres = textBox4.Text;
            custom1.Limit=Convert.ToInt32(textBox5.Text);
            custom1.Odeme=Convert.ToInt32(textBox6.Text);

            int s1 = custom1.Tutar(custom1.Limit, custom1.Odeme);
            int s2 = custom1.Kampanya(custom1.Limit);
            string s3 = custom1.Konum(custom1.Odeme, custom1.Adres);

            listBox1.Items.Add("Musteri no:"+custom1.Mno);
            listBox1.Items.Add("Musteri Adsoyad:" + custom1.Madsoyad);
            listBox1.Items.Add("Musteri Telefon:" + custom1.Telefon);
            listBox1.Items.Add("Musteri Mail:" + custom1.Mail);
            listBox1.Items.Add("Musteri Adres:" + custom1.Adres);
            listBox1.Items.Add("Musteri Limit:" + custom1.Limit);
            listBox1.Items.Add("Musteri Ödeme:" + custom1.Odeme);

            listBox1.Items.Add("Toplam Tutar:" + s1);
            listBox1.Items.Add("Kampanya:" + s2);
            listBox1.Items.Add("Konum:" + s3);





        }
    }
}
