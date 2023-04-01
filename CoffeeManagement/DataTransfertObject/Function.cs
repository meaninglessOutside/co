using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public class Function
    {
        private static List<HoaDon> ListHD;
        private static Function instance;
        public static Function Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Function();
                    ListHD = HoaDonDAO.Instance.GetData();
                }
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void ExportHoaDonFile(string IDHD)
        {

            string storageFolder = Application.StartupPath + "\\Bills";
            string outputFileName = storageFolder + "\\" + IDHD + "-" + DateTime.Now.ToString("yyMMdd-hhmmsstt") + ".txt";
            if (!Directory.Exists(storageFolder))
            {
                Directory.CreateDirectory(storageFolder);
            }

            using (StreamWriter sw = File.CreateText(outputFileName))
            {
                //Write content for the file.
                HoaDon HD = ListHD.Find(item => item.ID == IDHD);
                if (HD != null)
                {
                    List<MatHangHoaDon> List = CTHDDAO.Instance.GetCTHDViaIDHoaDon(IDHD);
                    string separateLine = "===============================================================";
                    string title1 = "TEAM FORTY - SMART COFFEE MANAGEMENT";
                    string title2 = "HÓA ĐƠN THANH TOÁN";

                    sw.WriteLine(string.Format("{0, 50}", title1));
                    sw.WriteLine(separateLine);
                    sw.WriteLine(string.Format("{0, 40}", title2));
                    sw.WriteLine(separateLine);

                    sw.Write(string.Format("{0, -41}", "SỐ HÓA ĐƠN:"));
                    sw.WriteLine(string.Format("{0, -10}", HD.ID));

                    sw.Write(string.Format("{0, -41}", "NGÀY THANH TOÁN:"));
                    sw.WriteLine(string.Format("{0, -15}", HD.NgayThanhToan.ToString("dd/MM/yy")));
                    if (HD.IDThanhVien != null)
                    {
                        ThanhVien TV = ThanhVienDAO.Instance.GetDataViaId(HD.IDThanhVien);

                        sw.Write(string.Format("{0, -41}", "MÃ KHÁCH HÀNG:"));
                        sw.WriteLine(string.Format("{0, -10}", TV.ID));

                        sw.Write(string.Format("{0, -41}", "HỌ TÊN KHÁCH HÀNG:"));
                        sw.WriteLine(string.Format("{0, -30}", TV.HoTen));

                        sw.Write(string.Format("{0, -41}", "LOẠI KHÁCH HÀNG:"));
                        sw.WriteLine(string.Format("{0, -10}", TV.LoaiTV));
                    }

                    sw.WriteLine(separateLine);

                    foreach (var item in List)
                    {
                        sw.Write(String.Format("{0, -5}", List.IndexOf(item) + 1));
                        sw.Write(String.Format("{0, -8}", item.ID));
                        sw.Write(String.Format("{0, -28}", item.TenMatHang));
                        sw.Write(String.Format("{0, -9}", item.Gia));
                        sw.Write(String.Format("{0, -5}", item.SL));
                        sw.WriteLine(String.Format("{0, -7}", item.TongTien));
                    }
                    sw.WriteLine(separateLine);
                    sw.Write(string.Format("{0, -41}", "TỔNG TIỀN:"));
                    sw.WriteLine(string.Format("{0, -10}", HD.TongTien));

                    sw.Write(string.Format("{0, -41}", "GIẢM GIÁ:"));
                    sw.WriteLine(string.Format("{0, -10}", HD.GiamGia));

                    sw.Write(string.Format("{0, -41}", "THÀNH TIỀN:"));
                    sw.WriteLine(string.Format("{0, -10}", HD.ThanhTien));
                    sw.WriteLine(separateLine);

                    sw.Write(string.Format("{0, 40}", "XIN CẢM ƠN QUÝ KHÁCH!"));
                }

            }
        }

        private static readonly string[] VietnameseSigns = new string[]
        {
            "aAeEoOuUiIdDyY",

            "áàạảãâấầậẩẫăắằặẳẵ",

            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

            "éèẹẻẽêếềệểễ",

            "ÉÈẸẺẼÊẾỀỆỂỄ",

            "óòọỏõôốồộổỗơớờợởỡ",

            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

            "úùụủũưứừựửữ",

            "ÚÙỤỦŨƯỨỪỰỬỮ",

            "íìịỉĩ",

            "ÍÌỊỈĨ",

            "đ",

            "Đ",

            "ýỳỵỷỹ",

            "ÝỲỴỶỸ"
         };

        public string RemoveSign(string str)
        {
            //Bỏ dấu tiếng Việt
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }

    }
}
