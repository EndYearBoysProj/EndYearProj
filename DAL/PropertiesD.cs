using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PropertiesD
    {
         PropertiesD prop = new PropertiesD();

        public int PropertyID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string image { get; set; }
        public int PropertyTypeID { get; set; }
        public string Status { get; set; }
        public int SuburbID { get; set; }

        
        
    }
}
