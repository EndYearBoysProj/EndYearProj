using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Suburb
    {
        public int SuburbID { get; set; }
        public string SuburbDescription { get; set; }
        public int PostalCode { get; set; }
        public int CityID { get; set; }

        public Suburb(int suburbID, string suburbDesc, int postalCode, int cityID)
        {
            this.SuburbID = suburbID;
            this.SuburbDescription = suburbDesc;
            this.PostalCode = postalCode;
            this.CityID = cityID;
        }
        public Suburb()
        {

        }
    }
}
