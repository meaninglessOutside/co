using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class frmQuanLyMatHang : DevExpress.XtraEditors.XtraForm
    {
        List<MatHangChiTiet> ListMH;

        public frmQuanLyMatHang()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            ListMH = MatHangDAO.Instance.GetDataMHChiTiet();
            dtgMatHangKho.DataSource = ListMH;
        }

        private void cbDoUong_CheckedChanged(object sender, EventArgs e)
        {
            ChangeListMH();

        }
        private void cbDoAn_CheckedChanged(object sender, EventArgs e)
        {
            ChangeListMH();
        }

        private void cbAnother_CheckedChanged(object sender, EventArgs e)
        {
            ChangeListMH();
        }
        private void txtMatHangTimKiem_TextChanged(object sender, EventArgs e)
        {
            ChangeListMH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ChangeListMH();
        }
        private void ChangeListMH()
        {

            List<MatHangChiTiet> Result = new List<MatHangChiTiet>();
            String keyword = txtMatHangTimKiem.Text.ToLower();

            if (keyword.Length == 0)
            {
                keyword = "";
            }

            if (cbDoUong.Checked == false && cbDoAn.Checked == true && checkAnother.Checked == false)
            {
                FetchResult(Result, keyword, 1);
            }
            else if(cbDoUong.Checked == true && cbDoAn.Checked == false && checkAnother.Checked == false)
            {
                FetchResult(Result, keyword, 2);
            }
            else if (cbDoUong.Checked == false && cbDoAn.Checked == false && checkAnother.Checked == true)
            {
                FetchResult(Result, keyword, 3);
            }
            else if(cbDoUong.Checked == true && cbDoAn.Checked == true && checkAnother.Checked == false)
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
            dtgMatHangKho.DataSource = Result;
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
            else if(type == 3)
            {
                LoaiDoUong = new List<string> { "Khác" };
            }
            else if(type == 4)
            {
                LoaiDoUong = new List<string> { "Đồ ăn", "Đồ uống" };
            }else if(type == 5)
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

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                MatHangChiTiet mh = new MatHangChiTiet();
                mh.TenMatHang = txtTenMatHang.Text;
                mh.Gia = Convert.ToInt32(txtDonGiaKho.Text);
                mh.DonViTinh = cbDVT.Text;
                mh.LoaiMatHang = cbLoaiMH.Text;

                // Insert Data
                MatHangDAO.Instance.InsertData(mh);
                LoadData();
                ChangeListMH();
                (new frmDialog("Thêm mặt hàng thành công", Message.SUCCESS)).Show();
            }
        }

   

        // Hàm kiểm tra 
        private bool Check()
        {
            //biến test để ngăn tình trạng câu lệnh nạp vào SQL bị lỗi
            string test = "'";

            //Kiểm tra tên mặt hàng
            if (string.IsNullOrWhiteSpace(txtTenMatHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenMatHang.Focus();
                return false;
            }

            //Kiểm tra tên mặt hàng có kí tự ' không
            if (string.IsNullOrWhiteSpace(txtTenMatHang.Text) == false)
            {
                for (int i = 0; i < txtTenMatHang.Text.Length; i++)
                {
                    if (txtTenMatHang.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Tên mặt hàng không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenMatHang.Focus();
                        return false;
                    }
                }
            }

            //Kiểm tra loại mặt hàng có kí tự ' không
            if (string.IsNullOrWhiteSpace(cbLoaiMH.Text) == false)
            {
                for (int i = 0; i < cbLoaiMH.Text.Length; i++)
                {
                    if (cbLoaiMH.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Loại mặt hàng không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbLoaiMH.Focus();
                        return false;
                    }
                }
            }
            //Kiểm tra loại mặt hàng có rỗng không
            if (string.IsNullOrWhiteSpace(cbLoaiMH.Text))
            {
                MessageBox.Show("Bạn chưa chọn loại mặt hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLoaiMH.Focus();
                return false;
            }

            //Kiểm tra Đơn vị tính của mặt hàng có kí tự ' không
            if (string.IsNullOrWhiteSpace(cbDVT.Text) == false)
            {
                for (int i = 0; i < cbDVT.Text.Length; i++)
                {
                    if (cbDVT.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Đơn vị tính không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbDVT.Focus();
                        return false;
                    }
                }
            }
            //Kiểm tra đơn vị tính có rỗng không
            if (string.IsNullOrWhiteSpace(cbDVT.Text))
            {
                MessageBox.Show("Bạn chưa chọn đơn vị mặt hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDVT.Focus();
                return false;
            }

            //Kiểm tra đơn giá
            if (string.IsNullOrWhiteSpace(txtDonGiaKho.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGiaKho.Focus();
                return false;
            }
            else
            {
                for (int i = 0; i < txtDonGiaKho.Text.Length; i++)
                {
                    if (char.IsLetterOrDigit(txtDonGiaKho.Text[i]) == false)
                    {
                        MessageBox.Show("Đơn giá chỉ được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDonGiaKho.Focus();
                        return false;
                    }
                }

                //2 biến hỗ trợ việc kiểm tra đơn giá
                string Price = txtDonGiaKho.Text;
                bool check = true;

                for (int i = 0; i < Price.Length; i++)
                {
                    if (char.IsDigit(Price[i]) == false)
                        check = false;
                }
                if (!check)
                {
                    MessageBox.Show("Đơn giá mặt hàng phải là số", "LỖI NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonGiaKho.Focus();
                    return false;
                }
            }
            return true;
        }

        private void btnSuaTV_Click(object sender, EventArgs e)
        {
            if(dtgMatHangKho.SelectedRows.Count == 0)
            {
                (new frmDialog("Chưa chọn mặt hàng", Message.NOTIFICATION)).Show();
                return;
            }
            frmSuaMatHang frm = new frmSuaMatHang();
            frm.getData(dtgMatHangKho.SelectedRows[0]);
            frm.ShowDialog();
            if (DialogResult.Yes == frm.DialogResult)
            {
                LoadData();
                (new frmDialog("Sửa thông tin thành công!", Message.SUCCESS)).Show();
            }
        }

        private void btnXoaTV_Click(object sender, EventArgs e)
        {
            if (dtgMatHangKho.SelectedRows.Count == 0)
            {
                (new frmDialog("Chưa chọn mặt hàng", Message.NOTIFICATION)).Show();
                return;
            }
            if (DialogResult.Yes == MessageBox.Show("Xác nhận xoá mặt hàng?", "Xoá mặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                string idXoa = dtgMatHangKho.SelectedRows[0].Cells[0].Value.ToString();

                if (CTHDDAO.Instance.CheckProductExistenceInCTHD(idXoa))
                {
                    (new frmDialog("Không thể xoá vì mặt hàng này đã được bán!", Message.ERROR)).Show();
                }
                else
                {
                    MatHangDAO.Instance.DeleteData(idXoa);
                    LoadData();
                    ChangeListMH();
                    (new frmDialog("Xoá mặt hàng thành công!", Message.SUCCESS)).Show();
                }
               
               
            }

        }
    }
}