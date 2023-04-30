using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane.Models
{
    internal class Book
    {
        public int code { get; set; }
        public string nameOfBook { get; set; }
        public string? ReleaseDate{ get; set; }
        public string ReleasePlace{ get; set; }
        public int numberOfPages { get; set; }
        public int Author_code { get; set; }
        public int User_code { get; set; }

        public int Publisher_code { get; set; }






    }
}
