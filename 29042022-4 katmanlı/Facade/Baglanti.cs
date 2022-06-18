using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Facade
{
    public class Baglanti
    {
        public static readonly SqlConnection con = new SqlConnection("Server=DESKTOP-MO5HLC4\\SQLEXPRESS;Database=Getir;Integrated Security=true");

    }
}
