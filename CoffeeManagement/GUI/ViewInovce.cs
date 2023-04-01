using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement.GUI
{
    public partial class ViewInovce : Form
    {
        public ViewInovce()
        {
            InitializeComponent();
        }

        public void Print(string ID)
        {
            List<MatHangHoaDon> ListMH = CTHDDAO.Instance.GetCTHDViaIDHoaDon(ID);
            HoaDon HD = HoaDonDAO.Instance.GetData().Find(item => item.ID == ID);
            XtraReport1 a = new XtraReport1();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in a.Parameters) p.Visible = false;
            a.initdata(string.Format("{0:#,### đ}", HD.ThanhTien), string.Format("{0:#,### đ}", HD.GiamGia), HD.NgayThanhToan.ToString(), HD.ID);
            a.DataSource = ListMH;
            documentViewer1.DocumentSource = a;
        }
    }
}
