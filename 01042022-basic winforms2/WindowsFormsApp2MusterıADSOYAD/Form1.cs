using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2MusterıADSOYAD
{
    public partial class Form1 : Form
    {
        public  double fiyat;
        public double fiyat2;
        public double fiyat3;   
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteriadi = textBox1.Text;
            string musterisoyadi= textBox2.Text;
            int siparisno=Convert.ToInt32(textBox3.Text);
            string telno=textBox4.Text;
            string adres=textBox5.Text;

            groupBox1.Show();
            numericUpDown1.Show();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox2.SelectedIndex==0)      //comboBox2.SelectedItem.ToString()=="Kebap"
            {
                checkBox1.Text = "Adana";
                checkBox2.Text = "Urfa";
                numericUpDown1.Show();
                checkBox1.Show();
                checkBox2.Show();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                
                

            }
            else if (comboBox2.SelectedIndex == 1)
            {
                checkBox1.Text = "Sucuk";
                checkBox2.Text = "Salam";
                checkBox3.Text = "Sosis";
                checkBox4.Text = "Mısır";
                checkBox5.Text = "Zeytin";
                checkBox6.Text = "Çedar";
                checkBox7.Text = "Soğan";

                numericUpDown1.Show();
                checkBox1.Show();
                checkBox2.Show();
                checkBox3.Show();
                checkBox4.Show();
                checkBox5.Show();
                checkBox6.Show();
                checkBox7.Show();
                
                
            }
            else if (comboBox2.SelectedIndex == 2)
            {

                checkBox1.Text = "Acılı";
                checkBox2.Text = "Acısız";
                numericUpDown1.Show();  
                checkBox1.Show();
                checkBox2.Show();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox3.Hide();
            checkBox4.Hide();
            checkBox5.Hide();
            checkBox6.Hide();
            checkBox7.Hide();
            numericUpDown1.Hide();
            groupBox1.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex==0)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();


               
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
               
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
               
            }
            else if (comboBox3.SelectedIndex == 3)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
               
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();


                
            }
            else if (comboBox4.SelectedIndex == 1)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                
            }
            else if (comboBox4.SelectedIndex == 2)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                
            }
            else if (comboBox4.SelectedIndex == 3)
            {
                
                checkBox1.Hide();
                checkBox2.Hide();
                checkBox3.Hide();
                checkBox4.Hide();
                checkBox5.Hide();
                checkBox6.Hide();
                checkBox7.Hide();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FısEkrani fiseat = new FısEkrani();

            int deger1 = Convert.ToInt32(comboBox2.SelectedIndex);
            double adet;

            switch (deger1)
            {
                case 0:
                    adet = Convert.ToDouble(numericUpDown1.Value);
                    fiyat += 30 * adet;
                    break;

                    case 1:
                    adet = Convert.ToDouble(numericUpDown1.Value);
                    fiyat += 35 * adet;

                    break;

                   case 2:
                    adet = Convert.ToDouble(numericUpDown1.Value);
                    fiyat += 10 * adet;
                    break;
                
            }
            
            
            int deger2 = Convert.ToInt32(comboBox3.SelectedIndex);
            double adet2;

            switch (deger2)
            {
                case 0:
                    adet2 = Convert.ToDouble(numericUpDown2.Value);
                    fiyat2 += 10 * adet2;
                    break;
                case 1:
                    adet2 = Convert.ToDouble(numericUpDown2.Value);
                    fiyat2 += 12 * adet2;

                    break;

                case 2:
                    adet2 = Convert.ToDouble(numericUpDown2.Value);
                    fiyat2 += 8* adet2;
                    break;

                    case 3:

                    adet2 = Convert.ToDouble(numericUpDown2.Value);
                    fiyat2 += 3 * adet2;
                    break;
                    

            }
            
            
            int deger3 = Convert.ToInt32(comboBox4.SelectedIndex);
            double adet3;

            switch (deger3)
            {
                case 0:
                    adet3 = Convert.ToDouble(numericUpDown3.Value);
                    fiyat3 += 10 * adet3;
                    break;
                case 1:
                    adet3 = Convert.ToDouble(numericUpDown3.Value);
                    fiyat3 += 10 * adet3;

                    break;

                case 2:
                    adet3 = Convert.ToDouble(numericUpDown3.Value);
                    fiyat3 += 25 * adet3;
                    break;

                case 3:

                    adet3 = Convert.ToDouble(numericUpDown3.Value);
                    fiyat3 += 10 * adet3;
                    break;


            }


           double donenfiyat = fiyat3 + fiyat2 + fiyat;

            

            

            fiseat.Show();
            this.Hide();
            fiseat.listBox1.Items.Add("Musteri adi:" + textBox1.Text);
            fiseat.listBox1.Items.Add("Musteri soyadi:" + textBox2.Text);
            fiseat.listBox1.Items.Add("Siparis no:" + textBox3.Text);
            fiseat.listBox1.Items.Add(numericUpDown1.Value+" adet " + comboBox2.SelectedItem);
            fiseat.listBox1.Items.Add(numericUpDown2.Value + " adet " + comboBox3.SelectedItem);
            fiseat.listBox1.Items.Add(numericUpDown3.Value + " adet " + comboBox4.SelectedItem);

            fiseat.listBox1.Items.Add("Odeme Turu:" + comboBox1.SelectedItem);
            fiseat.listBox1.Items.Add("Tel no:" + textBox4.Text);
            fiseat.listBox1.Items.Add("Adres:" + textBox5.Text);
            fiseat.listBox1.Items.Add("");
            fiseat.listBox1.Items.Add("Odemeniz gereken toplam ucret:" + donenfiyat);

            



        }

        

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
