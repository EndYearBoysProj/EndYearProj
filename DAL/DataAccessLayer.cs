using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


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
            dbComm = new SqlCommand(sql, dbConn);
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
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertProperties", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", prop.Description);
            dbComm.Parameters.AddWithValue("@Price", prop.Price);
            dbComm.Parameters.AddWithValue("@Image", prop.Image);
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

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteProperty(PropertiesD d)
        {

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_HardDeleteProperties";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", d.PropertyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable DisplayProperty()
        {
            if (dbConn.State == ConnectionState.Closed)
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
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertCities", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.ProvinceID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }

        public DataTable GetCity()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetCities", dbConn);
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
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.SuburbID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public DataTable GetAgency()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetAgency", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int DeleteAgency(Agency agency)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertAgent(Agent age)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Name", age.Name);
            dbComm.Parameters.AddWithValue("@Surname", age.Surname);
            dbComm.Parameters.AddWithValue("@Email", age.Email);
            dbComm.Parameters.AddWithValue("@Password", age.Password);
            dbComm.Parameters.AddWithValue("@Status", age.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", age.AgencyID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetAgent()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetAgent", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int UpdateAgent(Agent age)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Email", age.Email);
            dbComm.Parameters.AddWithValue("@Phone", age.Phone);
            dbComm.Parameters.AddWithValue("@Status", age.Status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteAgent(Agent age)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_DeleteAgent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", age.AgentID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetArea()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_GetArea", dbConn);
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);
            return dt;
        }
        public int InsertProvince(ProvinceD prov)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", prov.Description);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetProvince()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "sp_GetProvince";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }
        public int InsertDetails(TenantD ten)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_insertTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@Name", ten.Name);
            dbComm.Parameters.AddWithValue("@Surname", ten.Surname);
            dbComm.Parameters.AddWithValue("@Email", ten.Email);
            dbComm.Parameters.AddWithValue("@Password", ten.Password);
            dbComm.Parameters.AddWithValue("@Phone", ten.Phone);
            dbComm.Parameters.AddWithValue("@Status", ten.Status);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdateTenant(TenantD ten)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_UpdateTenant";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", ten.TenantID);
            dbComm.Parameters.AddWithValue("@Email", ten.Email);
            dbComm.Parameters.AddWithValue("@Phone", ten.Phone);
            dbComm.Parameters.AddWithValue("@Status", ten.Status);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteTenant(TenantD ten)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_DeleteTenant";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", ten.TenantID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable DisplayDetails()
        {
            if (dbConn.State == ConnectionState.Open)
            {
                dbConn.Open();
            }
            string sql = "SELECT* FROM tblTenant";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int InsertRental(RentalD ren)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@PropertAgentD", ren.PropertyAgentD);
            dbComm.Parameters.AddWithValue("@TenantID", ren.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", ren.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", ren.EndDate);



            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable DisplayRental()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            string sql = "SELECT* FROM tblRental";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int UpdateRental(RentalD ren)
        {

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_UpdateRental";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@StartDate", ren.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", ren.EndDate);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertPropertyAgent(PropertyAgent proAge)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@PropertyID", proAge.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", proAge.AgentID);
            dbComm.Parameters.AddWithValue("@Date", proAge.Date);
           



            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int UpdatePropertyAgent(PropertyAgent proAge)
        {

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_UpdatePropAgent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", proAge.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", proAge.AgentID);
            dbComm.Parameters.AddWithValue("@Date", proAge.Date);
           

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeletePropAgent(PropertyAgent proAge)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            string sql = "sp_DeletePropAgent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", proAge.PropertyAgentID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetPropAgent()
        {
            if (dbConn.State == ConnectionState.Open)
            {
                dbConn.Open();
            }
            string sql = "SELECT* FROM tblPropertyAgent";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
    } 
   

}
