using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2Maas_mesai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double maas = Convert.ToDouble(textBox1.Text);
            double mesaisaati=Convert.ToDouble(textBox2.Text);
            double mesaiucret=Convert.ToDouble(textBox3.Text);

            double toplamucret = (mesaisaati * mesaiucret) + maas;
            label4.Show();
            listBox1.Show();
            listBox1.Items.Add(toplamucret);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
            label4.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
