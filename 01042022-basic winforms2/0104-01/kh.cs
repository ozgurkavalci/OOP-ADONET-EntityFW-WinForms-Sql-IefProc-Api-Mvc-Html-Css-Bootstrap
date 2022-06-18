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
    public partial class kh : Form
    {
        public kh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tip;
            string durum;
            string birim = comboBox1.SelectedItem.ToString();

            if (radioButton1.Checked == true)
            {
                tip = radioButton1.Text;
            }
            else
            {
                tip = radioButton2.Text;
            }

            //******************************************//

            if (checkBox1.Checked == true)
            {
                durum = checkBox1.Text;
            }
            else
            {
                durum = checkBox2.Text;
            }
            listBox1.Items.Add("İşlem birimi : " + birim);
            listBox1.Items.Add("İşlem Tipi : " + tip);
            listBox1.Items.Add("İşlem Durum : " + durum);
            listBox1.Items.Add("İşlem Tarihi : " + dateTimePicker1.Value);
            listBox1.Visible = true;

        }

        private void kh_Load(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
    }
}
