﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BussinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public DataTable Login(string email,string password)
        {
            return dal.Login(email, password);
        }
        public int InsertPropertyType(PropertyType type)
        {
            return dal.InsertPropertyType(type);
        }
        public DataTable DisplayPropertyType()
        {
            return dal.DisplayPropertyType();
        }
        public int InsertProperty(Properties prop)
        {
            return dal.InsertProperty(prop);
        }
        public int UpdateProperty(Properties prop)
        {
            return dal.UpdateProperty(prop);
        }
        public int DeleteProperty(Properties prop)
        {
            return dal.DeleteProperty(prop);
        }
        public DataTable DisplayProperty()
        {
            return dal.DisplayProperty();
        }
    }
}
