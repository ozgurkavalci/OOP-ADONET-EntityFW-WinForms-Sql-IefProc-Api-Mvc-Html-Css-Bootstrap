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
    public class Orders
    {
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SGor", Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        public static bool Ekle(Order o1)
        {

            SqlCommand komut = new SqlCommand("SEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@SiparisAdi", o1.SiparisAdi);
            komut.Parameters.AddWithValue("@SiparisMusteriNo", o1.SiparisMusteriNo);
            komut.Parameters.AddWithValue("@SiparisAdres", o1.SiparisAdres);
            komut.Parameters.AddWithValue("@SiparisAciklama", o1.SiparisAciklama);


            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Guncelle(Order o1)
        {

            SqlCommand komut = new SqlCommand("SG", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@SiparisNo", o1.SiparisNo);
            komut.Parameters.AddWithValue("@SiparisAdi", o1.SiparisAdi);
            komut.Parameters.AddWithValue("@SiparisMusteriNo", o1.SiparisMusteriNo);
            komut.Parameters.AddWithValue("@SiparisAdres", o1.SiparisAdres);
            komut.Parameters.AddWithValue("@SiparisAciklama", o1.SiparisAciklama);


            return Tools.ExecuteNonQuery(komut);

        }

        public static bool Sil(Order o1)
        {

            SqlCommand komut = new SqlCommand("SSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@SiparisNo", o1.SiparisNo);

            return Tools.ExecuteNonQuery(komut);

        }

    }
}
