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
    public partial class Raporlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=Pastane;uid=sa;pwd=1903");
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu();
            anaMenu.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut=new SqlCommand("Select SaticiAdSoyad,Saticiİlce,Saticiİl as 'Bulundugu il'  from Satıcı order by Saticiİl", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select SaticiAdSoyad,Saticiİl as 'Bulundugu il'  from Satıcı order by SaticiAdSoyad asc ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select SaticiAdSoyad,Saticiİlce as 'Bulundugu ilce'  from Satıcı where Saticiİlce='Kadıköy' or Saticiİlce='Maltepe' order by SaticiAdSoyad asc ", baglanti);
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
            SqlCommand komut = new SqlCommand("Select UrunAdi,UrunFiyat from  Urunler where UrunAdi='pasta' and UrunFiyat>100  ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select UrunAdi,UrunFiyat,UretimTarihi,KullanimTarihi from  Urunler where'"+DateTime.Now.ToLongTimeString()+ "'<=KullanimTarihi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select MusteriNo,MusteriAdSoyad from Müsteriler order by MusteriAdSoyad asc ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select top 5 * from Müsteriler order by MusteriAdSoyad asc ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select MusteriNo,MusteriAdSoyad,SiparisAdet as 'Toplam Adet'from Sipariş S inner join Müsteriler M on S.SiparisNo=M.SiparisNo  ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Select SiparisAdi,SiparisAdet as 'Toplam Adet'from Sipariş order by SiparisAdi ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();
        }

        public void Donusturucu()
        {


            baglanti.Open();
            SqlCommand komut = new SqlCommand(Convert.ToDateTime("Select KullanimTarihi from Urunler"), baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Visible = true;
            baglanti.Close();

            string dateFormat = date.ToString("yyyy/MM/dd");


              string sql = "select * from TB_RICHIESTE where CONVERT(DATE, Date) <= CONVERT(DATE, '" + dateFormat + "')";


        }


    }
}
