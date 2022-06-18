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
    public class BLMerkez
    {

        public static int BLMerkezEkleme(EMerkez veri)
        {

            try
            {

                if (veri.MerkezLokasyon != null && veri.MerkezKurulusTarihi != null && veri.StudyoAdi!= null)
                {
                    return FMerkez.MerkezEkleme(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }

        }

        public static List<EMerkez> BLMerkezListele()
        {
            return FMerkez.MerkezListele();

        }


        public static int BLMerkezSilme(EMerkez veri)
        {

            try
            {
                if (veri.MerkezID > 0)
                {
                    return FMerkez.Sil(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }



        }


        public static List<EMerkez> BlMerkezLokasyonArama(EMerkez ara)
        {

            return FMerkez.MerkezLokasyonArama(ara);

        }
    }
}
