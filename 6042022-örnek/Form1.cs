using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6042022_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "ozgur" && textBox2.Text.ToLower() == "1234")

            { 
                
                this.Hide();
                Kategoriler kategori= new Kategoriler();    
                kategori.Show();


            
            
            }
            else
            {
                MessageBox.Show("Hatalı Giriş...");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
