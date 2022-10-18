using System;
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
        public int InsertProperty(PropertiesD prop)
        {
            return dal.InsertProperty(prop);
        }
        public int UpdateProperty(PropertiesD p)
        {
            return dal.UpdateProperty(p);
        }
        public int DeleteProperty(PropertiesD d)
        {
            return dal.DeleteProperty(d);
        }
        public DataTable DisplayProperty()
        {
            return dal.DisplayProperty();
        }
        public int InsertCity(City city)
        {
            return dal.InsertCity(city);
        }
        public DataTable GetCity()
        {
            return dal.GetCity();
        }
        public int InsertSuburb(Suburb suburb)
        {
            return dal.InsertSuburb(suburb);
        }
        public DataTable GetSuburb()
        {
            return dal.GetSuburb();
        }
        public int InsertAgency(Agency agency)
        {
            return dal.InsertAgency(agency);
        }
        public DataTable GetAgency()
        {
            return dal.GetAgency();
        }
        public int DeleteAgency(Agency agency)
        {
            return dal.DeleteAgency(agency);
        }
        public int UpdateAgent(int AgentID, string Email, int Phone, string Status)
        {
            return dal.UpdateAgent(AgentID, Email, Phone, Status);
        }
        public int InsertAgent(Agent agent)
        {
            return dal.InsertAgent(agent);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public DataTable GetArea()
        {
            return dal.GetArea();
        }

    }
}
