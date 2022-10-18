using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL

{
    public class Agency
    {
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int SuburbID { get; set; }

        public Agency(int agencyID, string agencyName, int suburbID)
        {
            this.AgencyID = agencyID;
            this.AgencyName = agencyName;
            this.SuburbID = suburbID;
        }
        public Agency()
        {

        }
    }
}
