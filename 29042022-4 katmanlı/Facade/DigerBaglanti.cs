﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    public class DigerBaglanti
    {
        public static readonly SqlConnection con = new SqlConnection("Server=DESKTOP-MO5HLC4\\SQLEXPRESS;Database=Getir;Integrated Security=true");



        public static bool ExecuteNonQuery(SqlCommand komut)
        {

            try
            {

                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {

                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();


            }


        }
    }
}
