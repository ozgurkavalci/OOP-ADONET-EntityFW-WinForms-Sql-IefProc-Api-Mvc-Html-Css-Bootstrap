﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;


namespace Facade
{
    public class FPersonelBilgi
    {
        public static int Ekleme(EPersonelBilgi veri)
        {
            int islem = 0;

            try
            {
                SqlCommand komut = new SqlCommand("PersonelEkle", Baglanti.con);
                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("PersonelAdi", veri.PersonelAdi);
                islem = komut.ExecuteNonQuery();
            }
            catch (Exception)
            {

                islem = 1;
            }
            return islem;   

        
        
        }

        //-----------------LİSTELEME----------------

        public static List<EPersonelBilgi> Listele()
        {
            List<EPersonelBilgi> itemlist = null;


            SqlCommand con = new SqlCommand("Listele", Baglanti.con);
            try
            {
                
                con.CommandType = CommandType.StoredProcedure;

                if (con.Connection.State!=ConnectionState.Open)
                {
                    con.Connection.Open();
                }
                SqlDataReader rdr=con.ExecuteReader();
                if (rdr.HasRows)
                { 
                  itemlist = new List<EPersonelBilgi>();
                    while (rdr.Read())
                    { 
                         EPersonelBilgi item = new EPersonelBilgi();
                        item.ID= Convert.ToInt32(rdr["ID"]);
                        item.PersonelAdi = rdr["PersonelAdi"].ToString();
                        itemlist.Add(item);

                    
                    }
                
                }
            }
            catch (Exception)
            {
                itemlist = null;
                
            }

            finally
            {

                con.Connection.Close();
                //if (con.Connection.State!=ConnectionState.Open)
                //{
                //    con.Connection.Close();
                //}

            }
            return itemlist;
       
        }
        //------------------------GUNCELLE----------------------

        public static bool Guncelle(EPersonelBilgi islem)
        {

            SqlCommand komut = new SqlCommand("PersonelGuncelle", DigerBaglanti.con);

            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@PersonelAdi", islem.PersonelAdi);
            komut.Parameters.AddWithValue("@ID", islem.ID);

            return DigerBaglanti.ExecuteNonQuery(komut);

        }

        public static bool Sil(EPersonelBilgi islem)
        {
            SqlCommand komut = new SqlCommand("PersonelSilme", DigerBaglanti.con);

            komut.CommandType= CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@ID", islem.ID);

            return DigerBaglanti.ExecuteNonQuery(komut);

        }

    }
}
