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

namespace _15042022_Pastane
{
    public partial class GirisEkrani : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");

        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //SqlCommand komut = new SqlCommand("select KullaniciAd,KullaniciSifre from KullaniciGiris where KullaniciAd='"+textBox11.Text+"'and KullaniciSifre='"+textBox10.Text+"'",baglanti);

            SqlCommand komut = new SqlCommand("select*from KullaniciGiris where KullaniciAd='" + textBox11.Text + "' and KullaniciSifre='" + textBox10.Text + "'", baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                AnaMenu git = new AnaMenu();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız veya Şifreni Hatalı. Kontrol Ediniz.");
                textBox11.Clear();
                textBox10.Clear();
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitKontrol();
            if (ickontrol==true)
            {
                baglanti.Open();
                SqlCommand command = new SqlCommand("insert into KullaniciGiris(KullaniciAd,KullaniciSifre,Email,Telefon) values (@KullaniciAd,@KullaniciSifre,@Email,@Telefon)", baglanti);
                command.Parameters.AddWithValue("@KullaniciAd", textBox9.Text);
                command.Parameters.AddWithValue("@KullaniciSifre", textBox8.Text);
                command.Parameters.AddWithValue("@Email", textBox7.Text);
                command.Parameters.AddWithValue("@Telefon", textBox4.Text);
                command.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tebrikler! Başarılı bir şekilde kayit oldunuz.");
                AnaMenu git = new AnaMenu();
                git.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("Kayit olmak isteginiz bilgilerden en az biri sisteme daha once girilmis.Lutfen kayit bilgilerinizi kontrol Ediniz.");

            }

        }

        public bool ickontrol;

        public void KayitKontrol()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from KullaniciGiris where KullaniciAd='" + textBox9.Text + "' or KullaniciSifre='" + textBox8.Text + "' or EMail='" + textBox7.Text + "' or Telefon='" + textBox4.Text + "'", baglanti);

            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                ickontrol = false;  
            }
            else
            {
                ickontrol=true;
            }
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }
    }
}
