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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut= new SqlCommand("Select*From Satıcı",baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();

            while (dr.Read()) 
            {
                comboBox1.Items.Add(dr["SaticiNo"]);
            
            
            }

            baglanti.Close();
        }
        //SqlConnection baglanti=new SqlConnection("Server = DESKTOP-MO5HLC4\\SQLEXPRESS; Database=Pastane;Integrated Security = true");
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");

        public void Listele(string baglan)
        { 
           SqlDataAdapter dr=new SqlDataAdapter(baglan,baglanti);
           DataSet doldur= new DataSet();
            dr.Fill(doldur);
            dataGridView1.DataSource = doldur.Tables[0];
        
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Listele("select*from Urunler");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Urunler(UrunAdi,UrunFiyat,KullanimTarihi,UretimTarihi,SaticiNo) values(@UrunAdi,@UrunFiyat,@KullanimTarihi,@UretimTarihi,@SaticiNo)", baglanti);

            komut.Parameters.AddWithValue("UrunAdi", textBox2.Text);
            komut.Parameters.AddWithValue("UrunFiyat", textBox3.Text);
            komut.Parameters.AddWithValue("KullanimTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("UretimTarihi", dateTimePicker2.Text);
            komut.Parameters.AddWithValue("SaticiNo", comboBox1.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            Listele("Select * From Urunler");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Urunler set UrunFiyat='" + textBox3.Text.ToString() + "' where UrunNo='" + textBox1.Text.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

            Listele("Select*From Urunler");
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text=dataGridView1.Rows[secim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete from Urunler where UrunNo=@UrunNo", baglanti);
            komut.Parameters.AddWithValue("@UrunNo",textBox1.Text);
            komut.ExecuteNonQuery();
            Listele("Select*From Urunler");
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select*From Urunler where UrunNo like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da=new SqlDataAdapter(komut);    
            DataSet ds=new DataSet();
            da.Fill(ds);    
            dataGridView1.DataSource=ds.Tables[0];
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

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Listele("select*from Urunler");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();   
            comboBox1.ResetText();
            dateTimePicker1.ResetText();    
            dateTimePicker2.ResetText();    
        }
    }
}
