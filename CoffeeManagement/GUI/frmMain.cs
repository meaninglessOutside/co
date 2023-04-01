using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CoffeeManagement.DataAcessObject;
using CoffeeManagement.DataTransfertObject;
using CoffeeManagement.GUI;

namespace CoffeeManagement
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        #region KHAI_BÁO_BIẾN_VÀ_KHỞI_TẠO_CÁC_THÀNH_PHẦN_CỦA_CHƯƠNG_TRÌNH
        // KHAI BÁO BIẾN VÀ KHỞI TẠO CÁC THÀNH PHẦN CỦA CHƯƠNG TRÌNH
        List<Ban> ListBan = null;
        List<MatHangChiTiet> ListMH = null;
        List<MatHangDaChon> ListMHDangChon = null;
        DateTime dateReport = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        Report report;

        public frmMain()
        {
            InitializeComponent();
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowForm(this, typeof(frmWaitForm), true, true, false);
            //SplashScreenManager.Default.SetWaitFormCaption("Processing data...");
           
            ListMHDangChon = new List<MatHangDaChon>();
            Load_DaGrView_DSTV();

            // luu du dieu vao list mat hang
            LoatMatHangData();
            LoadBanData();

            loadDataReport();
            this.txtTimKiem.Select();
        }
        // KHAI BÁO BIẾN VÀ KHỞI TẠO CÁC THÀNH PHẦN CỦA CHƯƠNG TRÌNH
        #endregion



        #region THAO_TÁC_VỚI_MẶT_HÀNG
        // THAO TÁC VỚI MẶT HÀNG, CHỌN MẶT HÀNG, CHỈNH SỬA DANH SÁCH MẶT HÀNG ĐÃ CHỌN
        private void dtgDanhSachMatHang_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtgDanhSachMatHang.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dtgDanhSachMatHang.SelectedRows[0];
                txtTenHang.Text = row.Cells[1].Value.ToString();
                numSL.Value = 1;
            }
        }

        private void dtgDanhSachMatHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddItemVaoListDangChon(1);
        }    

        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            if (lvHienThiBan.SelectedItems.Count == 0)
            {
                (new frmDialog("Chưa chọn bàn!", Message.ERROR)).Show();
            }
            else
            {
                string ID_Ban = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
                if(dtgDaChon.SelectedRows.Count == 0)
                {
                    (new frmDialog("Chưa chọn món cần huỷ!", Message.ERROR)).Show();
                }
                else
                {
                    Ban banDaChon = ListBan.Find(ban => (ban.ID == ID_Ban));
                    if (banDaChon.TinhTrang == 1)
                    {
                        foreach (DataGridViewRow item in dtgDaChon.SelectedRows)
                        {
                            CTHDDAO.Instance.DeleteCTHD(ID_Ban, item.Cells[0].Value.ToString());
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow item in dtgDaChon.SelectedRows)
                        {
                            MatHangDaChon mh = ListMHDangChon.Find(m => m.MatHang.ID == item.Cells[0].Value.ToString());
                            ListMHDangChon.Remove(mh);
                        }
                    }
                    LoadCTHD();
                    SetFocusOnItemChanging();
                }
            }
        }

       

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(dtgDanhSachMatHang.SelectedRows.Count == 0)
            {
                (new frmDialog("Chưa chọn món!", Message.ERROR)).Show();
            }
            else
            {
                AddItemVaoListDangChon(Convert.ToInt32(numSL.Value));
            }
        }

        private void dtgDaChon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(dtgDaChon.SelectedRows.Count != 0)
            {
                SelectingIDMatHang = dtgDaChon.SelectedRows[0].Cells[0].Value.ToString();
                AddItemVaoListDangChon(-1);
            }
            
        }

        // THAO TÁC VỚI MẶT HÀNG, CHỌN MẶT HÀNG, CHỈNH SỬA DANH SÁCH MẶT HÀNG ĐÃ CHỌN
        #endregion



        #region TÌM_KIẾM_MẶT_HÀNG
        private void cbDoUong_CheckedChanged(object sender, EventArgs e)
        {
            ChangeListMH();

        }
        private void cbDoAn_CheckedChanged(object sender, EventArgs e)
        {
            ChangeListMH(); ;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChangeListMH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ChangeListMH();
        }
        private void checkAnother_CheckedChanged(object sender, EventArgs e)
        {
            ChangeListMH();
        }
        private void ChangeListMH()
        {

            List<MatHangChiTiet> Result = new List<MatHangChiTiet>();
            String keyword = txtTimKiem.Text.ToLower();

            if (keyword.Length == 0)
            {
                keyword = "";
            }

            if (keyword.Length == 0)
            {
                keyword = "";
            }

            if (cbDoUong.Checked == false && cbDoAn.Checked == true && checkAnother.Checked == false)
            {
                FetchResult(Result, keyword, 1);
            }
            else if (cbDoUong.Checked == true && cbDoAn.Checked == false && checkAnother.Checked == false)
            {
                FetchResult(Result, keyword, 2);
            }
            else if (cbDoUong.Checked == false && cbDoAn.Checked == false && checkAnother.Checked == true)
            {
                FetchResult(Result, keyword, 3);
            }
            else if (cbDoUong.Checked == true && cbDoAn.Checked == true && checkAnother.Checked == false)
            {
                FetchResult(Result, keyword, 4);
            }
            else if (cbDoUong.Checked == false && cbDoAn.Checked == true && checkAnother.Checked == true)
            {
                FetchResult(Result, keyword, 5);
            }
            else if (cbDoUong.Checked == true && cbDoAn.Checked == false && checkAnother.Checked == true)
            {
                FetchResult(Result, keyword, 6);
            }
            else if (cbDoUong.Checked == true && cbDoAn.Checked == true && checkAnother.Checked == true)
            {
                FetchResult(Result, keyword, 7);
            }

            dtgDanhSachMatHang.DataSource = Result;
        }

        private void FetchResult(List<MatHangChiTiet> List, string keyword, int type)
        {
 
            List<string> LoaiDoUong = new List<string>();
            if (type == 1) // Ðồ ăn
            {
                LoaiDoUong = new List<string> { "Đồ ăn" };
            }
            else if (type == 2) // Ðồ uống
            {
                LoaiDoUong = new List<string> { "Đồ uống" };
            }
            else if (type == 3)
            {
                LoaiDoUong = new List<string> { "Khác" };
            }
            else if (type == 4)
            {
                LoaiDoUong = new List<string> { "Đồ ăn", "Đồ uống" };
            }
            else if (type == 5)
            {
                LoaiDoUong = new List<string> { "Đồ ăn", "Khác" };
            }
            else if (type == 6)
            {
                LoaiDoUong = new List<string> { "Đồ uống", "Khác" };
            }
            else if (type == 7)
            {
                LoaiDoUong = new List<string> { "Đồ ăn", "Đồ uống", "Khác" };
            }

            foreach (MatHangChiTiet mh in ListMH)
            {
                if (Function.Instance.RemoveSign(mh.TenMatHang.ToLower()).Contains(Function.Instance.RemoveSign(keyword))
                    && LoaiDoUong.Contains(mh.LoaiMatHang))
                {
                    List.Add(mh);
                }
            }

        }
        #endregion



        #region THAO_TÁC_VỚI_BÀN
        private void btnDatBan_Click(object sender, EventArgs e)
        {
            if (btnDatBan.Text == "Đặt bàn")
            {
                if (ListMHDangChon.Count == 0)
                {
                    (new frmDialog("Chưa chọn món!", Message.ERROR)).Show();
                }
                else
                {
                    HoaDon HoaDon = new HoaDon()
                    {
                        IDBan = lvHienThiBan.SelectedItems[0].SubItems[2].Text,
                    };
                    HoaDonDAO.Instance.InsertData(HoaDon);
                    BanDAO.Instance.UpdateData(HoaDon.IDBan, 1);

                    AddListDangChonVaoCTHD();
                    SelectingIDBan = HoaDon.IDBan;
                    LoadBanData();

                    ListMHDangChon.Clear();
                    btnDatBan.Text = "Thanh toán";
                    (new frmDialog("Đặt bàn thành công!", Message.SUCCESS)).Show();
                }
            }
            else if (btnDatBan.Text == "Thanh toán")
            {
                if (lvHienThiBan.SelectedItems.Count != 0)
                {
                    


                    string IDBan = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
                    if (BanGopChungDAO.Instance.CheckExistence(IDBan))
                    {
                        string tmp = BanGopChungDAO.Instance.GetBanDaiDien(IDBan);
                        if (CTHDDAO.Instance.GetCTHDData(tmp).Rows.Count == 0)
                        {
                            (new frmDialog("Chưa có món nào được đặt!", Message.ERROR)).Show();
                            return;
                        }
                    }
                    else
                    {
                        if (dtgDaChon.SelectedRows.Count == 0)
                        {
                            (new frmDialog("Chưa có món nào được đặt!", Message.ERROR)).Show();
                            return;
                        }
                    }
                    string ID = BanGopChungDAO.Instance.GetBanDaiDien(IDBan);
                    using (frmThanhToan frmThanhToan = new frmThanhToan(ID))
                    {
                        if (frmThanhToan.ShowDialog() == DialogResult.Yes)
                        {
                            /// Xử lí tác vụ thanh toán: lưu dữ liệu vào database ở form Thanh Toán

                            LoadCTHD();
                            LoadBanData();
                            btnDatBan.Text = "Đặt bàn";
                            (new frmDialog("Thanh toán thành công!", Message.SUCCESS)).Show();
                        }
                        else
                        {
                            (new frmDialog("Đã huỷ thanh toán!", Message.NOTIFICATION)).Show();
                        }
                    }
                }

            }


        }

        private void lvHienThiBan_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem item = lvHienThiBan.GetItemAt(e.X, e.Y);
            if (e.Button == MouseButtons.Right && item != null)
            {
                contextMenuBan.Show(lvHienThiBan, new Point(e.X, e.Y));
            }
        }

        // CONTEXT MENU STRIP TẠI LIST BÀN

        private void menuItemChuyenBan_Click(object sender, EventArgs e)
        {
            string IDBan = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
            Ban ban = ListBan.Find(item => item.ID == IDBan);
            if (ban.TinhTrang == 0)
            {
                (new frmDialog("Bàn này chưa được đặt!", Message.NOTIFICATION)).Show();
            }
            else
            {
                if (BanGopChungDAO.Instance.CheckExistence(IDBan))
                {
                    (new frmDialog("Không thể chuyển vì bàn này đang được gộp", Message.ERROR)).Show();
                }
                else
                {
                    frmInput frmInput = new frmInput();
                    frmInput.ShowDialog();
                    if (DialogResult.Yes == frmInput.DialogResult)
                    {
                        string IDBanmoi = frmInput.GetData();

                        HoaDon HD = HoaDonDAO.Instance.GetDataViaId(IDBan);
                        HD.IDBan = IDBanmoi;

                        HoaDonDAO.Instance.UpdateData(IDBan, HD);
                        BanDAO.Instance.UpdateData(IDBan, 0);
                        BanDAO.Instance.UpdateData(IDBanmoi, 1);

                        SelectingIDBan = IDBanmoi;
                        LoadBanData();
                        (new frmDialog("Chuyển bàn thành công!", Message.SUCCESS)).Show();
                    }
                }

            }

        }

        //Gộp bàn
        private void menuItemGopBan_Click(object sender, EventArgs e)
        {
            if (lvHienThiBan.SelectedItems.Count < 2)
            {
                (new frmDialog("Chọn ít nhất 2 bàn để gộp bàn!", Message.NOTIFICATION)).Show();
            }
            else
            {
                bool isContinue = true;
                // Lấy ID các bàn đang chọn
                List<string> ListIDBanGop = new List<string>();
                string RepresentingID = lvHienThiBan.SelectedItems[0].SubItems[2].Text;//ID bàn đại diện
                for (int i = 1; i < lvHienThiBan.SelectedItems.Count; i++)
                {
                    string id = lvHienThiBan.SelectedItems[i].SubItems[2].Text;//ID các bàn còn lại
                    ListIDBanGop.Add(id);
                }


                //// Kiểm tra xem các bàn đang chọn đã được gộp trước đó chưa?
                foreach (string id in ListIDBanGop)
                {
                    if (BanGopChungDAO.Instance.CheckExistence(id) == true)
                    {
                        (new frmDialog("Không thể gộp bàn đã được gộp trước đó", Message.ERROR)).Show();
                        isContinue = false;
                    }
                }
                if (BanGopChungDAO.Instance.CheckExistence(RepresentingID) == true)
                {
                    (new frmDialog("Không thể gộp bàn đã được gộp trước đó", Message.ERROR)).Show();
                    isContinue = false;
                }

                // Các bàn đang chọn chưa được gộp trước đó (isContinue = true)
                if (isContinue)
                {
                    BanGopChungDAO.Instance.InsertData(RepresentingID, ListIDBanGop);//Đưa thông tin vào csdl
                    LoadBanData();
                    (new frmDialog("Gộp bàn thành công!", Message.SUCCESS)).Show();
                }

            }

        }
        //Chuyển bàn
        private void menuItemHuyBan_Click(object sender, EventArgs e)
        {
            string ID_BAN = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
            Ban ban = ListBan.Find(item => item.ID == ID_BAN);
            if (ban.TinhTrang == 0)
            {
                (new frmDialog("Bàn đang trống! Không thể huỷ!", Message.ERROR)).Show();
            }
            else
            {

                if (DialogResult.Yes == MessageBox.Show("Xác nhận huỷ bàn?", "Huỷ bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (BanGopChungDAO.Instance.CheckNDeleteData(ID_BAN) == true)
                    {
                        // Cập nhật lại trình trạng của bàn.
                        BanDAO.Instance.UpdateData(ID_BAN, 0);
                        LoadBanData();
                        LoadCTHD();

                        //Xoá dữ liệu về hoá đơn, chi tiết hoá đơn liên quan.
                        HoaDonDAO.Instance.DeleteData(ID_BAN);
                        (new frmDialog("Huỷ bàn thành công!", Message.SUCCESS)).Show();
                    }
                    else
                    {
                        string msg = "Bàn này đang là bàn đại diện cho một số bàn gộp, huỷ bàn này đồng nghĩa với việc huỷ các bàn gộp.\nBạn có muốn tiếp tục huỷ không?";
                        if (DialogResult.Yes == MessageBox.Show(msg, "Xác nhận huỷ bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            //Huỷ tất cả các bạn gộp chung với bàn này.
                            BanGopChungDAO.Instance.DeleteAllBanGop(ID_BAN);
                            LoadBanData();
                            LoadCTHD();
                        }
                    }

                }

            }


        }
        // CONTEXT MENU STRIP TẠI LIST BÀN

        // ĐẶT BÀN, THANH TOÁN, HUỶ BÀN, GỘP BÀN,...
        #endregion



        #region TRẠNG_THÁI_CỦA_BÀN
        //// TRẠNG THÁI CỦA BÀN
        private void lvHienThiBan_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(lvHienThiBan.SelectedItems.Count != 0)
            {
                string ID_Ban = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
                Ban ban = ListBan.Find(i => i.ID == ID_Ban);
                if (ban.TinhTrang == 0)
                {
                    btnDatBan.Text = "Đặt bàn";
                }
                else
                {
                    btnDatBan.Text = "Thanh toán";
                }
                LoadCTHD();
            }
        }

        private void lvHienThiBan_MouseClick(object sender, MouseEventArgs e)
        {
          //  LoadCTHD();
        }

        private void lvHienThiBan_Click(object sender, EventArgs e)
        {
            if(lvHienThiBan.SelectedItems.Count == 0)
            {
                LoadCTHD();
            }

        }
        // TRẠNG THÁI CỦA BÀN
        #endregion



        #region KHAI_BÁO_MỘT_SỐ_BIẾN_KHÁC
        private string SelectingIDMatHang = null;
        private string SelectingIDBan = null;

        #endregion



        #region Load_Dữ_Liệu
        // Load dữ liệu
        private void LoadBanData()
        {
            lvHienThiBan.Clear();
            ListBan = BanDAO.Instance.GetData();

            bool isChecked = false;
            foreach (Ban item in ListBan)
            {

                ListViewItem it = new ListViewItem() { Text = item.TenBan };
                it.SubItems.Add(item.TinhTrang.ToString());
                it.SubItems.Add(item.ID);
                if (item.TinhTrang == 0) it.ImageIndex = 0;
                else it.ImageIndex = 1;

                if (item.ID == SelectingIDBan)
                {
                    it.Checked = true;
                    it.Selected = true;
                    isChecked = true;
                }

                lvHienThiBan.Items.Add(it);
            }
            if (!isChecked)
            {
                lvHienThiBan.Items[0].Selected = true;
                lvHienThiBan.Items[0].Checked = true;
            }
        }


        private void LoatMatHangData()
        {
            ListMH = MatHangDAO.Instance.GetDataMHChiTiet();
            dtgDanhSachMatHang.DataSource = MatHangDAO.Instance.GetData();
        }

        private void LoadCTHD()
        {
            if (lvHienThiBan.SelectedItems.Count != 0)
            {
                string ID_Ban = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
                Ban ban = ListBan.Find((item) => item.ID == ID_Ban);

                if (ban.TinhTrang == 0)
                {
                    List<MatHangHienThiTrenOrder> List = new List<MatHangHienThiTrenOrder>();
                    foreach (MatHangDaChon mh in ListMHDangChon)
                    {
                        MatHangHienThiTrenOrder item = new MatHangHienThiTrenOrder()
                        {
                            ID = mh.GetInfo()[0],
                            TenMatHang = mh.GetInfo()[1],
                            SL = Convert.ToInt32(mh.GetInfo()[2]),
                            TongTien = Convert.ToInt32(mh.GetInfo()[3])
                        };
                        List.Add(item);
                    }
                    dtgDaChon.DataSource = List;
                }
                else
                {
                    dtgDaChon.DataSource = CTHDDAO.Instance.GetCTHDData(ID_Ban);
                }

            }
            else
            {
                List<MatHangHienThiTrenOrder> List = new List<MatHangHienThiTrenOrder>();
                dtgDaChon.DataSource = List;
                btnDatBan.Text = "Đặt bàn";
            }

        }

        #endregion



        #region Tool
        // Thêm mặt hàng đang chọn vào List order và cập nhật thông tin trên vùng mặt hàng đang chọn
        private void AddItemVaoListDangChon(int SL)
        {
            if (lvHienThiBan.SelectedItems.Count == 0)
            {
                (new frmDialog("Chưa chọn bàn!", Message.ERROR)).Show();
            }
            else
            {
                string ID_MH;
                string ID_Ban = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
                if (SL > 0)
                {
                    if (dtgDanhSachMatHang.SelectedRows.Count == 0)
                    {
                        return;
                    }
                    ID_MH = dtgDanhSachMatHang.SelectedRows[0].Cells[0].Value.ToString();
                    ID_Ban = BanGopChungDAO.Instance.GetBanDaiDien(ID_Ban);
                }
                else
                {
                    ID_MH = dtgDaChon.SelectedRows[0].Cells[0].Value.ToString();
                }

                MatHangDaChon matHangDaChon = new MatHangDaChon(ListMH.Find(mh => (mh.ID == ID_MH)), SL);
                Ban banDaChon = ListBan.Find(ban => (ban.ID == ID_Ban));

                if (banDaChon.TinhTrang == 0) //Bàn trống - làm việc với list nhớ tạm thời.(Sau đó thêm list này vào CSDL khi xác nhận dặt bàn)
                {
                    MatHangDaChon mh = ListMHDangChon.Find(item => item.MatHang.ID == matHangDaChon.MatHang.ID);
                    if (mh == null) //Mặt hàng chưa có trong danh sách tạm -> Thêm vào list
                    {
                        ListMHDangChon.Add(matHangDaChon);
                    }
                    else //Mặt hàng chưa có trong danh sách tạm -> tjăng số lượng tương ứng
                    {
                        mh.SoLuong += SL;

                        if (mh.SoLuong <= 0)
                        {
                            ListMHDangChon.Remove(mh);
                        }
                    }

                }
                else //Bàn đã được đặt trước đó - làm việc với CSDL: CTHD
                {
                    CTHDDAO.Instance.InsertOrUpdateCTHD(ID_Ban, ID_MH, SL);

                }
                SelectingIDBan = ID_Ban;
                LoadBanData();
                LoadCTHD();

                // Focus vào item đang chỉnh sửa số lượng ở danh sách đang chọn
                if (SL < 0)
                {
                    SetFocusOnItemChanging();
                }
                numSL.Value = 1;
            }
        }

        private void AddListDangChonVaoCTHD()
        {
            string ID_Ban = lvHienThiBan.SelectedItems[0].SubItems[2].Text;
            foreach (var mh in ListMHDangChon)
            {
                CTHDDAO.Instance.InsertOrUpdateCTHD(ID_Ban, mh.MatHang.ID, mh.SoLuong);
            }
        }

        private void SetFocusOnItemChanging()
        {
            bool isDone = false;
            foreach (DataGridViewRow i in dtgDaChon.Rows)
            {

                if (i.Cells[0].Value.ToString() == SelectingIDMatHang)
                {
                    i.Selected = true;
                    isDone = true;
                }
                else
                {
                    i.Selected = false;
                }
            }
            if (!isDone)
            {
                if (dtgDaChon.Rows.Count != 0)
                {
                    dtgDaChon.Rows[dtgDaChon.Rows.Count - 1].Selected = true;
                }

            }
        }
        #endregion



        #region MAIN_MENU

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            // resize series button
            int space = this.ClientSize.Width - btnExit.Location.X - btnExit.Width;
            int addSize = space / 8;
            btnBanMoi.Width += addSize;
            btnHuyAll.Width += addSize;
            btnHuyAll.Location = new Point(btnHuyAll.Location.X + addSize, btnHuyAll.Location.Y);
            btnXemKho.Width += addSize;
            btnXemKho.Location = new Point(btnXemKho.Location.X + 2 * addSize, btnXemKho.Location.Y);
            btnLichSu.Width += addSize;
            btnLichSu.Location = new Point(btnLichSu.Location.X + 3 * addSize, btnLichSu.Location.Y);
            btnDangXuat.Width += addSize;
            btnDangXuat.Location = new Point(btnDangXuat.Location.X + 4 * addSize, btnDangXuat.Location.Y);
            btnLoginAD.Width += addSize;
            btnLoginAD.Location = new Point(btnLoginAD.Location.X + 5 * addSize, btnLoginAD.Location.Y);

            // resize dtg dstv

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
                this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnLoginAD_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin(checkAdmin);
            frm.ShowDialog();
            if(DialogResult.OK == frm.DialogResult)
            {
                isLogin = true;
                (new frmDialog("Đăng nhập dưới quyền quản trị viên thành công!", Message.SUCCESS)).Show();
            }
        }
        private void checkAdmin(string user, string password)
        {
            if(Global.GlobalUser == "admin") { 
                btnBanMoi.Enabled = true;
                btnXemKho.Enabled = true;
                btnLoginAD.Enabled = false;
                btnDangXuat.Enabled = true;
                btnChangePassword.Enabled = true;
            }
        }
        private bool isLogin = false;

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn đăng xuất quyền Admin?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    isLogin = false;
                    btnXemKho.Enabled = false;
                    btnBanMoi.Enabled = false;
                    btnLoginAD.Enabled = true;
                    btnDangXuat.Enabled = false;
                    btnChangePassword.Enabled = false;
                    (new frmDialog("Đăng xuất thành công!", Message.SUCCESS)).Show();
                }
            }
            else
            {
                (new frmDialog("Bạn chưa đăng nhập!", Message.NOTIFICATION)).Show();
            }
            
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            (new frmLichSuGiaoDich()).ShowDialog();
        }

        private void btnQuanLyMatHang_Click(object sender, EventArgs e)
        {
            (new frmQuanLyMatHang()).ShowDialog();
        }

        private void btnHuyHetBan_Click(object sender, EventArgs e)
        {
            if (ListBan.Find(B => B.TinhTrang == 1) == null)
            {
                (new frmDialog("Tất cả các bàn đều đang trống!", Message.NOTIFICATION)).Show();
                return;
            }
            if (DialogResult.OK == MessageBox.Show("Xác nhận huỷ tất cả các bàn đang đặt?", "Hủy bàn", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                foreach (Ban Ban in ListBan)
                {
                    if (Ban.TinhTrang == 1)
                    {
                        BanDAO.Instance.UpdateData(Ban.ID, 0);
                        HoaDonDAO.Instance.DeleteData(Ban.ID);
                        BanGopChungDAO.Instance.DeleteAllBanGop(Ban.ID);
                    }
                }
                LoadBanData();
                LoadCTHD();
                (new frmDialog("Đã huỷ tất cả các bàn!", Message.SUCCESS)).Show();
            }
        }

        private void btnBanMoi_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Xác nhận thêm bàn mới?", "Thêm bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                BanDAO.Instance.InsertData();
                LoadBanData();
                (new frmDialog("Thêm bàn mới thành công!", Message.SUCCESS)).Show();
            }
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            (new frmThongTin()).ShowDialog();
        }

        #endregion



        #region REPORT INCOME

        private void dateNgayBDTinh_TextChanged(object sender, EventArgs e)
        {
            loadDataReport();
        }
        private void loadDataReport()
        {                     
            report = new Report(dateReport);
            long sum = 0;
            for (int i = 0; i < report.dataReport.Rows.Count; i++)
            {
                report.dataReport.Rows[i][4] = int.Parse(report.dataReport.Rows[i][2].ToString()) * int.Parse(report.dataReport.Rows[i][3].ToString());
                sum += int.Parse(report.dataReport.Rows[i][4].ToString());
            }
        }

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdTuan_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
        }
        #endregion



        #region THÀNH VIÊN
        // THANH VIEN
        List<ThanhVien> ListTV = new List<ThanhVien>();

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                //Thêm thành viên vào List
                ThanhVien newbie = new ThanhVien();
                newbie.HoTen = txtHoTenDK.Text;
                newbie.SDT = txtSDTDK.Text;
                newbie.NgDK = DateTime.Now.Date;
                newbie.LoaiTV = "Thường";
                newbie.TienTichLuy = 0;
                ListTV.Add(newbie);

                // Insert Data
                ThanhVienDAO.Instance.InsertData(newbie);
                dtgDS.DataSource = ThanhVienDAO.Instance.LoadDataDSTV();
                (new frmDialog("Thêm thành viên thành công!", Message.SUCCESS)).Show();
                txtHoTenDK.Text = "";
                txtSDTDK.Text = "";
                // Hiển thị đầy đủ thông tin thành viên vừa đăng kí 
            }
        }

        private void txtSDTTimKiem_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSDTTimKiem.Text.Length; i++)
            {
                if (char.IsLetterOrDigit(txtSDTTimKiem.Text[i]) == false)
                {
                    MessageBox.Show("SĐT không được chứa kí tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDTTimKiem.Focus();
                    return;
                }
            }
            string a = txtSDTTimKiem.Text;
            dtgDS.DataSource = ThanhVienDAO.Instance.TiemKiemTV(a);
        }

        private void btnTimKiemTV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSDTTimKiem.Text.Length; i++)
            {
                if (char.IsLetterOrDigit(txtSDTTimKiem.Text[i]) == false)
                {
                    MessageBox.Show("SĐT không được chứa kí tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDTTimKiem.Focus();
                    return;
                }
            }
            string a = txtSDTTimKiem.Text;
            dtgDS.DataSource = ThanhVienDAO.Instance.TiemKiemTV(a);

        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            if(dtgDS.SelectedRows.Count != 0)
            {
                string idXoa = dtgDS.SelectedRows[0].Cells[0].Value.ToString();
                ThanhVienDAO.Instance.DeleteData(idXoa);
                Load_DaGrView_DSTV();
                (new frmDialog("Xoá thành viên thành công!", Message.SUCCESS)).Show();
            }
            else
            {
                (new frmDialog("Chưa chọn thành viên!", Message.ERROR)).Show();
            }
            
        }

        private void btnSuaTV_Click(object sender, EventArgs e)
        {
            if(dtgDS.SelectedRows.Count != 0)
            {
                frmSuaThanhVien frm = new frmSuaThanhVien();
                frm.getData(dtgDS.SelectedRows[0]);
                frm.ShowDialog();
                if (DialogResult.Yes == frm.DialogResult)
                {
                    (new frmDialog("Sửa thông tin thành công!", Message.SUCCESS)).Show();
                    Load_DaGrView_DSTV();

                }
            }
            else
            {
                (new frmDialog("Chưa chọn thành viên!", Message.NOTIFICATION)).Show();
            }
            
        }

        public void Load_DaGrView_DSTV()
        {
            dtgDS.DataSource = ThanhVienDAO.Instance.LoadDataDSTV();
        }
        private bool Check()
        {
            //biến test để ngăn tình trạng câu lệnh nạp vào SQL bị lỗi
            string test = "'";

            //Kiểm tra Họ tên

            if (string.IsNullOrWhiteSpace(txtHoTenDK.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenDK.Focus();
                return false;
            }
            //Kiểm tra họ tên có chứa kí tự ' ko
            if (string.IsNullOrWhiteSpace(txtHoTenDK.Text) == false)
            {
                for (int i = 0; i < txtHoTenDK.Text.Length; i++)
                {
                    if (txtHoTenDK.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Họ tên không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHoTenDK.Focus();
                        return false;
                    }
                }
            }
            //Kiểm tra độ dài của tên
            if (txtHoTenDK.Text.Length > 100)
            {
                MessageBox.Show("Tên không được có độ dài quá 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenDK.Focus();
                return false;
            }


            //Kiểm tra sđt nhập vào có rỗng không
            if (string.IsNullOrWhiteSpace(txtSDTDK.Text))
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDTDK.Focus();
                return false;
            }
            //Kiểm tra sđt nhập vào có thỏa đk là số và từ 10-11 chữ số không
            if (!string.IsNullOrWhiteSpace(txtSDTDK.Text))
            {
                string sdt = txtSDTDK.Text;
                bool check = true;

                //Kiểm tra độ dài SĐT có hợp lệ không
                if (sdt.Length >= 10 && sdt.Length <= 11)
                {
                    //Không cho phép nhập số 0 ở đầu
                    if (sdt[0] != '0')
                    {
                        MessageBox.Show("Số điện thoại phải có số 0 ở đầu", "LỖI NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSDTDK.Focus();
                        return false;
                    }
                    //Kiểm tra nhập vào có phải số không
                    for (int i = 0; i < sdt.Length; i++)
                    {
                        if (char.IsDigit(sdt[i]) == false)
                            check = false;
                    }
                    if (!check)
                    {
                        MessageBox.Show("Số điện thoại bạn nhập phải là số", "LỖI NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSDTDK.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Độ dài SĐT phải từ 10-11 chữ số", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSDTDK.Focus();
                    return false;
                }
            }
            //Kiểm tra SĐT có chứa kí tự ' ko
            if (string.IsNullOrWhiteSpace(txtSDTDK.Text) == false)
            {
                for (int i = 0; i < txtSDTDK.Text.Length; i++)
                {
                    if (txtSDTDK.Text[i].ToString() == test)
                    {
                        MessageBox.Show("SĐT không được chứa kí tự ' ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSDTDK.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion


        private void tabMain_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
