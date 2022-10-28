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
        public DataTable AgentLogin(string email, string password)
        {
            return dal.AgentLogin(email, password);
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
        public int UpdateAgent(Agent age)
        {
            return dal.UpdateAgent(age);
        }
        public int InsertAgent(Agent age)
        {
            return dal.InsertAgent(age);
        }
        public int DeleteAgent(Agent age)
        {
            return dal.DeleteAgent(age);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public DataTable GetArea()
        {
            return dal.GetArea();
        }
        public int InsertProvince(ProvinceD prov)
        {
            return dal.InsertProvince(prov);
        }
        public DataTable GetProvince()
        {
            return dal.GetProvince();
        }
        public int InsertPropertyAgent(PropertyAgent proAge)
        {
            return dal.InsertPropertyAgent(proAge);
        }
        public int UpdatePropertyAgent(PropertyAgent proAge)
        {
            return dal.UpdatePropertyAgent(proAge);
        }
        public int DeletePropAgent(PropertyAgent proAge)
        {
            return dal.DeletePropAgent(proAge);
        }
        public DataTable GetPropAgent()
        {
            return dal.GetPropAgent();
        }
        public int InsertDetails(TenantD ten)
        {
            return dal.InsertDetails(ten);
        }
        public int UpdateTenant(TenantD ten)
        {
            return dal.UpdateTenant(ten);
        }
        public int DeleteTenant(TenantD ten)
        {
            return dal.DeleteTenant(ten);
        }
        public DataTable DisplayDetails()
        {
            return dal.DisplayDetails();
        }
        public int InsertRental(RentalD ren)
        {
            return dal.InsertRental(ren);
        }
        public int UpdateRental(RentalD ren)
        {
            return dal.UpdateRental(ren);
        }
        public DataTable DisplayRental()
        {
            return dal.DisplayRental();
        }
    }
}
