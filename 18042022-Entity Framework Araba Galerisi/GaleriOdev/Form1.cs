using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaleriOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GaleriEntities gal=new GaleriEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible= false;   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            
            string kullaniciadi = textBox11.Text;
            string sifre=textBox10.Text;
            Kullanici arat = new Kullanici();
           
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var kad = gal.Kullanicis.Where(x => x.KullaniciAdi == txtgirKadi.Text);

           

            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi=txtgirKadi.Text;
            kullanici.Sifre = txtSifre.Text;
            kullanici.Email = txtEmail.Text;
            kullanici.Telefon = txtTel.Text;
            gal.Kullanicis.Add(kullanici);
            gal.SaveChanges();


        }
    }
}
