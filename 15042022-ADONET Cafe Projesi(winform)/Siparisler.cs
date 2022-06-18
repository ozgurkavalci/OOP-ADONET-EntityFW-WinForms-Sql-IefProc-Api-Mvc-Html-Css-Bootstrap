using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _15042022_Pastane
{
    public partial class Siparisler : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;

            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select*From Urunler", baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["UrunNo"]);


            }

            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();    
            anaMenu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void Listele(string baglan)
        {
            dataGridView1.Visible = true;
            SqlDataAdapter dr = new SqlDataAdapter(baglan, baglanti);
            DataSet doldur = new DataSet();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Listele("select*from Sipariş");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Sipariş(SiparisAdi,SiparisAdres,SiparisAdet,SiparisFiyat,UrunNo,Tutar) values (@SiparisAdi,@SiparisAdres,@SiparisAdet,@SiparisFiyat,@UrunNo,@Tutar)", baglanti);

            komut.Parameters.AddWithValue("@SiparisAdi", textBox2.Text);
            komut.Parameters.AddWithValue("@SiparisAdres", textBox3.Text);
            komut.Parameters.AddWithValue("@SiparisAdet", textBox4.Text);
            komut.Parameters.AddWithValue("@SiparisFiyat", textBox5.Text);
            komut.Parameters.AddWithValue("@UrunNo", comboBox1.Text);
            komut.Parameters.AddWithValue("@Tutar", textBox6.Text);


            komut.ExecuteNonQuery();

            baglanti.Close();
            Listele("select*from Sipariş");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update Sipariş set SiparisAdi='"+textBox2.Text.ToString()+"',SiparisAdres='"+textBox3.Text.ToString()+"',SiparisAdet='"+textBox4.Text.ToString()+"',SiparisFiyat='"+textBox5.Text.ToString()+"',UrunNo='"+comboBox1.Text.ToString()+"',Tutar='"+textBox6.Text.ToString()+"'where SiparisNo='"+textBox1.Text +"'",baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele("select*from Sipariş");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            comboBox1.Text=dataGridView1.Rows[secim].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele("select*from Sipariş");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from Sipariş where SiparisNo=@SiparisNo", baglanti);
            komut.Parameters.AddWithValue("@SiparisNo", textBox9.Text);
            komut.ExecuteNonQuery();
            Listele("Select*From Sipariş");
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*From Sipariş where SiparisNo like '%" + textBox8.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox8.Clear();
            textBox9.Clear();
            comboBox1.ResetText();  
        }
    }
}
