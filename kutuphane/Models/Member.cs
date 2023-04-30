using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kutuphane.Models
{
    internal class Member
    {
        public int code { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber{ get; set; }
        public string email { get; set; }
        public string address { get; set; }
    }
}
