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
    public partial class DoktorEkrani : Form
    {
        public DoktorEkrani()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Hastane;uid=sa;pwd=1903");

        //SqlConnection conn = new SqlConnection("Server = DESKTOP-MO5HLC4\\SQLEXPRESS; Database=Hastane;Integrated Security = true");

        private void DoktorEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "DListeleAZ";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DEkle";
            cmd.Parameters.AddWithValue("DoktorAdıveSoyadı", textBox2.Text);
            cmd.Parameters.AddWithValue("DoktoTcNo", textBox3.Text);
            cmd.Parameters.AddWithValue("UzmanlıkAlanı", textBox4.Text);
            cmd.Parameters.AddWithValue("Unvanı", textBox5.Text);
            cmd.Parameters.AddWithValue("TelefonNumarası", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("Adres", textBox10.Text);
            cmd.Parameters.AddWithValue("DoğumTarihi", textBox11.Text);
            cmd.Parameters.AddWithValue("PoliklinikNo", comboBox1.Text);
            cmd.ExecuteNonQuery();
            DGOSTER();
            conn.Close();



        }

        public void DGOSTER()
        { 
           SqlCommand cmd = new SqlCommand();
           cmd.Connection= conn;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "DGOSTER";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;

        
        
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

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DG";
            cmd.Parameters.AddWithValue("DoktorNo", textBox1.Text);
            cmd.Parameters.AddWithValue("DoktorAdıveSoyadı", textBox2.Text);
            cmd.Parameters.AddWithValue("DoktoTcNo", textBox3.Text);
            cmd.Parameters.AddWithValue("UzmanlıkAlanı", textBox4.Text);
            cmd.Parameters.AddWithValue("Unvanı", textBox5.Text);
            cmd.Parameters.AddWithValue("TelefonNumarası", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("Adres", textBox10.Text);
            cmd.Parameters.AddWithValue("DoğumTarihi", textBox11.Text);
            cmd.Parameters.AddWithValue("PoliklinikNo", comboBox1.Text);
            cmd.ExecuteNonQuery();
            DGOSTER();
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public void GosterDNo()
        {
            if (textBox7!=null && textBox8==null & textBox6.Text==null)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DGorDNo";
                cmd.Parameters.AddWithValue("DoktorNo", textBox7.Text);

                cmd.ExecuteNonQuery();

                conn.Close();

                //SqlDataAdapter dp = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //dp.Fill(dt);
                //dataGridView1.DataSource = dt;
            }

        }

        public void GosterDADS()
        { 
        
        
        }

        public void GosterDTcNO()
        { 
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DSil";
            cmd.Parameters.AddWithValue("DoktorNo", textBox9.Text);
            cmd.ExecuteNonQuery();
            DGOSTER();
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "DListeleZA";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DGOSTER();
            dataGridView1.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.Rows[sectim].Cells[6].Value.ToString();
            textBox11.Text = dataGridView1.Rows[sectim].Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[sectim].Cells[8].Value.ToString();
            
        }
    }
}
