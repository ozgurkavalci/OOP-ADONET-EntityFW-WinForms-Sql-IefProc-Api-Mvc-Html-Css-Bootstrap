using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7042022_Interface_Odev
{
    internal class Personel:Mudur,Ieleman,Ipersonel
    {
        private int yas;
        private string durumu;
        private int yemekucreti;
        private int yolucreti;
        private int maas;

        public int Yas
        { get { return yas; } set { yas = value; } }

        public string Durumu
        { get { return durumu; } set { durumu = value; } }  

        public int Yemekucreti
        { get { return yemekucreti; } set { yemekucreti = value; } }
        public int Yolucreti
        { get { return yolucreti; } set { yolucreti = value; } }
        public int Maas
        { get { return maas; } set { maas = value; } }

        public int YolParasiEkleme(int maas)
        {
            if (maas>8000)
            {
                int yollumaas =  1000;
                    return yollumaas;
            }
            else
            {
                int yollumaas =  1500;
                return yollumaas;
            }
        }

        public int MaasY(int aylik)
        {
            int yillikmaas = aylik * 12;
            return yillikmaas;
        }

        
    }
}
