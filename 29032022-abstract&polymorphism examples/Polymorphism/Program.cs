using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            fransiz f1= new fransiz();
            f1.Selamver();

            Console.WriteLine();

            türk t1= new türk();
            t1.Selamver();
            Console.WriteLine();

            ingiliz i1= new ingiliz();  
            i1.Selamver();
            Console.ReadLine();


            
        }
    }
}
