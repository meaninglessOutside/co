
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CoffeeManagement
{
    public class CTHDDAO : DataAccess
    {
        private static CTHDDAO instance;
        public static CTHDDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTHDDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region CRUD
        public void InsertOrUpdateCTHD(string IDBan, string IDMatHang, int SL)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertThongTinHoaDon";
                command.Connection = connection;

                command.Parameters.Add(new SqlParameter("@IDBan", IDBan));
                command.Parameters.Add(new SqlParameter("@IDMatHang", IDMatHang));
                command.Parameters.Add(new SqlParameter("@SL", SL));

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public void DeleteCTHD(string IDBan, string IDMatHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DeleteThongTinHoaDon";
                command.Connection = connection;

                command.Parameters.Add(new SqlParameter("@IDBan", IDBan));
                command.Parameters.Add(new SqlParameter("@IDMatHang", IDMatHang));

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        public DataTable GetCTHDData(string IDBan)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                IDBan = "'" + IDBan + "'";

                command.CommandText = "EXEC GetThongTinHoaDonData @IDBan = " + IDBan;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        public List<MatHangHoaDon> GetCTHDViaIDHoaDon(string IDHoaDon)
        {
            List<MatHangHoaDon> List = new List<MatHangHoaDon>();
            IDHoaDon = "'" + IDHoaDon + "'";
            string script = "select ThongTinHoaDon.IDMatHang, MatHang.TenMatHang, MatHang.Gia, ThongTinHoaDon.SL, (ThongTinHoaDon.SL * MatHang.Gia) as TongTien "
                + "from ThongTinHoaDon join MatHang on MatHang.ID = ThongTinHoaDon.IDMatHang and ThongTinHoaDon.IDHoaDon = " + IDHoaDon;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(script, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MatHangHoaDon CTHD = new MatHangHoaDon();
                        CTHD.ID = reader.GetString(0);
                        CTHD.TenMatHang = reader.GetString(1);
                        CTHD.Gia = reader.GetInt32(2);
                        CTHD.SL = reader.GetInt32(3);
                        CTHD.TongTien = reader.GetInt32(4);
                        List.Add(CTHD);
                    }

                }

                connection.Close();
            }
            return List;
        }

        public bool CheckProductExistenceInCTHD(string IDMatHang)
        {
            IDMatHang = "'" + IDMatHang + "'";
            string script = "select * from ThongTinHoaDon where IDMatHang = " + IDMatHang;
            DataTable data = ExecuteQuery(script);
            if(data.Rows.Count == 0)
            {
                return false; //Chưa có trong thông tin hoá đơn
            }
            return true; //Ngược lại
        }
        #endregion



    }
}
