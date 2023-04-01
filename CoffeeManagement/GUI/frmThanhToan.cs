using CoffeeManagement.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace CoffeeManagement
{
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        private string ID_Ban;
        private string IDThanhVien;
        private int LoaiThanhVien;
        private HoaDon HoaDon;

        public frmThanhToan(string ID_Ban)
        {
            InitializeComponent();

            DialogResult = DialogResult.No;

            this.ID_Ban = ID_Ban;
            HoaDon = HoaDonDAO.Instance.GetDataViaId(ID_Ban);
            StylingFormComponents();

            txtTongTien.Text = String.Format("{0:#,##0} VND", HoaDon.TongTien);
            txtGiamGia.Text = String.Format("{0:#,##0} VND", HoaDon.GiamGia);
            txtThanhTien.Text = String.Format("{0:#,##0} VND", HoaDon.ThanhTien);

            LoadCTHD(ID_Ban);
            txtSDT.Select();
        }


        private void StylingFormComponents()
        {
            dtgThanhToan.BorderStyle = BorderStyle.None;
            dtgThanhToan.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgThanhToan.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgThanhToan.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgThanhToan.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgThanhToan.BackgroundColor = Color.FromArgb(223, 223, 255);

            dtgThanhToan.EnableHeadersVisualStyles = false;
            dtgThanhToan.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgThanhToan.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgThanhToan.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        #region EVENT HANDLERS
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Xác nhận thanh toán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                //Cập nhật dữ liệu vào hoá đơn, bàn
                ConfirmThanhToan();

                // Thoát khỏi form Thanh toán
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            string SDT = txtSDT.Text;
            int LoaiThanhVien = -1;
            string IDThanhVien = null;

            ThanhVienDAO.Instance.GetLoaiThanhVien(SDT, out LoaiThanhVien, out IDThanhVien);
            //MessageBox.Show(LoaiThanhVien.ToString() + ", " + IDThanhVien);

            this.LoaiThanhVien = LoaiThanhVien;
            this.IDThanhVien = IDThanhVien;

            if (LoaiThanhVien == -1)
            {
                txtLoaiThanhVien.Text = "Không tồn tại";
                txtLoaiThanhVien.ForeColor = Color.Red;
            }
            else if (LoaiThanhVien == 0)
            {
                txtLoaiThanhVien.Text = "TV Thường";
                txtLoaiThanhVien.ForeColor = Color.Black;
            }
            else if (LoaiThanhVien == 1)
            {
                txtLoaiThanhVien.Text = "TV Bạc";
                txtLoaiThanhVien.ForeColor = Color.Silver;
            }
            else if (LoaiThanhVien == 2)
            {
                txtLoaiThanhVien.Text = "TV Vàng";
                txtLoaiThanhVien.ForeColor = Color.Gold;
            }
            HoaDon.GiamGia = HoaDon.TongTien * GetGiamGiaRate();
            HoaDon.ThanhTien = HoaDon.TongTien - HoaDon.GiamGia;

            txtGiamGia.Text = String.Format("{0:#,##0} VND", HoaDon.GiamGia);
            txtThanhTien.Text = String.Format("{0:#,##0} VND", HoaDon.ThanhTien);
        }
        #endregion

        #region ULTILITIES
        private void LoadCTHD(string ID_Ban)
        {
            dtgThanhToan.DataSource = CTHDDAO.Instance.GetCTHDData(ID_Ban);
        }

        private float GetGiamGiaRate()
        {
            if (LoaiThanhVien == 0)
            {
                return 0.1f;
            }
            else if (LoaiThanhVien == 1)
            {
                return 0.2f;
            }
            else if (LoaiThanhVien == 2)
            {
                return 0.3f;
            }
            else
            {
                return 0.0f;
            }
        }


        private void ConfirmThanhToan()
        {
            HoaDon.NgayThanhToan = DateTime.Now;
            HoaDon.IDThanhVien = IDThanhVien;
            HoaDon.TrangThai = 1;

            BanGopChungDAO.Instance.DeleteAllBanGop_ThanhToan(ID_Ban);
            HoaDonDAO.Instance.UpdateData(ID_Ban, HoaDon); // Cập nhật thông tin hoá đơn.
            BanDAO.Instance.UpdateData(ID_Ban, 0); //Cập nhật tình trạng của bàn thành bàn trống. 
            //Xuất hoá đơn
            Function.Instance.ExportHoaDonFile(HoaDon.ID);
           
            ViewInovce a = new ViewInovce();
            a.Print(HoaDon.ID);
            a.ShowDialog();
        }
        #endregion

    }
}