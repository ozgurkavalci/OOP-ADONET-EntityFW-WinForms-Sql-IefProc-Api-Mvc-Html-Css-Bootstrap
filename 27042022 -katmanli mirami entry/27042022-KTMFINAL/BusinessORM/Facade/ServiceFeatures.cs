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
    public class ServiceFeatures
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("HOGor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        public static bool Ekle(ServiceFeature service1)
        {

            SqlCommand komut = new SqlCommand("HOEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@HizmetOzellikHizmetNo", service1.HizmetOzellikHizmetNo);
            komut.Parameters.AddWithValue("@HizmetAciklama", service1.HizmetAciklama);
            komut.Parameters.AddWithValue("@HizmetOzellikEkstra", service1.HizmetOzellikEkstra);

            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Guncelle(ServiceFeature service1)
        {

            SqlCommand komut = new SqlCommand("HOG", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@HizmetOzellikNo", service1.HizmetOzellikNo);
            komut.Parameters.AddWithValue("@HizmetOzellikHizmetNo", service1.HizmetOzellikHizmetNo);
            komut.Parameters.AddWithValue("@HizmetAciklama", service1.HizmetAciklama);
            komut.Parameters.AddWithValue("@HizmetOzellikEkstra", service1.HizmetOzellikEkstra);


            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Sil(ServiceFeature service1)
        {

            SqlCommand komut = new SqlCommand("HOSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@HizmetOzellikNo", service1.HizmetOzellikNo);

            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Doldur(ServiceFeature service1)
        {
            SqlCommand komut = new SqlCommand("select*from Hizmetler", Tools.Baglanti);
            SqlDataReader dr;
            dr = komut.ExecuteReader();

            
            return Tools.ExecuteNonQuery(komut);

        }


    }
}
