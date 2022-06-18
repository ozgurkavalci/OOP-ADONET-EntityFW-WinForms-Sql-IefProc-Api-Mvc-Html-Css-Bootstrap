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

namespace _12042022_HastaneProjesi
{
    public partial class PoliEkrani : Form
    {
        public PoliEkrani()
        {
            InitializeComponent();
        }


        //SqlConnection conn = new SqlConnection("Server = DESKTOP-MO5HLC4\\SQLEXPRESS; Database=Hastane;Integrated Security = true");
        SqlConnection conn = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Hastane;uid=sa;pwd=1903");

        private void PoliEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PEkle";
            cmd.Parameters.AddWithValue("PoliklinikAdı", textBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanSayısı", textBox3.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşkanı", textBox4.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşHemşire", textBox5.Text);
            cmd.Parameters.AddWithValue("YatakSayısı", textBox6.Text);
            cmd.ExecuteNonQuery();
            PoliGOSTER();

            conn.Close();
            
        }

        public void Goster()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PGorPNo";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox1.Text);


            cmd.ExecuteNonQuery();

            conn.Close();

            //SqlDataAdapter dp = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //dp.Fill(dt);
            //dataGridView1.DataSource = dt;



        }

        public void GosterAd()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PGorPAdı";
            cmd.Parameters.AddWithValue("PoliklinikAdı", textBox2.Text);
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;




        }

        private void button6_Click(object sender, EventArgs e)
        {
            string text7=textBox7.ToString();
            string text8=textBox8.ToString();   

            if (!String.IsNullOrEmpty(text7) && String.IsNullOrEmpty(text8))
            {

                //conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PGorPNo";
                //cmd.Parameters.AddWithValue("PoliklinikNo", textBox1.Text);

                //cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                //conn.Close();
                //Goster();
            
            
            }
            else if(textBox7.Text == null && textBox8.Text != null)
            {
                GosterAd();
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı bir değer girilmedi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PG";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox1.Text);
            cmd.Parameters.AddWithValue("PoliklinikAdı", textBox2.Text);
            cmd.Parameters.AddWithValue("PoliklinikUzmanSayısı", textBox3.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşkanı", textBox4.Text);
            cmd.Parameters.AddWithValue("PoliklinikBaşHemşire", textBox5.Text);
            cmd.Parameters.AddWithValue("YatakSayısı", textBox6.Text);
            cmd.ExecuteNonQuery();
            PoliGOSTER();


            conn.Close();




        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PSil";
            cmd.Parameters.AddWithValue("PoliklinikNo", textBox1.Text);
            cmd.ExecuteNonQuery();

            PoliGOSTER();
            conn.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "PListeleAZ";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "PListeleZA";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecimEkrani secimEkrani = new SecimEkrani();
            secimEkrani.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            
        }

        public void PoliGOSTER()
        {


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PGOSTER";
            
            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PoliGOSTER();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
