﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RentalD
    {

        public int RentalID { get; set; }
        public int PropertyAgentD { get; set; }
        public int TenantID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
