using DevExpress.Utils.CommonDialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace CoffeeManagement
{
    public partial class frmLichSuGiaoDich : DevExpress.XtraEditors.XtraForm
    {

        #region KHỞI TẠO MỘT CÁC THÀNH PHẦN
        private List<HoaDon> ListHD;
        private List<HoaDon> ListBuffer;
        private Timer timer;
        public frmLichSuGiaoDich()
        {
            InitializeComponent();
            ListHD = HoaDonDAO.Instance.GetData();
            ListBuffer = ListHD;
            LoadHDNgay();
            LoadSugestItemDate();
            ChangeViewMode(1);
            SetupTimer();
            StylingFormComponents();
        }

        private void StylingFormComponents()
        {

            dtgHoaDon.BorderStyle = BorderStyle.None;
            dtgHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dtgHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtgHoaDon.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dtgHoaDon.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dtgHoaDon.BackgroundColor = Color.FromArgb(223, 223, 255);

            dtgHoaDon.EnableHeadersVisualStyles = false;
            dtgHoaDon.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtgHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dtgHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            lbKhongCoGDNao.Text = "Không có giao dịch nào!";
            lbKhongCoGDNao.Location = new Point(this.Width / 2 - lbKhongCoGDNao.Width / 2, this.Height / 2 - lbKhongCoGDNao.Height / 2);
            lbKhongCoGDNao.Visible = false;
        }

        private void SetupTimer()
        {
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (dtgHoaDon.Rows.Count == 0)
            {
                lbKhongCoGDNao.Visible = true;
            }
            else
            {
                lbKhongCoGDNao.Visible = false;
            }
        }
        #endregion


        #region EVENT HANDLER
        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDNgay();
        }

        private void dtpTuan_ValueChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDTuan();
        }

        private void cbThang_TextChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDThang();
        }

        private void cbNam1_TextChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDThang();
        }

        private void cbNam2_TextChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDNam();
        }


        private void cbNgayGD_CheckedChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDNangCao();
        }

        private void cbTT_CheckedChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDNangCao();
        }

        private void dtpDateFrom_ValueChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDNangCao();
        }

        private void dtpDateTo_ValueChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            LoadHDNangCao();
        }

        private void tbTTFrom_TextChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            if (tbTTFrom.Text.Length == 0)
            {
                tbTTFrom.Text = "0";
                tbTTFrom.Focus();
                tbTTFrom.SelectionStart = 0;
                tbTTFrom.SelectionLength = 1;
            }
            LoadHDNangCao();
        }

        private void tbTTTo_TextChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            if (tbTTTo.Text.Length == 0)
            {
                tbTTTo.Text = "0";
                tbTTTo.Focus();
                tbTTTo.SelectionStart = 0;
                tbTTTo.SelectionLength = 1;
            }
            LoadHDNangCao();
        }

        private void tbHoTen_TextChanged(object sender, EventArgs e)
        {
            string keyword;
            if (tbHoTen.Text.Length == 0)
            {
                keyword = "";
            }
            else
            {
                keyword = tbHoTen.Text;
            }

            List<HoaDon> List = new List<HoaDon>();
            foreach (HoaDon HD in ListBuffer)
            {
                if (HD.HoTen == null)
                {
                    string temp = keyword.Replace(" ", String.Empty);
                    if (temp.Length == 0)
                    {
                        List.Add(HD);
                    }
                }
                else
                {
                    if (HD.HoTen.ToLower().Contains(keyword))
                    {
                        List.Add(HD);
                    }

                }
            }
            dtgHoaDon.DataSource = List;
        }

        private void tbHoTen_Enter(object sender, EventArgs e)
        {
            string keyword;
            if (tbHoTen.Text.Length == 0)
            {
                keyword = "";
            }
            else
            {
                keyword = tbHoTen.Text.ToLower();
            }

            List<HoaDon> List = new List<HoaDon>();
            foreach (HoaDon HD in ListBuffer)
            {
                if (HD.HoTen == null)
                {
                    string temp = keyword.Replace(" ", String.Empty);
                    if (temp.Length == 0)
                    {
                        List.Add(HD);
                    }
                }
                else
                {
                    if (HD.HoTen.ToLower().Contains(keyword))
                    {
                        List.Add(HD);
                    }

                }
            }
            dtgHoaDon.DataSource = List;
        }

        private void cbViewMode_TextChanged(object sender, EventArgs e)
        {
            tbHoTen.Clear();
            string selection = cbViewMode.Text;
            switch (selection)
            {
                case "Ngày":
                    ChangeViewMode(1);
                    LoadHDNgay();
                    break;
                case "Tuần":
                    ChangeViewMode(2);
                    LoadHDTuan();
                    break;
                case "Tháng":
                    ChangeViewMode(3);
                    LoadHDThang();
                    break;
                case "Năm":
                    ChangeViewMode(4);
                    LoadHDNam();
                    break;
                case "Nâng cao":
                    ChangeViewMode(5);
                    break;
                case "Tất cả":
                    LoadDanhSachHoaDon();
                    ChangeViewMode(6);
                    break;
            }
        }

        private void dtgHoaDon_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right && dtgHoaDon.SelectedRows.Count != 0)
            {
                var hti = dtgHoaDon.HitTest(e.X, e.Y);
                dtgHoaDon.ClearSelection();
                dtgHoaDon.Rows[hti.RowIndex].Selected = true;

                contextMenuHoaDon.Show(dtgHoaDon, new Point(e.X, e.Y));
            }
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgHoaDon.SelectedRows.Count != 0)
            {
                string ID = dtgHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                HoaDon HD = ListHD.Find(item => item.ID == ID);
                frmCTHD frmCTHD = new frmCTHD(HD);
                frmCTHD.ShowDialog();
            }
            else
            {
                (new frmDialog("Không thể xem thông tin hoá đơn", Message.ERROR)).Show();
            }

        }

        private void xuấtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgHoaDon.SelectedRows.Count != 0)
            {
                string ID = dtgHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                Function.Instance.ExportHoaDonFile(ID);
                (new frmDialog("Xuất hóa đơn thành công", Message.SUCCESS)).Show();
            }
            else
            {
                (new frmDialog("Không thể xuất hoá đơn", Message.ERROR)).Show();
            }

        }

        #endregion


        #region LOAD_DANH_SÁCH_HOÁ_ĐƠN
        // Load danh sách hoá đơn theo điều kiện cụ thể
        private void LoadDanhSachHoaDon()
        {
            ListBuffer = ListHD;
            dtgHoaDon.DataSource = ListBuffer;
        }

        private void LoadSugestItemDate()
        {
            if(ListHD.Count != 0)
            {
                DateTime min = ListHD[0].NgayThanhToan;
                DateTime max = ListHD[0].NgayThanhToan;
                foreach (HoaDon HD in ListHD)
                {
                    if (HD.NgayThanhToan.CompareTo(min) == -1)
                    {
                        min = HD.NgayThanhToan;
                    }
                    else if (HD.NgayThanhToan.CompareTo(max) == 11)
                    {
                        max = HD.NgayThanhToan;
                    }
                }
                for (int i = max.Year; i <= DateTime.Now.Year; i++)
                {
                    cbNam1.Items.Clear();
                    cbNam1.Items.Add(i);

                    cbNam2.Items.Clear();
                    cbNam2.Items.Add(i);
                }
            }

        }

        private void LoadHDNgay()
        {
            DateTime date = dtpNgay.Value;
            ListBuffer = GetListHDNgay(date);
            dtgHoaDon.DataSource = ListBuffer;
        }

        private void LoadHDTuan()
        {
            DateTime date = dtpTuan.Value;
            ListBuffer = GetListHDTuan(date);
            dtgHoaDon.DataSource = ListBuffer;
        }

        private void LoadHDThang()
        {
            int month;
            int year;
            if (Int32.TryParse(cbThang.Text, out month))
            {
                if (Int32.TryParse(cbNam1.Text, out year))
                {
                    List<HoaDon> List = GetListHDThang(month, year);
                    if (List != null)
                    {
                        ListBuffer = List;
                        dtgHoaDon.DataSource = ListBuffer;
                    }
                }
                else
                {
                    (new frmDialog("Vui lòng chọn năm hợp lệ", Message.ERROR)).Show();
                    cbNam1.Focus();
                }

            }
            else
            {
                (new frmDialog("Vui lòng chọn tháng hợp lệ", Message.ERROR)).Show();
                cbThang.Focus();
            }


        }

        private void LoadHDNam()
        {
            int year;
            if (Int32.TryParse(cbNam2.Text, out year))
            {
                ListBuffer = GetListHDNam(year);
                dtgHoaDon.DataSource = ListBuffer;
            }
            else
            {
                (new frmDialog("Vui lòng chọn năm hợp lệ", Message.ERROR)).Show();
            }
        }

        private void LoadHDNangCao()
        {
            ListBuffer = ListHD;
            if (cbNgayGD.Checked)
            {
                DateTime dtFrom = dtpDateFrom.Value;
                DateTime dtTo = dtpDateTo.Value;
                ListBuffer = ListHD.FindAll(HD => HD.NgayThanhToan.Date.CompareTo(dtFrom.Date) >= 0 && HD.NgayThanhToan.Date.CompareTo(dtTo.Date) <= 0);
            }
            if (cbTT.Checked)
            {
                double ttFrom;
                double ttTo;
                if (Double.TryParse(tbTTFrom.Text, out ttFrom) && Double.TryParse(tbTTTo.Text, out ttTo))
                {
                    ListBuffer = ListBuffer.FindAll(HD => (float)ttFrom <= HD.TongTien && HD.TongTien <= (float)ttTo);
                }
                else
                {
                    (new frmDialog("Vui lòng nhập giá trị tổng tiền hợp lệ!", Message.ERROR)).Show();
                }
            }
            if (!cbNgayGD.Checked && !cbTT.Checked)
            {
                ListBuffer = GetListHDNgay(DateTime.Now);
            }
            dtgHoaDon.DataSource = ListBuffer;
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Báo cáo doanh thu";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    //MessageBox.Show(dataGridView1.Columns[i].HeaderText.ToString());
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText.ToString();
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null )
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                        else worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        #endregion


        #region ULTILITIES
        // Tìm Các Hoá đơn theo điều kiện và một số hàm chức năng khác.
        private List<HoaDon> GetListHDNgay(DateTime date)
        {
            List<HoaDon> List = ListHD.FindAll(HD => HD.NgayThanhToan.Date.Equals(date.Date));
            return List;
        }

        private List<HoaDon> GetListHDTuan(DateTime date)
        {
            DateTime firstDateinWeek = FirstDateInWeek(date);
            List<HoaDon> List = ListHD.FindAll(HD => FirstDateInWeek(HD.NgayThanhToan).Date.Equals(firstDateinWeek.Date));
            return List;
        }

        private List<HoaDon> GetListHDThang(int month, int year)
        {
            if (month < 1 && month > 12)
            {
                (new frmDialog("Tháng phải từ 1 đến 12", Message.ERROR)).Show();
                return null;
            }
            else
            {
                List<HoaDon> List = ListHD.FindAll(HD => HD.NgayThanhToan.Month == month && HD.NgayThanhToan.Year == year);
                return List;
            }
        }

        private List<HoaDon> GetListHDNam(int year)
        {
            List<HoaDon> List = ListHD.FindAll(HD => HD.NgayThanhToan.Year == year);
            return List;
        }

        public DateTime FirstDateInWeek(DateTime dt)
        {
            while (dt.DayOfWeek != System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
                dt = dt.AddDays(-1);
            return dt;
        }


        private void ChangeViewMode(int selection)
        {
            if (selection == 1)
            {
                panelNgay.Visible = true;
                panelTuan.Visible = false;
                panelThang.Visible = false;
                panelNangCao.Visible = false;
                panelNam.Visible = false;
            }
            else if (selection == 2)
            {
                panelNgay.Visible = false;
                panelTuan.Visible = true;
                panelThang.Visible = false;
                panelNangCao.Visible = false;
                panelNam.Visible = false;
            }
            else if (selection == 3)
            {
                panelNgay.Visible = false;
                panelTuan.Visible = false;
                panelThang.Visible = true;
                panelNangCao.Visible = false;
                panelNam.Visible = false;
            }
            else if (selection == 4)
            {
                panelNgay.Visible = false;
                panelTuan.Visible = false;
                panelThang.Visible = false;
                panelNangCao.Visible = false;
                panelNam.Visible = true;
            }
            else if (selection == 5)
            {
                panelNgay.Visible = false;
                panelTuan.Visible = false;
                panelThang.Visible = false;
                panelNangCao.Visible = true;
                panelNam.Visible = false;
            }
            else
            {
                panelNgay.Visible = false;
                panelTuan.Visible = false;
                panelThang.Visible = false;
                panelNangCao.Visible = false;
                panelNam.Visible = false;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }
            //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
            ToExcel(dtgHoaDon, filePath);
        }
    }
}
