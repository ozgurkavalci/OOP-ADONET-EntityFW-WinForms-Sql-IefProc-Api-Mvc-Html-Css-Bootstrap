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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Hastane;uid=;pwd=");

        //SqlConnection conn = new SqlConnection("Server = DESKTOP - MO5HLC4\\SQLEXPRESS; Database=Hastane;Integrated Security = true");


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "KEkle";
            cmd.Parameters.AddWithValue("KullanıcıAdı", textBox4.Text);
            cmd.Parameters.AddWithValue("Sifre", textBox3.Text);
            cmd.Parameters.AddWithValue("EMail", textBox5.Text);
            cmd.Parameters.AddWithValue("Telefon", textBox6.Text);
            cmd.ExecuteNonQuery();
            conn.Close();




        }
    }
}
