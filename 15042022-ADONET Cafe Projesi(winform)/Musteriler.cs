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
    public partial class Musteriler : Form
    {

        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");
        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select*from Sipariş", baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["SiparisNo"]);
            
            
            }
            baglanti.Close();   
        }

        public void Listele(string baglan)
        {
            SqlDataAdapter dr = new SqlDataAdapter(baglan, baglanti);
            DataSet doldur=new DataSet();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];    

        
        
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Listele("select*from Müsteriler");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Müsteriler(MusteriAdSoyad,MusteriTelefon,SiparisNo) values(@MusteriAdSoyad,@MusteriTelefon,@SiparisNo)",baglanti);

            komut.Parameters.AddWithValue("MusteriAdSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("MusteriTelefon", textBox3.Text);
            komut.Parameters.AddWithValue("SiparisNo", comboBox1.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

            Listele("select*from Müsteriler");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("update Müsteriler set MusteriAdsoyad='"+textBox2.Text.ToString()+"',MusteriTelefon='"+textBox3.Text.ToString()+"',SiparisNo='"+comboBox1.Text.ToString()+"'where MusteriNo='"+textBox1.Text.ToString()+"'", baglanti);

            //komut.Parameters.AddWithValue("MusteriNo",textBox1.Text);
            //komut.Parameters.AddWithValue("MusteriAdSoyad", textBox2.Text);
            //komut.Parameters.AddWithValue("MusteriTelefon",textBox3.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            Listele("select*from Müsteriler");
        }

        private void button6_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select MusteriNo,MusteriAdSoyad from Müsteriler where MusteriNo like '%" + textBox5.Text + "%' and MusteriAdSoyad like '%" + textBox6.Text + "%'", baglanti);

            //SqlCommand komut = new SqlCommand("select MusteriNo,MusteriAdSoyad from Müsteriler where MusteriNo='"+textBox1.Text+"'and  MusteriAdSoyad='"+textBox2.Text+"'",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from Müsteriler where MusteriNo=@MusteriNo and MusteriAdSoyad=@MusteriAdSoyad", baglanti);
            komut.Parameters.AddWithValue("@MusteriNo", textBox1.Text);
            komut.Parameters.AddWithValue("@MusteriAdSoyad",textBox2.Text);
            komut.ExecuteNonQuery();
            Listele("select*from Müsteriler");
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
            textBox7.Clear();
            comboBox1.ResetText();  
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;    
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Listele("select*from Müsteriler");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu=new AnaMenu();
            anaMenu.Show();
            this.Hide();    
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
