using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DAL;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connstring = "Data Source=localhost; Initial Catalog= Project; Integrated Security=true";
        SqlConnection dbConn = new SqlConnection(connstring);
        SqlCommand dbComm;
        DataTable dt;
        SqlDataAdapter dbAdapter;

        public DataTable Login(string email, string password)
        {
            dbConn.Open();

            string sql = "sp_Login";
            dbComm= new SqlCommand(sql,dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertPropertyType(PropertyType type)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", type.PropertyTypeDescription);
         
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable DisplayPropertyType()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "SELECT* FROM tblPropertyType";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        } 
        public int InsertProperty(PropertiesD prop)
        {
            if(dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertProperties", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", prop.Description);
            dbComm.Parameters.AddWithValue("@Price", prop.Price);
            dbComm.Parameters.AddWithValue("@Image", prop.image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", prop.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", prop.Status);
            dbComm.Parameters.AddWithValue("@SuburbsID", prop.SuburbID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }

        public int UpdateProperty(PropertiesD p)
        {
           
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_UpdateProperties";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeID", p.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Price", p.Price.ToString());
            dbComm.Parameters.AddWithValue("@Status", p.Status);
            dbComm.Parameters.AddWithValue("@PropertyID", p.PropertyID);

            int x =dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteProperty(PropertiesD d)
        {
            
            if(dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_HardDeleteProperties";
            dbComm=new SqlCommand(sql, dbConn);
            dbComm.CommandType=CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", d.PropertyID);

            int x =dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable DisplayProperty()
        {
            if(dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_DisplayProperty";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;


        }
        public int InsertCity(City city)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.ProvinceID);

            int i = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return i;

        }

        public DataTable GetCity()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetCity", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;

        }
        public int InsertSuburb(Suburb suburb)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SuburbID", suburb.SuburbID);
            dbComm.Parameters.AddWithValue("@SuburbDescription", suburb.SuburbDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", suburb.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", suburb.CityID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetSuburb()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetSurburb", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertAgency(Agency agency)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);
            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.SuburbID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetAgency()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAgency", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int DeleteAgency(Agency agency)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);
            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.SuburbID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertAgent(Agent agent)
        {
            
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            dbComm.Parameters.AddWithValue("@Name", agent.Name);
            dbComm.Parameters.AddWithValue("@Surname", agent.Surname);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agent.AgencyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetAgent", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int UpdateAgent(int AgentID, string Email, int Phone, string Status)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", AgentID);
            dbComm.Parameters.AddWithValue("@Email", Email);
            dbComm.Parameters.AddWithValue("@Phone", Phone);
            dbComm.Parameters.AddWithValue("@Status", Status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetArea()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_GetArea", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }


    }
}
