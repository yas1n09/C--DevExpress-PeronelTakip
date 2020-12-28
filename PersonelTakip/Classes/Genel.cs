using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PersonelTakip.Classes
{
    public class Genel
    {
        public static bool izinacikmi = false;
        public static bool mesaiacikmi = false;
        public static bool personelacikmi = false;
        public static bool maasacikmi = false;
        public static bool primacikmi = false;



        public static string connStr = "Data Source=DESKTOP-G3T65MN;Initial Catalog=PersonelTakip;Integrated Security=True";
    }
}