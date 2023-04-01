

namespace CoffeeManagement.DataAcessObject
{
    class ReportDAO : DataAccess
    {
        private static ReportDAO instance;
        public static ReportDAO Instance
        {
            get
            {
                if (instance == null) instance = new ReportDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private const string QUERY_SCRIPT = "select TenMatHang, DonViTinh, Gia, SL from HoaDon, ThongTinHoaDon, MatHang where HoaDon.ID = ThongTinHoaDon.IDHoaDon" +
            " and MatHang.ID = ThongTinHoaDon.IDMatHang";

    }
}
