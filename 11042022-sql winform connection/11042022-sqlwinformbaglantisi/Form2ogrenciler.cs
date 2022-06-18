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


namespace _11042022_sqlwinformbaglantisi
{
    public partial class Form2ogrenciler : Form
    {
        public Form2ogrenciler()
        {
            InitializeComponent();
        }

        /*SqlConnection con = new SqlConnection("Server=.;Database=Okul;uid=sa;pwd=1234"); */       //sql authentication oldugu icin
        /*SqlConnection con1 = new SqlConnection("Server=DESKTOP-MO5HLC4\\SQLEXPRESS;Database=Okul;Integrated Security=true"); */ //win authentication oldugu icin
        SqlConnection con1 = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Okul;uid=sa;pwd=1903");


        private void Form2ogrenciler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = con1;
            //komut.CommandType = CommandType.StoredProcedure;
            //komut.CommandText = "OG";
            //SqlDataAdapter dp=new SqlDataAdapter(komut);
            //DataTable dt = new DataTable();
            //dp.Fill(dt);
            //dataGridView1.DataSource=dt;
            Goster();
        }
        public void Goster()
        {

            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OG";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            con1.Open();    
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OAdd";
            komut.Parameters.AddWithValue("Adsoyad",textBox2.Text);
            komut.Parameters.AddWithValue("TcNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("Mail", textBox3.Text);
            komut.Parameters.AddWithValue("Adres", textBox4.Text);
            komut.Parameters.AddWithValue("DersNo", textBox5.Text);
            komut.ExecuteNonQuery();    

            con1.Close();
            Goster();
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OSL";
            komut.Parameters.AddWithValue("OgrenciNo", textBox1.Text);
            komut.ExecuteNonQuery();
            con1.Close();
            Goster();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con1;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "OY";
            komut.Parameters.AddWithValue("OgrenciNo", textBox1.Text);
            komut.Parameters.AddWithValue("Adsoyad", textBox2.Text);
            komut.Parameters.AddWithValue("TcNo", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("Telefon", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("Mail", textBox3.Text);
            komut.Parameters.AddWithValue("Adres", textBox4.Text);
            komut.Parameters.AddWithValue("DersNo", textBox5.Text);
            komut.ExecuteNonQuery();

            con1.Close();
            Goster();

           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            maskedTextBox1.Text= dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sectim].Cells[6].Value.ToString();
            


        }

        public void HucreleriTemizle()
        {

            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            HucreleriTemizle();
        }
    }
}
