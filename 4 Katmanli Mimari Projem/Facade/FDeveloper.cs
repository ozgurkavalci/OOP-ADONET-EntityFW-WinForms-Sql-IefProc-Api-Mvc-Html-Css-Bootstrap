using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;



namespace Facade
{
    public class FDeveloper
    {
        public static int DeveloperEkleme(EDeveloper developerekle)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("DEkle", Baglanti.con);

            try
            {

                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("AdSoyad", developerekle.AdSoyad);
                komut.Parameters.AddWithValue("Yas", developerekle.Yas);
                komut.Parameters.AddWithValue("Cinsiyet", developerekle.Cinsiyet);
                komut.Parameters.AddWithValue("Ulke", developerekle.Ulke);
                komut.Parameters.AddWithValue("IseBaslamaTarihi", developerekle.IseBaslamaTarihi);
                komut.Parameters.AddWithValue("UzmanlikAlani", developerekle.UzmanlikAlani);
                komut.Parameters.AddWithValue("MerkezID", developerekle.MerkezID);

                return komut.ExecuteNonQuery();

            }
            catch (Exception)
            {

                return islem;
            }
            finally
            {
                komut.Connection.Close();

            }

        }

        public static List<EDeveloper> DeveloperListele()
        {
            List<EDeveloper> developerListele = new List<EDeveloper>();

            SqlCommand con = new SqlCommand("DListele", Baglanti.con);


            try
            {
                con.CommandType = CommandType.StoredProcedure;

                if (con.Connection.State != ConnectionState.Open)
                {
                    con.Connection.Open();

                }

                SqlDataReader reader = con.ExecuteReader();

                if (reader.HasRows)
                {
                    //studyoListele = new List<EStudyo>();    
                    while (reader.Read())
                    {

                        EDeveloper eDeveloper = new EDeveloper();
                        eDeveloper.DeveloperID = Convert.ToInt32(reader["DeveloperID"]);
                        eDeveloper.AdSoyad = reader["AdSoyad"].ToString();
                        eDeveloper.Yas = Convert.ToInt32(reader["Yas"]);
                        eDeveloper.Cinsiyet = reader["Cinsiyet"].ToString();
                        eDeveloper.Ulke = reader["Ulke"].ToString();
                        eDeveloper.IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"]);
                        eDeveloper.UzmanlikAlani = reader["UzmanlikAlani"].ToString();
                        eDeveloper.MerkezID = Convert.ToInt32(reader["MerkezID"]);
                        developerListele.Add(eDeveloper);
                    }
                }


            }
            catch (Exception)
            {

                developerListele = null;
            }
            finally
            {
                con.Connection.Close();
            }

            return developerListele;

        }


        public static int Sil(EDeveloper developersil)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("DSil", Baglanti.con);

            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();

                }

                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("DeveloperID", developersil.DeveloperID);
                return komut.ExecuteNonQuery();

            }
            catch (Exception)
            {

                return islem;
            }
            finally
            {
                komut.Connection.Close();
            }

        }

        public static int Guncelle(EDeveloper developerekle)
        {

            SqlCommand komut = new SqlCommand("DG", Baglanti.con);

            try
            {
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("DeveloperID", developerekle.DeveloperID);
                komut.Parameters.AddWithValue("AdSoyad", developerekle.AdSoyad);
                komut.Parameters.AddWithValue("Yas", developerekle.Yas);
                komut.Parameters.AddWithValue("Cinsiyet", developerekle.Cinsiyet);
                komut.Parameters.AddWithValue("Ulke", developerekle.Ulke);
                komut.Parameters.AddWithValue("IseBaslamaTarihi", developerekle.IseBaslamaTarihi);
                komut.Parameters.AddWithValue("UzmanlikAlani", developerekle.UzmanlikAlani);
                komut.Parameters.AddWithValue("MerkezID", developerekle.MerkezID);

                return Baglanti.ExecuteNonQuery(komut);

            }
            catch (Exception)
            {

                return -1;
            }
            finally
            { komut.Connection.Close(); }



        }


        public static List<EDeveloper> DeveloperAdArama(EDeveloper eDeveloper)
        {
            List<EDeveloper> list = new List<EDeveloper>();

            SqlCommand komut = new SqlCommand("DAdArama", Baglanti.con);


            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                { komut.Connection.Open(); }

                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("AdSoyad", eDeveloper.AdSoyad);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        eDeveloper.DeveloperID = Convert.ToInt32(reader["DeveloperID"]);
                        eDeveloper.AdSoyad = reader["AdSoyad"].ToString();
                        eDeveloper.Yas = Convert.ToInt32(reader["Yas"]);
                        eDeveloper.Cinsiyet = reader["Cinsiyet"].ToString();
                        eDeveloper.Ulke = reader["Ulke"].ToString();
                        eDeveloper.IseBaslamaTarihi = Convert.ToDateTime(reader["IseBaslamaTarihi"]);
                        eDeveloper.UzmanlikAlani = reader["UzmanlikAlani"].ToString();
                        eDeveloper.MerkezID = Convert.ToInt32(reader["MerkezID"]);

                        list.Add(eDeveloper);


                    }
                }


            }
            catch (Exception)
            {
                list = null;

            }
            finally
            { komut.Connection.Close(); }


            return list;

        }

    }
}
