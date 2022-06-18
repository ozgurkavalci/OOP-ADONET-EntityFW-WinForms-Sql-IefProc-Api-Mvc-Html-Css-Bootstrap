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
    public class BLStudyo
    {

        public static int BLStudyoEKleme(EStudyo veri)
        {

            try
            {

                if (veri.StudyoAdi!= null && veri.StudyoKurulusTarih!=null && veri.StudyoMerkez!=null )
                {
                    return FStudyo.StudyoEkleme(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
   
        }

        public static List<EStudyo> BLStudyoListele()
        { 
           return FStudyo.StudyoListele();
           
        }

        public static int BLStudyoSilme(EStudyo veri)
        {

            try
            {
                if (veri.StudyoID>0)
                {
                    return FStudyo.Sil(veri);
                }
                return 1;
            }
            catch (Exception)
            {

                return -1;
            }
        
        
        
        }

        public static List<EStudyo> BlStudyoAdiArama(EStudyo ara)
        {     
                    
          return FStudyo.StudyoAdiArama(ara);
              
        }


    }
}
