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
    public partial class HastaEkrani : Form
    {
        public HastaEkrani()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Hastane;uid=sa;pwd=1903");

        private void HastaEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();  
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HEkle";
            cmd.Parameters.AddWithValue("HastaAdıveSoyadı",textBox3.Text);
            cmd.Parameters.AddWithValue("HastaTcNo", textBox2.Text);            
            cmd.Parameters.AddWithValue("HastaDoğumTarihi", textBox4.Text);
            cmd.Parameters.AddWithValue("HastaBoy", textBox5.Text);
            cmd.Parameters.AddWithValue("HastaYaş", textBox11.Text);
            cmd.Parameters.AddWithValue("HastaReçete", textBox14.Text);
            cmd.Parameters.AddWithValue("HastaRaporDurumu", textBox13.Text);
            cmd.Parameters.AddWithValue("HastaRandevuTarihi", textBox15.Text);
            cmd.Parameters.AddWithValue("HastaTelefon", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("HastaAdres", textBox10.Text);
            cmd.Parameters.AddWithValue("HastaMail", textBox17.Text);
            cmd.Parameters.AddWithValue("HizmetAldığıBölüm", textBox16.Text);
            cmd.Parameters.AddWithValue("DoktorNo ", comboBox1.Text);
            cmd.ExecuteNonQuery();
            HGOSTER();
            conn.Close();



        }

        public void HGOSTER()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HGOSTER";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HEkle";
            cmd.Parameters.AddWithValue("HastaNo", textBox1.Text);
            cmd.Parameters.AddWithValue("HastaAdıveSoyadı", textBox3.Text);
            cmd.Parameters.AddWithValue("HastaTcNo", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaDoğumTarihi", textBox4.Text);
            cmd.Parameters.AddWithValue("HastaBoy", textBox5.Text);
            cmd.Parameters.AddWithValue("HastaYaş", textBox11.Text);
            cmd.Parameters.AddWithValue("HastaReçete", textBox14.Text);
            cmd.Parameters.AddWithValue("HastaRaporDurumu", textBox13.Text);
            cmd.Parameters.AddWithValue("HastaRandevuTarihi", textBox15.Text);
            cmd.Parameters.AddWithValue("HastaTelefon", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("HastaAdres", textBox10.Text);
            cmd.Parameters.AddWithValue("HastaMail", textBox17.Text);
            cmd.Parameters.AddWithValue("HizmetAldığıBölüm", textBox16.Text);
            cmd.Parameters.AddWithValue("DoktorNo ", comboBox1.Text);
            cmd.ExecuteNonQuery();
            HGOSTER();
            conn.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HGOSTER();
            dataGridView1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HSil";
            cmd.Parameters.AddWithValue("HastaNo", textBox9.Text);
            cmd.ExecuteNonQuery();
            HGOSTER();
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "HListeleAZ";
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
            komut.CommandText = "HListeleZA";
            SqlDataAdapter dp = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sectim = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[sectim].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.Rows[sectim].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[sectim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[sectim].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[sectim].Cells[4].Value.ToString();
            textBox11.Text = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            textBox14.Text = dataGridView1.Rows[sectim].Cells[6].Value.ToString();
            textBox13.Text = dataGridView1.Rows[sectim].Cells[7].Value.ToString();
            textBox15.Text = dataGridView1.Rows[sectim].Cells[8].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[sectim].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.Rows[sectim].Cells[10].Value.ToString();
            textBox17.Text = dataGridView1.Rows[sectim].Cells[11].Value.ToString();
            textBox16.Text = dataGridView1.Rows[sectim].Cells[12].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[sectim].Cells[13].Value.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
