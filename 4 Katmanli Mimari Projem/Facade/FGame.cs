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
    public class FGame
    {
        public static int GameEkleme(EGame gameekle)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("GEkle", Baglanti.con);

            try
            {

                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("OyunTuru", gameekle.OyunTuru);
                komut.Parameters.AddWithValue("OyunAdi", gameekle.OyunAdi);
                komut.Parameters.AddWithValue("OyunCikisTarihi", gameekle.OyunCikisTarihi);
                komut.Parameters.AddWithValue("OyunSatilanKopya", gameekle.OyunSatilanKopya);
                komut.Parameters.AddWithValue("AdSoyad", gameekle.AdSoyad);
                komut.Parameters.AddWithValue("StudyoAdi", gameekle.StudyoAdi);
                

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


        public static List<EGame> GameListele()
        {
            List<EGame> gameListele = new List<EGame>();

            SqlCommand con = new SqlCommand("GListele", Baglanti.con);


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
                        
                    while (reader.Read())
                    {
                        EGame eGame=new EGame();

                        eGame.OyunID = Convert.ToInt32(reader["OyunID"]);
                        eGame.OyunTuru=reader["OyunTuru"].ToString();
                        eGame.OyunAdi = reader["OyunAdi"].ToString();
                        eGame.OyunCikisTarihi = Convert.ToDateTime(reader["OyunCikisTarihi"]);
                        eGame.OyunSatilanKopya = Convert.ToInt32(reader["OyunSatilanKopya"]);
                        eGame.AdSoyad = reader["AdSoyad"].ToString();
                        eGame.StudyoAdi = reader["StudyoAdi"].ToString();
                        gameListele.Add(eGame);
         
                    }
                }


            }
            catch (Exception)
            {

                gameListele = null;
            }
            finally
            {
                con.Connection.Close();
            }

            return gameListele;

        }

        public static int Sil(EGame gamesil)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("GSil", Baglanti.con);

            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();

                }

                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("OyunID", gamesil.OyunID);
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


        public static int Guncelle(EGame gameekle)
        {

            SqlCommand komut = new SqlCommand("GG", Baglanti.con);

            try
            {
                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("OyunID", gameekle.OyunID);
                komut.Parameters.AddWithValue("OyunTuru", gameekle.OyunTuru);
                komut.Parameters.AddWithValue("OyunAdi", gameekle.OyunAdi);
                komut.Parameters.AddWithValue("OyunCikisTarihi", gameekle.OyunCikisTarihi);
                komut.Parameters.AddWithValue("OyunSatilanKopya", gameekle.OyunSatilanKopya);
                komut.Parameters.AddWithValue("AdSoyad", gameekle.AdSoyad);
                komut.Parameters.AddWithValue("StudyoAdi", gameekle.StudyoAdi);

                return Baglanti.ExecuteNonQuery(komut);

            }
            catch (Exception)
            {

                return -1;
            }
            finally
            { komut.Connection.Close(); }



        }


        public static List<EGame> GameAdArama(EGame eGame)
        {
            List<EGame> list = new List<EGame>();

            SqlCommand komut = new SqlCommand("GAdArama", Baglanti.con);


            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                { komut.Connection.Open(); }

                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("OyunAdi", eGame.OyunAdi);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        eGame.OyunID = Convert.ToInt32(reader["OyunID"]);
                        eGame.OyunTuru = reader["OyunTuru"].ToString();
                        eGame.OyunAdi = reader["OyunAdi"].ToString();
                        eGame.OyunCikisTarihi = Convert.ToDateTime(reader["OyunCikisTarihi"]);
                        eGame.OyunSatilanKopya = Convert.ToInt32(reader["OyunSatilanKopya"]);
                        eGame.AdSoyad = reader["AdSoyad"].ToString();
                        eGame.StudyoAdi = reader["StudyoAdi"].ToString();

                        list.Add(eGame);

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
