using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7042022_Interface_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

            Personel p1= new Personel();
            p1.Calismasaati = Convert.ToInt32(textBox1.Text);
            p1.Mesaisaati= Convert.ToInt32(textBox2.Text);
            p1.Prim= Convert.ToInt32(textBox3.Text);    
            p1.Ikramiye= Convert.ToInt32(textBox4.Text);    
            p1.Maas= Convert.ToInt32(textBox5.Text);    
            p1.Yas= Convert.ToInt32(textBox6.Text);
            p1.Durumu = textBox7.Text;
            p1.Yemekucreti= Convert.ToInt32(textBox8.Text); 
            p1.Yolucreti= Convert.ToInt32(textBox9.Text);

            int zamliyol = p1.YolParasiEkleme(p1.Maas);
            int yillikmaas = p1.MaasY(p1.Maas);
            int mesaidengelen = p1.Mesaisaati * 50;
            
            int aylikelegecentoplam = p1.Maas + mesaidengelen/12 + p1.Ikramiye / 12 + p1.Prim / 12 + zamliyol + p1.Yemekucreti;
            int yillikelegecentoplam = yillikmaas + mesaidengelen + p1.Ikramiye + p1.Prim + zamliyol * 12 + p1.Yemekucreti * 12;

            listBox1.Items.Add("Total calisma saati:" + p1.Calismasaati*12);
            listBox1.Items.Add("Total mesai saati:" + p1.Mesaisaati);
            listBox1.Items.Add("Prim:" + p1.Prim);
            listBox1.Items.Add("Ikramiye:" + p1.Ikramiye);
            listBox1.Items.Add("Aylik ucret:" + p1.Maas);
            listBox1.Items.Add("Yas:" + p1.Yas);
            listBox1.Items.Add("Durumu:" + p1.Durumu);
            listBox1.Items.Add("Aylik yemek Ucreti:" + p1.Yemekucreti);
            listBox1.Items.Add("Aylik yol Ucreti:" + p1.Yolucreti);
            listBox1.Items.Add("Yeni aylik yol Ucretiniz:" + zamliyol);
            listBox1.Items.Add("Total yillik ucretiniz(sadece  maas icerir):" + yillikmaas);
            listBox1.Items.Add("Aylik total ucretiniz:" + aylikelegecentoplam);
            listBox1.Items.Add("Yillik total ucretiniz:" + yillikelegecentoplam);







        }
    }
}
