using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DataAcessObject
{
    public class UserLoginDAO : DataAccess
    {
        private static UserLoginDAO instance;
        public static UserLoginDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserLoginDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public bool Login(string Username,string Password)
        { 
            string script = $"select * from UserLogin where UserName ='{Username}' AND Password ='{Password}' ";
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(script, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                if (reader.HasRows)
                {

                    result = true;
                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return result;
        }

        public bool ChangePassword(string Username, string Password,string NewPassword)
        {
            bool res = false;
            if (Login(Username, Password))
            {
                string sql = $"UPDATE UserLogin SET Password=N'{NewPassword}' where UserName ='{Username}' AND Password ='{Password}' ";
               
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();
                        res = true;
                    }
                    catch (Exception e)
                    {
                        res = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                } 
            }
            return res;
        }
    }
}

