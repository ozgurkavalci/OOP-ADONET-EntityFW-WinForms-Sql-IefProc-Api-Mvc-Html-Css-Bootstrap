using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessORM.Entity;
using System.Data.SqlClient;

namespace BusinessORM.Facade
{
    public class Customers
    {


        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("MGor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        public static bool Ekle(Customer c1)
        {

            SqlCommand komut = new SqlCommand("MEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@MusteriAdSoyad", c1.MusteriAdSoyad);
            komut.Parameters.AddWithValue("@MusteriCinsiyet", c1.MusteriCinsiyet);
            komut.Parameters.AddWithValue("@MusteriTelefon", c1.MusteriTelefon);
            komut.Parameters.AddWithValue("@MusteriTcNO", c1.MusteriTcNo);
            komut.Parameters.AddWithValue("@MusteriAdres", c1.MusteriAdres);
            komut.Parameters.AddWithValue("@MusteriHizmetNo", c1.MusteriHizmetNo);
            komut.Parameters.AddWithValue("@MusteriMail", c1.MusteriMail);

            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Guncelle(Customer c1)
        {

            SqlCommand komut = new SqlCommand("MG", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@MusteriNo", c1.MusteriNo);
            komut.Parameters.AddWithValue("@MusteriAdSoyad", c1.MusteriAdSoyad);
            komut.Parameters.AddWithValue("@MusteriCinsiyet", c1.MusteriCinsiyet);
            komut.Parameters.AddWithValue("@MusteriTelefon", c1.MusteriTelefon);
            komut.Parameters.AddWithValue("@MusteriTcNO", c1.MusteriTcNo);
            komut.Parameters.AddWithValue("@MusteriAdres", c1.MusteriAdres);
            komut.Parameters.AddWithValue("@MusteriHizmetNo", c1.MusteriHizmetNo);
            komut.Parameters.AddWithValue("@MusteriMail", c1.MusteriMail);

            return Tools.ExecuteNonQuery(komut);

        }


        public static bool Sil(Customer c1)
        {

            SqlCommand komut = new SqlCommand("MSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@MusteriNo", c1.MusteriNo);

            return Tools.ExecuteNonQuery(komut);

        }

    }
}
