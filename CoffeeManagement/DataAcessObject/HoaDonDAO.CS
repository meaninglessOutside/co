
using System.Collections.Generic;
using System.Data.SqlClient;


namespace CoffeeManagement
{
    public class HoaDonDAO : DataAccess
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        #region COMMAND
        private string INSERT_SCRIPT(HoaDon HD)
        {
            string INSERT_SCRIPT = "insert into HoaDon(IDBan)"
                                    + "values('" + HD.IDBan + "')";
            return INSERT_SCRIPT;
        }
        private string DELETE_SCRIPT(string IDBan)
        {
            IDBan = "'" + IDBan + "'";
            string script = "EXEC Delete_HoaDon_CTHD @IDBan = " + IDBan;
            return script;
        }
        private string QUERY_SCRIPT(string IDBan)
        {
            IDBan = "'" + IDBan + "'";
            string script = "select * from HoaDon where TrangThai = 0 and IDBan = " + IDBan;
            return script;
        }
        private string UPDATE_SCRIPT(string IDBan, HoaDon HD)
        {
            IDBan = "'" + IDBan + "'";
            string script = "set dateformat dmy update HoaDon \n";
            script += "set NgayThanhToan=" + "'" + HD.NgayThanhToan.ToString("dd/MM/yyyy") + "',";
            script += "GiamGia =" + "'" + HD.GiamGia + "',";
            if (HD.IDThanhVien == null)
            {
                script += "IDThanhVien = NULL,";
            }
            else
            {
                script += "IDThanhVien =" + "'" + HD.IDThanhVien + "',";
            }
            script += "IDBan =" + "'" + HD.IDBan + "',";
            script += "TrangThai =" + "'" + HD.TrangThai + "'\n";
            script += "where IDBan = " + IDBan + "and TrangThai = 0";

            return script;
        }
        #endregion

        #region CRUD

        //Method for manipulate database
        public HoaDon GetDataViaId(string IDBan)
        {
            string script = QUERY_SCRIPT(IDBan);
            HoaDon HoaDon = new HoaDon();

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
                        HoaDon.ID = reader.GetString(0);
                        HoaDon.NgayThanhToan = reader.GetDateTime(1);
                        HoaDon.GiamGia = (float)reader.GetDouble(2);
                        HoaDon.IDBan = reader.GetString(3);
                        if (!reader.IsDBNull(4))
                        {
                            HoaDon.IDThanhVien = reader.GetString(4);
                        }
                        else
                        {
                            HoaDon.IDThanhVien = null;
                        }
                        HoaDon.TrangThai = reader.GetInt32(5);
                        HoaDon.TongTien = (float)reader.GetDouble(6);
                        HoaDon.ThanhTien = (float)reader.GetDouble(7);
                    }

                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return HoaDon;
        }

        public List<HoaDon> GetData()
        {
            string script = "SELECT HOADON.ID, NgayThanhToan, GiamGia, IDBan, IDThanhVien, HoTen, TrangThai, TongTien, ThanhTien FROM HOADON LEFT JOIN THANHVIEN ON IDTHANHVIEN = THANHVIEN.ID";
            List<HoaDon> List = new List<HoaDon>();

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
                        HoaDon HoaDon = new HoaDon();
                        HoaDon.ID = reader.GetString(0);
                        HoaDon.NgayThanhToan = reader.GetDateTime(1);
                        HoaDon.GiamGia = (float)reader.GetDouble(2);
                        HoaDon.IDBan = reader.GetString(3);
                        if (!reader.IsDBNull(4))
                        {
                            HoaDon.IDThanhVien = reader.GetString(4);
                        }
                        else
                        {
                            HoaDon.IDThanhVien = null;
                        }
                        if (HoaDon.IDThanhVien != null)
                        {
                            HoaDon.HoTen = reader.GetString(5);
                        }
                        else
                        {
                            HoaDon.HoTen = null;
                        }
                        HoaDon.TrangThai = reader.GetInt32(6);
                        HoaDon.TongTien = (float)reader.GetDouble(7);
                        HoaDon.ThanhTien = (float)reader.GetDouble(8);
                        List.Add(HoaDon);
                    }

                }
                // Call Close when done reading.
                reader.Close();
                connection.Close();
            }
            return List;

        }
        public void InsertData(HoaDon HD)
        {
            ExecuteInsert(INSERT_SCRIPT(HD));
        }
        public void UpdateData(string IDBAN, HoaDon HD)
        {
            string script = UPDATE_SCRIPT(IDBAN, HD);
            ExecuteUpdate(script);
        }
        public void DeleteData(string IDBan)
        {
            string script = DELETE_SCRIPT(IDBan);
            ExecuteRemove(script);
        }
        #endregion


    }
}
