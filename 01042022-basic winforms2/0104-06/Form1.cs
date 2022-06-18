using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0104_06
{
    public partial class Form1 : Form
    {
        public double yfiyat;
        public double ifiyat;
        public double tfiyat;
        private double topfiyat;
        public string musteriad;
        public string musterisoyad;
        public string odeme;
        public int siparisno;
        public int telefon;
        public string adres;
        public string yemek;
        public string icecek;
        public string tatli;
        public double yemekadet;
        public double icecekadet;
        public double tatliadet;
        public string tercih;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriad = textBox1.Text;
            musterisoyad = textBox2.Text;
            odeme = textBox3.Text;
            siparisno = Convert.ToInt32(textBox4.Text);
            telefon = Convert.ToInt32(textBox5.Text);
            adres = textBox6.Text;

            groupBox1.Visible = true;

            


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
               
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            yemekadet = Convert.ToInt32(numericUpDown1.Value);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            icecekadet = Convert.ToInt32(numericUpDown2.Value);

        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            tatliadet = Convert.ToInt32(numericUpDown3.Value);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Lahmacun    -- 20 TL")
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                yemek = "Lahmacun";
                yfiyat += 20;
            }
            if (comboBox1.SelectedItem == "Kebap	-- 40 TL")
            {
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
                yemek = "Kebap";
                yfiyat += 40;
            }
            if (comboBox1.SelectedItem == "Dürüm	--25 TL")
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
                yemek = "Dürüm";
                yfiyat += 25;
            }
            
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                tercih = "Acılı";
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                tercih = "Acısız";
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                tercih = "Adana";
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                tercih = "Urfa";
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                tercih = "Et";
            }
        }
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                tercih = "Tavuk";
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0) // kola 10 ice8 su 4 fanta 7,5
            {
                ifiyat += 10;
                icecek = "Kola";
            }
            if (comboBox2.SelectedIndex == 1)
            {
                ifiyat += 8;
                icecek = "Ice Tea";
            }
            if (comboBox2.SelectedIndex == 2)
            {
                ifiyat += 4;
                icecek = "Su";
            }
            if (comboBox2.SelectedIndex == 3)
            {
                ifiyat += 7.5;
                icecek = "Fanta";
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                tfiyat +=  10;
                tatli = "Kazandibi";
            }
            if (comboBox3.SelectedIndex == 1)
            {
                tfiyat += 8.75;
                tatli = "Tulumba";
            }
            if (comboBox3.SelectedIndex == 2)
            {
                tfiyat += 15;
                tatli = "Cheesecake";
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            yfiyat = yfiyat * yemekadet;
            ifiyat = ifiyat * icecekadet;
            tfiyat = tfiyat * tatliadet;
            topfiyat = tfiyat + ifiyat + yfiyat;

            Fis fis = new Fis();
            fis.listBox1.Items.Add("İsim : " + musteriad);
            fis.listBox1.Items.Add("Soyisim : " + musterisoyad);
            fis.listBox1.Items.Add("Ödeme yöntemi : " + odeme);
            fis.listBox1.Items.Add("Sipariş no : " + siparisno);
            fis.listBox1.Items.Add("Telefon : " + telefon);
            fis.listBox1.Items.Add("Adres : " + adres);
            fis.listBox1.Items.Add("Yiyecek Tercihi : " + yemek);
            fis.listBox1.Items.Add("Yiyecek Adedi : " + yemekadet);
            fis.listBox1.Items.Add("Yiyecek ek özellik : " + tercih);
            fis.listBox1.Items.Add("İçecek Tercihi : " + icecek);
            fis.listBox1.Items.Add("İçecek Adedi : " + icecekadet);
            fis.listBox1.Items.Add("Tatlı Tercihi : " + tatli);
            fis.listBox1.Items.Add("Yemek fiyat : "+yfiyat);
            fis.listBox1.Items.Add("İçecek fiyat : " + ifiyat);
            fis.listBox1.Items.Add("Tatlı fiyat : " + tfiyat);

            fis.listBox1.Items.Add("Ödenecek tutar : " + topfiyat);

            fis.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
