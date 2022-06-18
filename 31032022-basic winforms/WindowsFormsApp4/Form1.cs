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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sifre=textBox2.Text; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kullaniciAdi=textBox1.Text;  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower()=="özgür" && textBox2.Text.ToLower()=="1903")
            {
                Form2 anamenu = new Form2();
                anamenu.Show();
                this.Hide();
            }
            else
            {

            }
        }
    }
}
