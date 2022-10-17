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

        } public int InsertProperty(Properties prop)
        {
            if(dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }
            dbComm = new SqlCommand("sp_InsertProperties", dbConn);
            dbComm.CommandType= CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description",)
        }


    }
}
