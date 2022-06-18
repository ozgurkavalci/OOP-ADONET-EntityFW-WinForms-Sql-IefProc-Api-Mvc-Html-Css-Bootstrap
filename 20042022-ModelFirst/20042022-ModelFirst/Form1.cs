using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20042022_ModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MalzemelerContainer baglanti=new MalzemelerContainer();

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Malzeme.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Malzeme ekle=new Malzeme();
            ekle.MalzemeAdi = textBox2.Text;
            ekle.Adet=Convert.ToInt32(textBox3.Text);
            ekle.Fiyat=Convert.ToDecimal(textBox4.Text);
            ekle.DepoAdi = textBox5.Text;
            baglanti.Malzeme.Add(ekle);
            baglanti.SaveChanges();

            dataGridView1.DataSource=baglanti.Malzeme.ToList(); 


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox2.Tag = satir.Cells["MalzemeId"].Value.ToString();
            textBox2.Text = satir.Cells["MalzemeAdi"].Value.ToString();
            textBox3.Text = satir.Cells["Adet"].Value.ToString();
            textBox4.Text = satir.Cells["Fiyat"].Value.ToString();
            textBox5.Text = satir.Cells["DepoAdi"].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(textBox2.Tag);
            Malzeme yenile = baglanti.Malzeme.SingleOrDefault(c => c.MalzemeId == id);
            
            yenile.MalzemeAdi = textBox2.Text;
            yenile.Adet = Convert.ToInt32(textBox3.Text);
            yenile.Fiyat = Convert.ToDecimal(textBox4.Text);
            yenile.DepoAdi = textBox5.Text;
            
            baglanti.SaveChanges();

            dataGridView1.DataSource = baglanti.Malzeme.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox2.Tag);
            Malzeme yenile = baglanti.Malzeme.SingleOrDefault(c => c.MalzemeId == id);
            baglanti.Malzeme.Remove(yenile);
            baglanti.SaveChanges();
            dataGridView1.DataSource=baglanti.Malzeme.ToList();
        }
    }
}
