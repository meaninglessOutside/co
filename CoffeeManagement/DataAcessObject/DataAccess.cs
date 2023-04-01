
using System.Data;
using System.Data.SqlClient;


namespace CoffeeManagement
{
    public class DataAccess
    {
        protected string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //protected string connectionString = "Data Source=TuanLe;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        //protected string connectionString = @"Data Source=NGUYENXUANTU\GRYMP;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        public DataTable ExecuteQuery(string script)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(script, connection);
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
               
                connection.Close();
            }
            return data;

        }
        protected void ExecuteInsert(string script)
        {
            OperateNonQuery(script);
        }

        protected void ExecuteUpdate(string script)
        {
            OperateNonQuery(script);
        }

        protected void ExecuteRemove(string script)
        {
            OperateNonQuery(script);
        }

        private void OperateNonQuery(string script)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(script, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
