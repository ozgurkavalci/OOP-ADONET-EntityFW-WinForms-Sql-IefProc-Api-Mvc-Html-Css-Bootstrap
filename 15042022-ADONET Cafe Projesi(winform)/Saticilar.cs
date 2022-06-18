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
    public partial class Saticilar : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");

        public Saticilar()
        {
            InitializeComponent();
        }

        private void Saticilar_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;  
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
            Listele("Select*from Satıcı");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Satıcı(SaticiAdSoyad,SaticiAdres,Saticiİl,Saticiİlce) values (@SaticiAdSoyad,@SaticiAdres,@Saticiİl,@Saticiİlce)",baglanti);

            komut.Parameters.AddWithValue("@SaticiAdSoyad", textBox2.Text);
            komut.Parameters.AddWithValue("@SaticiAdres", textBox3.Text);
            komut.Parameters.AddWithValue("@Saticiİl", textBox4.Text);
            komut.Parameters.AddWithValue("@Saticiİlce", textBox5.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();
            Listele("Select*from Satıcı");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand komut = new SqlCommand("update Satıcı set SaticiAdSoyad='"+textBox2.Text.ToString()+"',SaticiAdres='"+textBox3.Text.ToString()+ "',Saticiİl='"+textBox4.Text.ToString()+ "',Saticiİlce='"+textBox5.Text.ToString()+"'where SaticiNo='" + textBox1.Text + "'", baglanti);
        

            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele("Select*from Satıcı");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SaticiNo,SaticiAdSoyad from Satıcı where SaticiNo='"+textBox7.Text+"' and SaticiAdSoyad like '%"+textBox6.Text+"%'",baglanti);
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
            SqlCommand komut = new SqlCommand("delete from  Satıcı where SaticiNo=@SaticiNo and  SaticiAdSoyad=@SaticiAdSoyad",baglanti);
            komut.Parameters.AddWithValue("@SaticiNo", textBox8.Text);
            komut.Parameters.AddWithValue("@SaticiAdSoyad", textBox9.Text);


            komut.ExecuteNonQuery();
            Listele("select*from Satıcı");
            baglanti.Close();
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Listele("select*from Satıcı");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
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
            textBox8.Clear();
            textBox9.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            
            textBox4.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
        }
    }
}
