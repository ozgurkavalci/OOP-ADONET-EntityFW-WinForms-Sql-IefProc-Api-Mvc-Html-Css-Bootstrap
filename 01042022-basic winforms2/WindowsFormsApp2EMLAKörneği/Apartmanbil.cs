using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2EMLAKörneği
{
    public partial class Apartmanbil : Form
    {
        public Apartmanbil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int donenfiyat;
            string apadi = textBox1.Text;
            string apno= textBox2.Text;
            int apkatsayi = Convert.ToInt32(textBox3.Text);
            int apodasayi= Convert.ToInt32(textBox4.Text);  
            int fiyat= Convert.ToInt32(textBox6.Text);
            if (apkatsayi>=10 || apodasayi>=5)
            {
                donenfiyat = fiyat * 110 / 100;
            }
            else
            {
                donenfiyat = fiyat * 105 / 100;
            }
            listBox1.Show();
            listBox1.Items.Add("Apartman Adı:"+apadi);
            listBox1.Items.Add("Apartman No:" + apno);
            listBox1.Items.Add("Kat Sayısı:" + apkatsayi);
            listBox1.Items.Add("Oda Sayısı:" + apodasayi);
            listBox1.Items.Add("Girilen Fiyat:" + fiyat);
            listBox1.Items.Add("En son fiyat:" + donenfiyat);

            SonucEkranı al = new SonucEkranı();
            al.Show();

            al.listBox1.Items.Add("Apartman Adı:" + apadi);
            al.listBox1.Items.Add("Apartman No:" + apno);
            al.listBox1.Items.Add("Kat Sayısı:" + apkatsayi);
            al.listBox1.Items.Add("Oda Sayısı:" + apodasayi);
            al.listBox1.Items.Add("Girilen Fiyat:" + fiyat);
            al.listBox1.Items.Add("En son fiyat:" + donenfiyat);

        }

        private void Apartmanbil_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
        }
    }
}
