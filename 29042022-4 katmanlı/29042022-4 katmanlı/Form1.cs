using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;
using BusinessLayer;
using System.Data.SqlClient;

namespace _29042022_4_katmanlı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void Liste()
        { 
           List<EPersonelBilgi> personellisteleme = BLPersonelBilgi.Listele();
            dataGridView1.DataSource = personellisteleme;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            textBox1.Text=row.Cells["PersonelAdi"].Value.ToString();
            textBox1.Tag = row.Cells["ID"].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EPersonelBilgi ekleme= new EPersonelBilgi();
            ekleme.PersonelAdi = textBox1.Text;
            if (BLPersonelBilgi.Ekleme(ekleme)>0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EPersonelBilgi k= new EPersonelBilgi(); 
            k.PersonelAdi = textBox1.Text;
            k.ID = (int)textBox1.Tag;
            if (!FPersonelBilgi.Guncelle(k))
            {
                MessageBox.Show("Güncellenemedi");
            }
            Liste();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            EPersonelBilgi k= new EPersonelBilgi();
            k.ID=(int)dataGridView1.CurrentRow.Cells["ID"].Value;
            if (!FPersonelBilgi.Sil(k))
                MessageBox.Show("Silinmedi");
            Liste();
           
        }
    }
}
