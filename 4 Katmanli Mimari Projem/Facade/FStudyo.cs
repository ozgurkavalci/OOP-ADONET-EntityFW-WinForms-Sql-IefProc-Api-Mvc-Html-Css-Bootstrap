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
    public class FStudyo
    {

        public static int StudyoEkleme(EStudyo studyoekle)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("SEkle", Baglanti.con);

            try
            {
                
                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State!= ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("StudyoAdi", studyoekle.StudyoAdi);
                komut.Parameters.AddWithValue("StudyoKurulusTarih",studyoekle.StudyoKurulusTarih);
                komut.Parameters.AddWithValue("StudyoMerkez", studyoekle.StudyoMerkez);
                komut.Parameters.AddWithValue("StudyoNetDeger", studyoekle.StudyoNetDeger);

                return komut.ExecuteNonQuery();

            }
            catch (Exception )
            {
                
                return islem;   
            }
            finally
            {
                komut.Connection.Close();
            
            }
           
        }

        public static List<EStudyo> StudyoListele()
        {
            List<EStudyo> studyoListele = studyoListele = new List<EStudyo>();

            SqlCommand con = new SqlCommand("SListele", Baglanti.con);
            

            try
            {
                con.CommandType = CommandType.StoredProcedure;

                if (con.Connection.State!= ConnectionState.Open)
                {
                    con.Connection.Open();

                }

               SqlDataReader reader = con.ExecuteReader();

                if (reader.HasRows)
                {
                    //studyoListele = new List<EStudyo>();    
                    while (reader.Read())
                    {

                        EStudyo eStudyo=new EStudyo();
                        eStudyo.StudyoID = Convert.ToInt32(reader["StudyoID"]);
                        eStudyo.StudyoAdi=reader["StudyoAdi"].ToString();
                        eStudyo.StudyoKurulusTarih = Convert.ToDateTime(reader["StudyoKurulusTarih"]);
                        eStudyo.StudyoMerkez=reader["StudyoMerkez"].ToString() ;
                        eStudyo.StudyoNetDeger = Convert.ToDecimal(reader["StudyoNetDeger"]);
                        studyoListele.Add(eStudyo);
                    }
                }
                

            }
            catch (Exception)
            {

                studyoListele = null;
            }
            finally
            {
                con.Connection.Close();
            }

            return studyoListele;
        
        }

        public static int Sil(EStudyo studyosil)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("SSil", Baglanti.con);

            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();

                }

                komut.CommandType = CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("StudyoID", studyosil.StudyoID);
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

        public static int Guncelle(EStudyo studyoguncelle)
        {
            

            SqlCommand komut= new SqlCommand("SG",Baglanti.con);

            try
            {
                komut.CommandType=CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("StudyoID", studyoguncelle.StudyoID);
                komut.Parameters.AddWithValue("StudyoAdi", studyoguncelle.StudyoAdi);
                komut.Parameters.AddWithValue("StudyoKurulusTarih", studyoguncelle.StudyoKurulusTarih);
                komut.Parameters.AddWithValue("StudyoMerkez", studyoguncelle.StudyoMerkez);
                komut.Parameters.AddWithValue("StudyoNetDeger", studyoguncelle.StudyoNetDeger);
                return Baglanti.ExecuteNonQuery(komut); 

            }
            catch (Exception)
            {

                return -1;
            }
            finally
            { komut.Connection.Close(); }   
        
        
        }

        public static List<EStudyo> StudyoAdiArama(EStudyo eStudyo)
        {
            List<EStudyo> list = new List<EStudyo>();

            SqlCommand komut = new SqlCommand("SAdiArama", Baglanti.con);


            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                { komut.Connection.Open(); }

                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("StudyoAdi", eStudyo.StudyoAdi);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        eStudyo.StudyoID = Convert.ToInt32(reader["StudyoID"]);
                        eStudyo.StudyoAdi = reader["StudyoAdi"].ToString();
                        eStudyo.StudyoKurulusTarih = Convert.ToDateTime(reader["StudyoKurulusTarih"]);
                        eStudyo.StudyoMerkez = reader["StudyoMerkez"].ToString();
                        eStudyo.StudyoNetDeger = Convert.ToDecimal(reader["StudyoNetDeger"]);
                        list.Add(eStudyo);


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


        //public static DataTable StudyoIDDoldur()
        //{

        //    //SqlCommand komut = new SqlCommand("Select StudyoID from Studios", Baglanti.con);
        //    DataTable doldur = new DataTable();
        //    SqlDataAdapter goster=new SqlDataAdapter("Select StudyoID from Studios", Baglanti.con);
        //    goster.Fill(doldur);
        //    return doldur;
        
        
        //}


    }
}
