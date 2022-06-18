using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using Facade;

namespace BusinessLayer
{
    public class BLDeveloper
    {

        public static int BLDeveloperEkleme(EDeveloper veri)
        {

            try
            {

                if (veri.AdSoyad != null && veri.UzmanlikAlani != null && veri.Ulke != null)
                {
                    return FDeveloper.DeveloperEkleme(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }

        }


        public static List<EDeveloper> BLDeveloperListele()
        {
            return FDeveloper.DeveloperListele();

        }




        public static int BLDeveloperSilme(EDeveloper veri)
        {

            try
            {
                if (veri.DeveloperID > 0)
                {
                    return FDeveloper.Sil(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }



        }


        public static List<EDeveloper> BlDeveloperAdArama(EDeveloper ara)
        {

            return FDeveloper.DeveloperAdArama(ara);

        }

    }
}
