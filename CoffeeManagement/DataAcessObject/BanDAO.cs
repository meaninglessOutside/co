
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public class BanDAO : DataAccess
    {
        private static BanDAO instance;
        public static BanDAO Instance
        {
            get
            {
                if (instance == null) instance = new BanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region COMMAND
        private const string QUERY_SCRIPT = "select * from Ban";
        private string UPDATE_SCRIPT(string id, string TinhTrang)
        {
            string updateScript = "update Ban" + "\n"
                                + "set TrangThai = " + TinhTrang + "\n"
                                + "where ID ='" + id + "'";
            return updateScript;
        }
        #endregion

        #region CRUD
        public List<Ban> GetData()
        {
            string script = QUERY_SCRIPT;
            List<Ban> List = new List<Ban>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(script, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Ban ban = new Ban(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2)
                            );
                        List.Add(ban);
                    }
                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return List;
        }

        public void UpdateData(string ID, int TinhTrang)
        {
            string script = UPDATE_SCRIPT(ID, TinhTrang.ToString());
            ExecuteUpdate(script);
        }

        public void InsertData()
        {
            string script = "insert into Ban default values";
            ExecuteInsert(script);
        }
        #endregion
    }
}
