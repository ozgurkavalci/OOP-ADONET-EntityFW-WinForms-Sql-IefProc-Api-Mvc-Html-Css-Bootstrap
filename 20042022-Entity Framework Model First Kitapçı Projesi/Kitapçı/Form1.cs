using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitapçı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BookStoreContainer kitapci=new BookStoreContainer();    

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private bool Girisyap(string ad, string sifre)
        { 
           var sorgu= from p in kitapci.Kullanici
                      where p.KullaniciAdi == ad && p.KullaniciSifre == sifre
                      select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (Girisyap(txtKadi.Text, txtSifre.Text))
            { 
               AnaMenu anaMenu=new AnaMenu();
                anaMenu.ShowDialog();
                this.Hide();
            
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private bool KullaniciKayit(string ad, string sifre, string mail, string tel)
        {
            var kayit = from k in kitapci.Kullanici
                        where k.KullaniciAdi==ad || k.KullaniciSifre==sifre || k.KullaniciMail==mail || k.KulllaniciTelefon==tel
                        select k;
            if (kayit.Any())
            {
                return false;
            
            }
            else
            {
                return true;
            }
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (KullaniciKayit(txtKKadi.Text, txtKSifre.Text, txtEmail.Text, txtTel.Text) == false)
            {
                MessageBox.Show("Kayıt olmaya çalıştığınız bilgiler daha önce kullanılmış.Lütfen bilgileri gözden geçiriniz");

            }
            else
            {
                Kullanici kullaniciekle=new Kullanici();
                kullaniciekle.KullaniciAdi=txtKKadi.Text;
                kullaniciekle.KullaniciSifre=txtKSifre.Text;
                kullaniciekle.KullaniciMail=txtEmail.Text;
                kullaniciekle.KulllaniciTelefon=txtTel.Text;
                kitapci.Kullanici.Add(kullaniciekle);
                kitapci.SaveChanges();
                MessageBox.Show("Kayıt işleminiz başarıyla tamamlandı.");
                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
                this.Hide();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }
    }
}
