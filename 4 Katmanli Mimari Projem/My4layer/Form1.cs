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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EUser ara = new EUser();
            ara.UserName = textBox9.Text;
            ara.UserPw = textBox8.Text;
            ara.UserMail = textBox7.Text;


            List<EUser> listele = BLUser.BlUserEklemeKontrol(ara);
            if (listele.Any())
            {
                MessageBox.Show("Kullanici adi veya Mail daha once alinmis lutfen yeniden deneyiniz...");
            }

            else
            {

                BLUser.BLUserEkleme(ara);

                MessageBox.Show("Kayit Islemi Basariyla Tamamlandi. Ana Menuye Yonlendiriliyorsunuz...");
                System.Threading.Thread.Sleep(4000);

                AnaMenu anaMenu = new AnaMenu();
                anaMenu.Show();
                this.Hide();


                

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EUser ara = new EUser();
            ara.UserName = textBox11.Text;
            ara.UserPw = textBox10.Text;


            List<EUser> listele = BLUser.BlUserGirisKontrol(ara);
            if (listele.Any())
            {
                MessageBox.Show("Hosgeldiniz...Ana Menuye yonlendiriliyorsunuz");
                System.Threading.Thread.Sleep(2000);

                AnaMenu anaMenu=new AnaMenu();
                anaMenu.Show();
                this.Hide();
            }

            else
            {     

                MessageBox.Show("Kullanici Adi veya Sifreniz Hatali.");
               
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}
