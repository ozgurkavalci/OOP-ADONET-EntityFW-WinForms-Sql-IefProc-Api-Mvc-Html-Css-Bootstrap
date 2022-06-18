using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using System.Data.SqlClient;

namespace Facade
{
    public class FUser
    {
        public static List<EUser> UserEklemeKontrol(EUser Userekle)
        {
            List<EUser> list = new List<EUser>();

            SqlCommand komut = new SqlCommand("UEkleKontrol", Baglanti.con);


            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                { komut.Connection.Open(); }

                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("UserName", Userekle.UserName);
                komut.Parameters.AddWithValue("UserMail", Userekle.UserMail);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Userekle.UserID = Convert.ToInt32(reader["UserID"]);
                        Userekle.UserName = reader["UserName"].ToString();
                        Userekle.UserPw = reader["UserPw"].ToString();
                        Userekle.UserName = reader["UserMail"].ToString();



                        list.Add(Userekle);


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


        public static int UserEkleme(EUser userekle)
        {
            int islem = 0;

            SqlCommand komut = new SqlCommand("UEkle", Baglanti.con);

            try
            {

                komut.CommandType = CommandType.StoredProcedure;

                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }

                komut.Parameters.AddWithValue("UserName", userekle.UserName);
                komut.Parameters.AddWithValue("UserPw", userekle.UserPw);
                komut.Parameters.AddWithValue("UserMail", userekle.UserMail);


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


        public static List<EUser> UserGirisKontrol(EUser Userekle)
        {
            List<EUser> list = new List<EUser>();

            SqlCommand komut = new SqlCommand("UArama", Baglanti.con);


            try
            {
                if (komut.Connection.State != ConnectionState.Open)
                { komut.Connection.Open(); }

                komut.CommandType = CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("UserName", Userekle.UserName);
                komut.Parameters.AddWithValue("UserPw", Userekle.UserPw);

                SqlDataReader reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Userekle.UserID = Convert.ToInt32(reader["UserID"]);
                        Userekle.UserName = reader["UserName"].ToString();
                        Userekle.UserPw = reader["UserPw"].ToString();
                        Userekle.UserName = reader["UserMail"].ToString();



                        list.Add(Userekle);


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
