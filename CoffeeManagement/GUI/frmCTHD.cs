using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class frmCTHD : Form
    {
        private HoaDon HoaDon;

        public frmCTHD(HoaDon HoaDon)
        {
            InitializeComponent();
            this.HoaDon = HoaDon;
            StyleComponents();
            LoadData();
        }

        private void LoadData()
        {
            dtgCTHD.DataSource = CTHDDAO.Instance.GetCTHDViaIDHoaDon(HoaDon.ID);

            lbSHDv.Text = HoaDon.ID;
            lbNGTTv.Text = HoaDon.NgayThanhToan.ToString("dd/MM/yyyy");
            if (HoaDon.IDThanhVien != null)
            {
                ThanhVien TV = ThanhVienDAO.Instance.GetDataViaId(HoaDon.IDThanhVien);
                lbIDKHv.Text = TV.ID;
                lbHoTenv.Text = TV.HoTen;
                lbLoaiKHv.Text = TV.LoaiTV;
            }
            else
            {
                lbIDKHv.Text = "Không có";
                lbHoTenv.Text = "Không có";
                lbLoaiKHv.Text = "Không có";
            }
            lbTTv.Text = HoaDon.TongTien.ToString();
            lbGGv.Text = HoaDon.GiamGia.ToString();
            lbTHTv.Text = HoaDon.ThanhTien.ToString();
        }

        private void StyleComponents()
        {
            dtgCTHD.BorderStyle = BorderStyle.None;
            dtgCTHD.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgCTHD.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgCTHD.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgCTHD.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgCTHD.BackgroundColor = Color.FromArgb(223, 223, 255);

            dtgCTHD.EnableHeadersVisualStyles = false;
            dtgCTHD.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgCTHD.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgCTHD.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            Function.Instance.ExportHoaDonFile(HoaDon.ID);
            (new frmDialog("Xuất hóa đơn thành công", Message.SUCCESS)).Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
