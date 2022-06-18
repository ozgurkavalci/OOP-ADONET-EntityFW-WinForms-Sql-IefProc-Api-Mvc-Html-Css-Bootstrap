using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string musterino=textBox1.Text; 
            string isim=textBox2.Text;


            if (musterino=="845"&& isim=="nihoş")
            {
                MessageBox.Show("Sayın " + isim + " hosgeldiniz");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                

            }
            else
            {
                MessageBox.Show("Giris Basarısız tekrar dene...");
                textBox1.Text = "";
                textBox2.Clear();
            }
        }
    }
}
