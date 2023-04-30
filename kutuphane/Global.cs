using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kutuphane.Helpers;
using kutuphane.Models;


namespace kutuphane
{
    internal static class Global
    {
        internal static string ConnectionString = "Server =localhost; User ID =root; Password=Mysql2001.;Database=mydb";
        internal static User? User { get; set; }
    }

    
}
