using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class KH : Form
    {
        public KH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tip;
            string durum;
            string birim=comboBox1.SelectedItem.ToString();
            if (radioButton1.Checked == true)
            {
                tip = radioButton1.Text;
            
            
            }
            else
            {
                tip = radioButton2.Text;
            }
            if (checkBox1.Checked == true)
            {
                durum = checkBox1.Text;


            }
            else
            {
                durum = checkBox2.Text;
            }
            listBox1.Show();
            listBox1.Items.Add("İşlem birim:" + birim);
            listBox1.Items.Add("İşlem tipi:" + tip);
            listBox1.Items.Add("İşlem durumu:" + durum);
            listBox1.Items.Add("İşlem tarih:" + dateTimePicker1.Value);

        }

        private void KH_Load(object sender, EventArgs e)
        {
            listBox1.Hide();
        }
    }
}
