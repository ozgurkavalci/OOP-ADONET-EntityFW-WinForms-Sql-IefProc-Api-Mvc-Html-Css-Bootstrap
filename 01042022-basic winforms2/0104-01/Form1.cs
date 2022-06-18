using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0104_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kadi == "admin" && sifre == "12344")
            {
                MessageBox.Show("Giriş başarılı hoşgeldiniz sayın "+kadi);
                Admin go = new Admin();
                go.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı giriş tekrar deneyiniz...");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
