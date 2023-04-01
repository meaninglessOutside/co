using CoffeeManagement.DataAcessObject;
using System;
using System.Data;


namespace CoffeeManagement.DataTransfertObject
{
    class Report
    {
        public Report(DateTime dateTime)
        {
            dateReport = dateTime;
            dataReport = ReportDAO.Instance.ExecuteQuery("set dateformat dmy select TenMatHang, DonViTinh, Gia, SUM(SL) as SL from HoaDon, ThongTinHoaDon, MatHang where HoaDon.ID = ThongTinHoaDon.IDHoaDon" +
            " and MatHang.ID = ThongTinHoaDon.IDMatHang and NgayThanhToan >= '" + dateReport.Date.ToString("dd/MM/yy") + "' group by TenMatHang, DonViTinh, Gia");
            dataReport.Columns.Add("DoanhThu");
        }
        public DataTable dataReport { get; set; }
        public DateTime dateReport { get; set; }
        public DataTable createChart(string follow)
        {
            DataTable dt = new DataTable();
            if (follow == "day")
            {
                dt = ReportDAO.Instance.ExecuteQuery("set dateformat dmy select NgayThanhToan, SUM(ThanhTien) as DoanhThu from HoaDon " +
                    "where NgayThanhToan >= '" + dateReport.Date.ToString("dd/MM/yy") + "' group by NgayThanhToan");
            }
            else if (follow == "week")
            {
                dt = ReportDAO.Instance.ExecuteQuery("set dateformat dmy select NgayThanhToan, SUM(ThanhTien) as DoanhThu from HoaDon " +
                    "where NgayThanhToan >= '" + dateReport.Date.ToString("dd/MM/yy") + "' group by NgayThanhToan");
                if (dt.Rows.Count > 0)
                {
                    long money = int.Parse(dt.Rows[0][1].ToString());
                    for (int i = 1; i < dt.Rows.Count; i++)
                    {
                        DateTime day = (DateTime)dt.Rows[i][0];
                        if (day.DayOfWeek == DayOfWeek.Monday)
                        {
                            money = int.Parse(dt.Rows[i][1].ToString());
                            dt.Rows[i][1] = money;
                        }
                        else
                        {
                            money += int.Parse(dt.Rows[i][1].ToString());
                            dt.Rows[i - 1][1] = money;
                            dt.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            else if (follow == "month")
            {
                dt = ReportDAO.Instance.ExecuteQuery("set dateformat dmy select CONVERT(varchar(7), NgayThanhToan, 120) as NgayThanhToan, SUM(ThanhTien) as DoanhThu from HoaDon " +
                    "where NgayThanhToan >= '" + dateReport.Date.ToString("dd/MM/yy")+ "' group by CONVERT(varchar(7), NgayThanhToan, 120)");
            }
            return dt;
        }
    }
}
