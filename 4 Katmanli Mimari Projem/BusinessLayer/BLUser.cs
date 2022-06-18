using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Facade;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class BLUser
    {

        public static List<EUser> BlUserEklemeKontrol(EUser ara)
        {

            return FUser.UserEklemeKontrol(ara);

        }


        public static int BLUserEkleme(EUser veri)
        {

            try
            {

                if (veri.UserName != null && veri.UserMail != null && veri.UserPw != null)
                {
                    return FUser.UserEkleme(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }

        }



        public static List<EUser> BlUserGirisKontrol(EUser ara)
        {

            return FUser.UserGirisKontrol(ara);

        }

    }
}
