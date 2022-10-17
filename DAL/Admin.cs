using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class Admin
    {
        public int AdminID { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public int Email { get; set; }
        public int Password { get; set; }
        public int Status { get; set; }
    }
}
