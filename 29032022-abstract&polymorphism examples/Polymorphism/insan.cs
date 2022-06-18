using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    
    abstract class insan
    {
        /*Polimorfizim cok sekıllılık cok bıcımlılık
         * virtual---> sanal  ana classda
         * override---> yavru classlar da var olan metodu ez ve benım islemlerimi kullan diyorum.
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         */

        public virtual void Selamver() // ana classda virtual olarak tanımlanırç
        {
            Console.WriteLine("Selam veriniz.");
        
        }

    }
}
