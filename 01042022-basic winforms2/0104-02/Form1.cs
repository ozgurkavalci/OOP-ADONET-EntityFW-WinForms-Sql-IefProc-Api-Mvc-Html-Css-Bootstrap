using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0104_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maas = Convert.ToInt32(textBox1.Text);
            int mesai = Convert.ToInt32(textBox2.Text);
            int ücret = Convert.ToInt32(textBox3.Text);

            int hesap = maas + (mesai * ücret);

            listBox1.Items.Add("Maaş : " + textBox1.Text);
            listBox1.Items.Add("Mesai saati : " + textBox2.Text);
            listBox1.Items.Add("Saatlik ücret : " + textBox3.Text);
            listBox1.Items.Add("Alınan maaş : " + hesap);
        }
    }
}
