using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0104_05
{
    public partial class Apartman : Form
    {
        public Apartman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kat = 1;
            string apadi = textBox1.Text;
            int apno = Convert.ToInt32(textBox2.Text);
            kat = Convert.ToInt32(textBox3.Text);
            int oda = Convert.ToInt32(textBox4.Text);
            int fiyat = Convert.ToInt32(textBox5.Text);
            int apadii = 1;
            if (apadi == "Mr. Simon")
            {
                apadii = 2;
            }

            if (kat > 3)
            {
                kat = 2;
            }

            int sonuc = oda * fiyat * kat * apadii;

            Form2 form2 = new Form2();
            form2.textBox1.Text = apadi;
            form2.textBox2.Text = Convert.ToString(apno);
            form2.textBox3.Text = Convert.ToString(kat);
            form2.textBox4.Text = Convert.ToString(oda);
            form2.textBox5.Text = Convert.ToString(fiyat);
            form2.textBox6.Text = Convert.ToString(sonuc);

            form2.listBox1.Items.Add("Apartman adı : " + apadi);
            form2.listBox1.Items.Add("Apartman No : " + apno);
            form2.listBox1.Items.Add("Apartman kat : " + kat);
            form2.listBox1.Items.Add("Apartman oda : " + oda);
            form2.listBox1.Items.Add("Apartman fiyat : " + fiyat);
            form2.listBox1.Items.Add("Apartman sonuç : " + sonuc);
            

            form2.Show();
            this.Hide();

        }

        private void Apartman_Load(object sender, EventArgs e)
        {
           
        }
    }
}
