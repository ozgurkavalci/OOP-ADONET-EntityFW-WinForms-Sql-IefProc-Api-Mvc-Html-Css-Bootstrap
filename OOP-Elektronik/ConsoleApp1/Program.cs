using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teknoloji urunleri magazasi");
            Console.WriteLine("1-Buzdolabi");
            Console.WriteLine("2-Notebook bilgisayarlar");
            Console.WriteLine("Lutfen bir secim yapiniz:");
            int secim=Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Buzdolabi buzdolabi = new Buzdolabi();
                    buzdolabi.BuzdolabiAnaMenu();
                    break;

                    case 2:
                    Notebook notebook = new Notebook();
                    notebook.notebookanamenu();

                    break;             
         
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
