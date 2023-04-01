
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CoffeeManagement
{
    public class MatHangDAO : DataAccess
    {
        private static MatHangDAO instance;
        public static MatHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new MatHangDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region COMMAND
        private string QUERY_SCRIPT = "select ID, TenMatHang, DonViTinh, Gia from MatHang";
        #endregion

        #region CRUD

        public List<MatHang> GetData()
        {
            string script = QUERY_SCRIPT;
            List<MatHang> List = new List<MatHang>();

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
                        MatHang mh = new MatHang(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetInt32(3)
                            );
                        List.Add(mh);
                    }
                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return List;
        }


        //Kho
        private string Insert_MH(MatHangChiTiet mh)
        {
            string scriptTV = "INSERT INTO MatHang(TenMatHang,LoaiMatHang,DonViTinh,Gia) VALUES ("
                               + "N'" + mh.TenMatHang.ToString() + "',"
                               + "N'" + mh.LoaiMatHang.ToString() + "',"
                               + "N'" + mh.DonViTinh.ToString() + "',"
                               + "" + mh.Gia.ToString() + ")";
            return scriptTV;

        }

        private string Update_MH(MatHangChiTiet mh, string id_update)
        {
            string sql = "UPDATE MatHang SET TenMatHang=N'" + mh.TenMatHang + "', LoaiMatHang=N'" + mh.LoaiMatHang + "', DonViTinh=N'" + mh.DonViTinh + "', Gia='" + mh.Gia + "'";
            sql += "WHERE ID='" + id_update + "'";
            sql += "SELECT * FROM MatHang";
            return sql;
        }

        private string Delete_MH(string id)
        {
            string sql = "DELETE FROM MatHang WHERE ID = '" + id + "' SELECT * FROM MatHang";
            return sql;
        }

        public void InsertData(MatHangChiTiet mh)
        {
            ExecuteInsert(Insert_MH(mh));
        }
        public List<MatHangChiTiet> GetDataMHChiTiet()
        {
            string script = "select * from MatHang";
            List<MatHangChiTiet> List = new List<MatHangChiTiet>();

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
                        MatHangChiTiet mh = new MatHangChiTiet();
                        mh.ID = reader.GetString(0);
                        mh.TenMatHang = reader.GetString(1);
                        mh.LoaiMatHang = reader.GetString(2);
                        mh.DonViTinh = reader.GetString(3);
                        mh.Gia = reader.GetInt32(4);
                        List.Add(mh);
                    }
                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return List;
        }
        public DataTable TiemKiemMH(string a)
        {
            DataTable data = new DataTable();
            string script = "SELECT * FROM MatHang WHERE TenMatHang LIKE '" + a + "%'";
            data = ExecuteQuery(script);
            return data;
        }
        public DataTable TiemKiemTheoDoUong()
        {
            DataTable data = new DataTable();
            string script = "SELECT * FROM MatHang WHERE LoaiMatHang = N'Đồ uống'";
            data = ExecuteQuery(script);
            return data;
        }
        public DataTable TiemKiemTheoDoAn()
        {
            DataTable data = new DataTable();
            string script = "SELECT * FROM MatHang WHERE LoaiMatHang = N'Đồ ăn'";
            data = ExecuteQuery(script);
            return data;
        }
        public DataTable SearchALL()
        {
            DataTable data = new DataTable();
            string script = "SELECT * FROM MatHang ";
            data = ExecuteQuery(script);
            return data;
        }
        public void UpdateData(string id_MH, MatHangChiTiet mh)
        {
            ExecuteUpdate(Update_MH(mh, id_MH));
        }

        public void DeleteData(string idMH)
        {
            ExecuteRemove(Delete_MH(idMH));
        }
        #endregion



    }
}
