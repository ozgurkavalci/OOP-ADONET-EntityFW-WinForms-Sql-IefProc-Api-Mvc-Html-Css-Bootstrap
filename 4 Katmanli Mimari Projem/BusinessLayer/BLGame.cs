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
    public class BLGame
    {
        public static int BLGameEkleme(EGame veri)
        {

            try
            {

                if (veri.OyunTuru != null && veri.OyunAdi != null)
                {
                    return FGame.GameEkleme(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }

        }


        public static List<EGame> BLGameListele()
        {
            return FGame.GameListele();

        }

        public static int BLGameSilme(EGame veri)
        {

            try
            {
                if (veri.OyunID > 0)
                {
                    return FGame.Sil(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }



        }


        public static List<EGame> BlGameAdArama(EGame ara)
        {

            return FGame.GameAdArama(ara);

        }

    }
}
