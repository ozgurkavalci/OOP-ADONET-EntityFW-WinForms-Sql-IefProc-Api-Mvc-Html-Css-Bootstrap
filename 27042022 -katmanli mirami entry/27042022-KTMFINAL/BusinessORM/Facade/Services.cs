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
    public class Services
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("HGor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        public static bool Ekle(Service service1)
        {

            SqlCommand komut = new SqlCommand("HEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@HizmetAdi", service1.HizmetAdi);
            komut.Parameters.AddWithValue("@HizmetTanimi", service1.HizmetTanimi);
            komut.Parameters.AddWithValue("@HizmetFiyat", service1.HizmetFiyat);

            return Tools.ExecuteNonQuery(komut);

        }


        public static bool Guncelle(Service service1)
        {

            SqlCommand komut = new SqlCommand("HG", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@HizmetNo", service1.HizmetNo);
            komut.Parameters.AddWithValue("@HizmetAdi", service1.HizmetAdi);
            komut.Parameters.AddWithValue("@HizmetTanimi", service1.HizmetTanimi);
            komut.Parameters.AddWithValue("@HizmetFiyat", service1.HizmetFiyat);

            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Sil(Service service1)
        {

            SqlCommand komut = new SqlCommand("HSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@HizmetNo", service1.HizmetNo);

            return Tools.ExecuteNonQuery(komut);

        }
    }
}
