﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}
        public int Phone { get; set; }
        public string Status { get; set; }
        public int AgencyID { get; set; }


    }
}
