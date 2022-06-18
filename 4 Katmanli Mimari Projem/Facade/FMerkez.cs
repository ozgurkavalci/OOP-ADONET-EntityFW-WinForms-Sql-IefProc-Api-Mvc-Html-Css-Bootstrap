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
    public class FMerkez
    {
        public static int MerkezEkleme(EMerkez merkezekle)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("CEkle", Baglanti.con);

            try
            {

                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("MerkezLokasyon", merkezekle.MerkezLokasyon);
                komut.Parameters.AddWithValue("MerkezKurulusTarihi", merkezekle.MerkezKurulusTarihi);
                komut.Parameters.AddWithValue("MerkezCalisanSayisi", merkezekle.MerkezCalisanSayisi);
                komut.Parameters.AddWithValue("MerkezYillikCiro", merkezekle.MerkezYillikCiro);
                komut.Parameters.AddWithValue("StudyoID", merkezekle.StudyoID);
                komut.Parameters.AddWithValue("StudyoAdi", merkezekle.StudyoAdi);

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



        public static List<EMerkez> MerkezListele()
        {
            List<EMerkez> merkezListele = new List<EMerkez>();

            SqlCommand con = new SqlCommand("CListele", Baglanti.con);


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

                        EMerkez eMerkez = new EMerkez();
                        eMerkez.MerkezID = Convert.ToInt32(reader["MerkezID"]);
                        eMerkez.MerkezLokasyon = reader["MerkezLokasyon"].ToString();
                        eMerkez.MerkezKurulusTarihi = Convert.ToDateTime(reader["MerkezKurulusTarihi"]);                     
                        eMerkez.MerkezCalisanSayisi = Convert.ToInt32(reader["MerkezCalisanSayisi"]);
                        eMerkez.MerkezYillikCiro = Convert.ToDecimal(reader["MerkezYillikCiro"]);
                        eMerkez.StudyoID = Convert.ToInt32(reader["StudyoID"]);
                        eMerkez.StudyoAdi = reader["StudyoAdi"].ToString();
                        merkezListele.Add(eMerkez);
                    }
                }


            }
            catch (Exception)
            {

                merkezListele = null;
            }
            finally
            {
                con.Connection.Close();
            }

            return merkezListele;

        }


        public static int Sil(EMerkez merkezsil)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("CSil", Baglanti.con);

            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();

                }

                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("MerkezID", merkezsil.MerkezID);
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

        public static int Guncelle(EMerkez merkezguncelle)
        {


            SqlCommand komut = new SqlCommand("CG", Baglanti.con);

            try
            {
                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("MerkezID", merkezguncelle.MerkezID);
                komut.Parameters.AddWithValue("MerkezLokasyon", merkezguncelle.MerkezLokasyon);
                komut.Parameters.AddWithValue("MerkezKurulusTarihi", merkezguncelle.MerkezKurulusTarihi);
                komut.Parameters.AddWithValue("MerkezCalisanSayisi", merkezguncelle.MerkezCalisanSayisi);
                komut.Parameters.AddWithValue("MerkezYillikCiro", merkezguncelle.MerkezYillikCiro);
                komut.Parameters.AddWithValue("StudyoID", merkezguncelle.StudyoID);
                komut.Parameters.AddWithValue("StudyoAdi", merkezguncelle.StudyoAdi);

                return Baglanti.ExecuteNonQuery(komut);

            }
            catch (Exception)
            {

                return -1;
            }
            finally
            { komut.Connection.Close(); }


        }



        public static List<EMerkez> MerkezLokasyonArama(EMerkez eMerkez)
        {
            List<EMerkez> list = new List<EMerkez>();

            SqlCommand komut = new SqlCommand("CLokasyonArama", Baglanti.con);


            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                { komut.Connection.Open(); }

                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("MerkezLokasyon", eMerkez.MerkezLokasyon);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        eMerkez.MerkezID = Convert.ToInt32(reader["MerkezID"]);
                        eMerkez.MerkezLokasyon = reader["MerkezLokasyon"].ToString();
                        eMerkez.MerkezKurulusTarihi = Convert.ToDateTime(reader["MerkezKurulusTarihi"]);
                        eMerkez.MerkezCalisanSayisi = Convert.ToInt32(reader["MerkezCalisanSayisi"]);
                        eMerkez.MerkezYillikCiro = Convert.ToDecimal(reader["MerkezYillikCiro"]);
                        eMerkez.StudyoID = Convert.ToInt32(reader["StudyoID"]);
                        eMerkez.StudyoAdi = reader["StudyoAdi"].ToString();

                        list.Add(eMerkez);


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
