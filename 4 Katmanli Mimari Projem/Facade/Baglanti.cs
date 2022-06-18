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
    public class Baglanti
    {
        public static readonly SqlConnection con = new SqlConnection("Server=DESKTOP-RAE0GS2;Database=GameRef;uid=sa;pwd=1903");

        public static int ExecuteNonQuery(SqlCommand komut)
        {

            try
            {

                if (komut.Connection.State != ConnectionState.Open)
                    komut.Connection.Open();
                return komut.ExecuteNonQuery() ;
            }
            catch (Exception)
            {

                return -1;
            }
            finally
            {

                if (komut.Connection.State != ConnectionState.Closed)
                    komut.Connection.Close();


            }


        }

    }
}
