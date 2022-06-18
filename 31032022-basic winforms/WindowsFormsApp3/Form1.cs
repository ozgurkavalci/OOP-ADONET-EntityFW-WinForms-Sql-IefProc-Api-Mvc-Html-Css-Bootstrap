using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            button5.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int topla=sayi1 + sayi2;
            button5.Text = topla.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int cikar = sayi1 - sayi2;
            button5.Text = cikar.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int carp = sayi1 * sayi2;
            button5.Text = carp.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            button5.Visible = true;
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int bol = sayi1 / sayi2;
            button5.Text = bol.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            button5.Text=0.ToString();  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menuler git=new Menuler();  
            git.Show();
            this.Hide();

        }

        
    }
}
