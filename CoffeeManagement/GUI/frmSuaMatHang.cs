using System;
using System.Windows.Forms;


namespace CoffeeManagement
{
    public partial class frmSuaMatHang : DevExpress.XtraEditors.XtraForm
    {
        // tao delegate lay thong tin tu form main
        public delegate void GetData(DataGridViewRow dtgRow);
        public GetData getData;
        // tao delegate truyen thong tin den form main
        public delegate void SendData(string[] rowData);
        public SendData sendData;

        public frmSuaMatHang()
        {
            this.DialogResult = DialogResult.No;
            InitializeComponent();
            getData = new GetData(getDataMatHang);
        }
        private void getDataMatHang(DataGridViewRow dtgRowMatHang)
        {
            txtSuaIDMH.Text = dtgRowMatHang.Cells[0].Value.ToString();
            txtSuaTenMatHang.Text = dtgRowMatHang.Cells[1].Value.ToString();
            cbSuaDVT.Text = dtgRowMatHang.Cells[2].Value.ToString();
            txtSuaDonGiaKho.Text = dtgRowMatHang.Cells[4].Value.ToString();
            cbSuaLoaiMH.Text = dtgRowMatHang.Cells[3].Value.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string[] rowData = new string[5];
                rowData[0] = txtSuaIDMH.Text;
                rowData[1] = txtSuaTenMatHang.Text;
                rowData[2] = cbSuaDVT.Text;
                rowData[4] = txtSuaDonGiaKho.Text;
                rowData[3] = cbSuaLoaiMH.Text;

                //this.sendData(rowData);
                suaThongTin(rowData);
                DialogResult = DialogResult.Yes;
                //cap nhat du lieu vao database
                this.Close();
            }
        }


        // ham cap nhat thong tin
        public void suaThongTin(string[] rowData)
        {
            MatHangChiTiet temp = new MatHangChiTiet();
            temp.ID = rowData[0];
            temp.TenMatHang = rowData[1];
            temp.DonViTinh = rowData[2];
            temp.Gia = Int32.Parse(rowData[4]);
            temp.LoaiMatHang = rowData[3];

            string idSua = rowData[0];
            MatHangDAO.Instance.UpdateData(idSua, temp);
        }
        private bool Check()
        {
            //biến test để ngăn tình trạng câu lệnh nạp vào SQL bị lỗi
            string test = "'";

            //Kiểm tra tên mặt hàng
            if (string.IsNullOrWhiteSpace(txtSuaTenMatHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuaTenMatHang.Focus();
                return false;
            }

            //Kiểm tra tên mặt hàng có kí tự ' không
            if (string.IsNullOrWhiteSpace(txtSuaTenMatHang.Text) == false)
            {
                for (int i = 0; i < txtSuaTenMatHang.Text.Length; i++)
                {
                    if (txtSuaTenMatHang.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Tên mặt hàng không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSuaTenMatHang.Focus();
                        return false;
                    }
                }
            }

            //Kiểm tra loại mặt hàng có rỗng không
            if (string.IsNullOrWhiteSpace(cbSuaLoaiMH.Text))
            {
                MessageBox.Show("Bạn chưa chọn loại mặt hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSuaLoaiMH.Focus();
                return false;
            }

            //Kiểm tra loại mặt hàng có kí tự ' không
            if (string.IsNullOrWhiteSpace(cbSuaLoaiMH.Text) == false)
            {
                for (int i = 0; i < cbSuaLoaiMH.Text.Length; i++)
                {
                    if (cbSuaLoaiMH.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Loại mặt hàng không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbSuaLoaiMH.Focus();
                        return false;
                    }
                }
            }

            //Kiểm tra đơn vị tính có rỗng không
            if (string.IsNullOrWhiteSpace(cbSuaDVT.Text))
            {
                MessageBox.Show("Bạn chưa chọn đơn vị mặt hàng", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbSuaDVT.Focus();
                return false;
            }

            //Kiểm tra Đơn vị tính của mặt hàng có kí tự ' không
            if (string.IsNullOrWhiteSpace(cbSuaDVT.Text) == false)
            {
                for (int i = 0; i < cbSuaDVT.Text.Length; i++)
                {
                    if (cbSuaDVT.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Đơn vị tính không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cbSuaDVT.Focus();
                        return false;
                    }
                }
            }

            //Kiểm tra đơn giá
            if (string.IsNullOrWhiteSpace(txtSuaDonGiaKho.Text))
            {
                MessageBox.Show("Bạn chưa nhập đơn giá", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuaDonGiaKho.Focus();
                return false;
            }
            else
            {

                for (int i = 0; i < txtSuaDonGiaKho.Text.Length; i++)
                {
                    if (char.IsLetterOrDigit(txtSuaDonGiaKho.Text[i]) == false)
                    {
                        MessageBox.Show("Đơn giá chỉ được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSuaDonGiaKho.Focus();
                        return false;
                    }
                }

                //2 biến hỗ trợ việc kiểm tra đơn giá
                string Price = txtSuaDonGiaKho.Text;
                bool check = true;

                for (int i = 0; i < Price.Length; i++)
                {
                    if (char.IsDigit(Price[i]) == false)
                        check = false;
                }
                if (!check)
                {
                    MessageBox.Show("Đơn giá mặt hàng phải là số", "LỖI NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSuaDonGiaKho.Focus();
                    return false;
                }
            }
            return true;
        }

    }
}