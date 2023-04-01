using System;
using System.Data;
using System.Data.SqlClient;


namespace CoffeeManagement
{
    public class ThanhVienDAO : DataAccess
    {
        private static ThanhVienDAO instance;
        public static ThanhVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new ThanhVienDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private string Insert_TV(ThanhVien tv)
        {
            string scriptTV = "set dateformat dmy INSERT INTO ThanhVien(HoTen,SDT,NgayDK,LoaiThanhVien,TienTichLuy) VALUES ("
                               + "N'" + tv.HoTen.ToString() + "',"
                               + "N'" + tv.SDT.ToString() + "',"
                               + "N'" + tv.NgDK.ToString("dd/MM/yyyy") + "',"
                               + "N'" + tv.LoaiTV.ToString() + "',"
                               + "N'" + tv.TienTichLuy.ToString() + "')";
            return scriptTV;
            
        }
        private string Update_TV(ThanhVien tv, string id_update)
        {
            string sql = "set dateformat dmy UPDATE ThanhVien SET ID='" + tv.ID + "',HoTen=N'" + tv.HoTen + "', SDT='" + tv.SDT + "', NgayDK='" + tv.NgDK.ToString("dd/MM/yyyy") + "', LoaiThanhVien=N'" + tv.LoaiTV
                + "', TienTichLuy='" + tv.TienTichLuy + "'";
            sql += "WHERE ID='" + id_update + "'";
            sql += "SELECT * FROM ThanhVien";
            return sql;
        }
        private string Delete_TV(string id)
        {
            string sql = "DELETE FROM ThanhVien WHERE ID = '" + id + "' SELECT * FROM ThanhVien";
            return sql;
        }
        public void GetLoaiThanhVien(string SDT, out int Type, out string ID)
        {
            int result1 = -1;
            string result2 = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter pSDT = new SqlParameter("@SDT", SDT);
                SqlParameter pType = new SqlParameter("@Type", SqlDbType.Int) { Direction = ParameterDirection.Output };
                SqlParameter pID = new SqlParameter("@ID", SqlDbType.VarChar, 5) { Direction = ParameterDirection.Output };

                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetLoaiThanhVien";
                command.Connection = connection;

                command.Parameters.Add(pSDT);
                command.Parameters.Add(pType);
                command.Parameters.Add(pID);

                command.ExecuteNonQuery();
                //MessageBox.Show(command.Parameters["@Type"].Value.ToString() + ", " + command.Parameters["@ID"].Value.ToString());
                result1 = Convert.ToInt32(command.Parameters["@Type"].Value);
                result2 = command.Parameters["@ID"].Value.ToString();
                if (command.Parameters["@ID"].Value == DBNull.Value)
                {
                    result2 = null;
                }
                else
                {
                    result2 = command.Parameters["@ID"].Value.ToString();
                }

                connection.Close();
            }
            Type = result1;
            ID = result2;
            //MessageBox.Show(Type + ", " + ID);
        }

        public ThanhVien GetDataViaId(string IDTV)
        {
            IDTV = "'" + IDTV + "'";
            string script = "select * from ThanhVien where ID = " + IDTV;
            ThanhVien TV = new ThanhVien();

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
                        TV.ID = reader.GetString(0);
                        TV.HoTen = reader.GetString(1);
                        TV.SDT = reader.GetString(2);
                        TV.NgDK = reader.GetDateTime(3);
                        TV.LoaiTV = reader.GetString(4);
                        TV.TienTichLuy = (int)reader.GetDouble(5);
                    }

                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return TV;
        }

        public void InsertData(ThanhVien tv)
        {
            ExecuteInsert(Insert_TV(tv));
        }
        public void UpdateData(string id_TV, ThanhVien tv)
        {
            ExecuteUpdate(Update_TV(tv,id_TV));
        }

        public void DeleteData(string idTV)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteThanhVien";
                command.Connection = connection;

                command.Parameters.Add(new SqlParameter("@ID", idTV));

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        public DataTable LoadDataDSTV()
        {
            DataTable data = new DataTable();
            string script = "SELECT * FROM ThanhVien";
            data = ExecuteQuery(script);
            return data;
        }
        public DataTable TiemKiemTV(string a)
        {
            DataTable data = new DataTable();
            string script = "SELECT * FROM ThanhVien WHERE SDT LIKE '" + a + "%'";
            data = ExecuteQuery(script);
            return data;
        }
    }
}
