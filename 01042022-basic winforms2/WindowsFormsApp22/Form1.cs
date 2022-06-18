using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 git=new Form2();
            git.textBox1.Text = textBox1.Text;
            git.textBox2.Text = textBox2.Text;
            git.listBox1.Items.Add("marka:" + textBox1.Text);
            git.listBox1.Items.Add("model:" + textBox2.Text);
            git.Show();
            this.Hide();    
        }
    }
}
