using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace CoffeeManagement
{
    class BanGopChungDAO : DataAccess
    {
        private static BanGopChungDAO instance;
        public static BanGopChungDAO Instance
        {
            get
            {
                if (instance == null) instance = new BanGopChungDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region COMMAND
        private string INSERT_SCRIPT(string ID, string IDBanGop)
        {
            ID = "'" + ID + "'";
            IDBanGop = "'" + IDBanGop + "'";
            string script = "insert into BanGopChung values(" + ID + ", " + IDBanGop + ")";
            return script;
        }


        #endregion

        #region CRUD
        public void InsertData(string ID, List<string> ListIDBanGop)
        {
            foreach (string _id in ListIDBanGop)
            {
                ExecuteInsert(INSERT_SCRIPT(ID, _id));
                BanDAO.Instance.UpdateData(_id, 1);
            }
        }

        public bool CheckNDeleteData(string IDBan)
        {
            if (ExecuteCheckNDelete(IDBan) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int ExecuteCheckNDelete(string ID)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter pID = new SqlParameter("@IDBan", ID);
                SqlParameter pResult = new SqlParameter("@RESULT", SqlDbType.Int) { Direction = ParameterDirection.Output };

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteBanGop";
                command.Connection = connection;

                command.Parameters.Add(pID);
                command.Parameters.Add(pResult);

                command.ExecuteNonQuery();
                result = Convert.ToInt32(command.Parameters["@RESULT"].Value);

                connection.Close();
            }
            return result;
        }

        public void DeleteAllBanGop(string ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter pID = new SqlParameter("@IDBan", ID);

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteAllBanGop";
                command.Connection = connection;
                command.Parameters.Add(pID);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void DeleteAllBanGop_ThanhToan(string ID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter pID = new SqlParameter("@IDBan", ID);

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteAllBanGop_ThanhToan";
                command.Connection = connection;
                command.Parameters.Add(pID);

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public string GetBanDaiDien(string ID)
        {
            string result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter pID = new SqlParameter("@ID", ID);
                SqlParameter pResult = new SqlParameter("@RESULT", SqlDbType.VarChar, 5) { Direction = ParameterDirection.Output };

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetBanDaiDien";
                command.Connection = connection;

                command.Parameters.Add(pID);
                command.Parameters.Add(pResult);

                command.ExecuteNonQuery();
                result = command.Parameters["@RESULT"].Value.ToString();

                connection.Close();
            }
            return result;
        }

        public bool CheckExistence(string ID)
        {
            int result;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter pID = new SqlParameter("@ID", ID);
                SqlParameter pResult = new SqlParameter("@RESULT", SqlDbType.Int) { Direction = ParameterDirection.Output };

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "CheckExistenceBanGop";
                command.Connection = connection;

                command.Parameters.Add(pID);
                command.Parameters.Add(pResult);

                command.ExecuteNonQuery();
                result = Convert.ToInt32(command.Parameters["@RESULT"].Value);

                connection.Close();
            }
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        #endregion

    }
}
