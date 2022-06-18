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
    public partial class TeshisEkrani : Form
    {
        public TeshisEkrani()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Hastane;uid=sa;pwd=1903"); //ev



        private void TeshisEkrani_Load(object sender, EventArgs e)
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

        public void TGOSTER()
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TGOSTER";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Visible = true;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible=false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TGOSTER();
            //dataGridView1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "TListeleAZ";
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
            komut.CommandText = "TListeleZA";
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
            cmd.CommandText = "TEkle2";
            cmd.Parameters.AddWithValue("HastaNo", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaAdıveSoyadı", textBox3.Text);
            cmd.Parameters.AddWithValue("TeşhisiKoyanDoktorAdı", textBox4.Text);
            cmd.Parameters.AddWithValue("TeşhisiKoyanDoktorNo", textBox5.Text);
            cmd.Parameters.AddWithValue("TeşhisinKonduğuBölümAdı", textBox6.Text);
            cmd.Parameters.AddWithValue("TeşhisinKonduğuBölümNo", textBox11.Text);
            cmd.Parameters.AddWithValue("TeşhisTarihi", textBox12.Text);           
            cmd.ExecuteNonQuery();
            TGOSTER();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TG2";
            cmd.Parameters.AddWithValue("TeşhisNo", textBox1.Text);
            cmd.Parameters.AddWithValue("HastaNo", textBox2.Text);
            cmd.Parameters.AddWithValue("HastaAdıveSoyadı", textBox3.Text);          
            cmd.Parameters.AddWithValue("TeşhisiKoyanDoktorAdı", textBox4.Text);
            cmd.Parameters.AddWithValue("TeşhisiKoyanDoktorNo", textBox5.Text);
            cmd.Parameters.AddWithValue("TeşhisinKonduğuBölümAdı", textBox6.Text);
            cmd.Parameters.AddWithValue("TeşhisinKonduğuBölümNo", textBox11.Text);
            cmd.Parameters.AddWithValue("TeşhisTarihi", textBox12.Text);
            cmd.ExecuteNonQuery();
            TGOSTER();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TSil";
            cmd.Parameters.AddWithValue("TeşhisNo", textBox1.Text);
            cmd.ExecuteNonQuery();
            TGOSTER();
            conn.Close();
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
            textBox6.Text = dataGridView1.Rows[sectim].Cells[5].Value.ToString();
            textBox11.Text = dataGridView1.Rows[sectim].Cells[6].Value.ToString();
            textBox12.Text = dataGridView1.Rows[sectim].Cells[7].Value.ToString();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
