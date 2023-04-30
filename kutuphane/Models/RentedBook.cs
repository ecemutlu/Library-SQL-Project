using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutuphane.Models
{
    internal class RentedBook
    {
        public int Book_code { get; set; }

        public int Member_code { get; set; }

        public string RentDate { get; set; }

        public string? ReturnDate { get; set; }
        public int User_code { get; set; }
    }
}
