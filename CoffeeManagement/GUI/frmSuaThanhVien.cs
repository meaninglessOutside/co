using System;
using System.Windows.Forms;


namespace CoffeeManagement
{
    public partial class frmSuaThanhVien : DevExpress.XtraEditors.XtraForm
    {
        // tao delegate lay thong tin tu form main
        public delegate void GetData(DataGridViewRow dtgRow);
        public GetData getData;
        // tao delegate truyen thong tin den form main
        public delegate void SendData(string[] rowData);
        public SendData sendData;

        public frmSuaThanhVien()
        {
            this.DialogResult = DialogResult.No;
            InitializeComponent();
            getData = new GetData(getDataThanhVien);
        }
        private void getDataThanhVien(DataGridViewRow dtgRowThanhVien)
        {
            txtSuaID.Text = dtgRowThanhVien.Cells[0].Value.ToString();
            txtSuaHoTen.Text = dtgRowThanhVien.Cells[1].Value.ToString();
            txtSuaSDT.Text = dtgRowThanhVien.Cells[2].Value.ToString();
            txtSuaHangTV.Text = dtgRowThanhVien.Cells[4].Value.ToString();
            txtSuaDiem.Text = dtgRowThanhVien.Cells[5].Value.ToString();
            dateSuaNgayDK.Text = dtgRowThanhVien.Cells[3].Value.ToString();
        }

        private void btnSuaThanhVien_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                string[] rowData = new string[6];
                rowData[0] = txtSuaID.Text;
                rowData[1] = txtSuaHoTen.Text;
                rowData[2] = txtSuaSDT.Text;
                rowData[3] = txtSuaHangTV.Text;
                rowData[4] = txtSuaDiem.Text;
                rowData[5] = dateSuaNgayDK.Text;
                //this.sendData(rowData);
                suaThongTin(rowData);
                DialogResult = DialogResult.Yes;
                //cap nhat du lieu vao database
                this.Close();
            }
        }

        private void frmSuaThongTin_Load(object sender, EventArgs e)
        {

        }
        // ham cap nhat thong tin
        public void suaThongTin(string[] rowData)
        {
            ThanhVien temp = new ThanhVien();
            temp.ID = rowData[0];
            temp.HoTen = rowData[1];
            temp.SDT = rowData[2];
            temp.LoaiTV = rowData[3];
            temp.TienTichLuy = Int32.Parse(rowData[4]);
            temp.NgDK = Convert.ToDateTime(rowData[5]);
            string idSua = rowData[0];
            ThanhVienDAO.Instance.UpdateData(idSua, temp);
        }
        private bool Check()
        {
            //biến test để ngăn tình trạng câu lệnh nạp vào SQL bị lỗi
            string test = "'";

            //Kiểm tra Họ tên

            if (string.IsNullOrWhiteSpace(txtSuaHoTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuaHoTen.Focus();
                return false;
            }
            //Kiểm tra họ tên có chứa kí tự đặc biệt ko
            if (string.IsNullOrWhiteSpace(txtSuaHoTen.Text) == false)
            {
                for (int i = 0; i < txtSuaHoTen.Text.Length; i++)
                {
                    if (txtSuaHoTen.Text[i].ToString() == test)
                    {
                        MessageBox.Show("Họ tên không được chứa kí tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSuaHoTen.Focus();
                        return false;
                    }
                }
            }
            //Kiểm tra độ dài của tên
            if (txtSuaHoTen.Text.Length > 100)
            {
                MessageBox.Show("Tên không được có độ dài quá 100 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuaHoTen.Focus();
                return false;
            }


            //Kiểm tra sđt nhập vào có rỗng không
            if (string.IsNullOrWhiteSpace(txtSuaSDT.Text))
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSuaSDT.Focus();
                return false;
            }
            //Kiểm tra sđt nhập vào có thỏa đk là số và từ 10-11 chữ số không
            if (!string.IsNullOrWhiteSpace(txtSuaSDT.Text))
            {
                string sdt = txtSuaSDT.Text;
                bool check = true;

                //Kiểm tra độ dài SĐT có hợp lệ không
                if (sdt.Length >= 10 && sdt.Length <= 11)
                {
                    //Không cho phép nhập số 0 ở đầu
                    if (sdt[0] != '0')
                    {
                        MessageBox.Show("Số điện thoại phải có số 0 ở đầu", "LỖI NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSuaSDT.Focus();
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
                        txtSuaSDT.Focus();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Độ dài SĐT phải từ 10-11 chữ số", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSuaSDT.Focus();
                    return false;
                }
            }
            //Kiểm tra SĐT có chứa kí tự ' ko
            if (string.IsNullOrWhiteSpace(txtSuaSDT.Text) == false)
            {
                for (int i = 0; i < txtSuaSDT.Text.Length; i++)
                {
                    if (txtSuaSDT.Text[i].ToString() == test)
                    {
                        MessageBox.Show("SĐT không được chứa kí tự ' ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSuaSDT.Focus();
                        return false;
                    }
                }
            }
            //Kiểm tra ngày đk phải nhỏ hơn ngày hiện tại  
            if ((dateSuaNgayDK.DateTime - DateTime.Now).Days > 0)
            {
                MessageBox.Show("Ngày đăng kí phải nhỏ hơn ngày hiện tại", "LỖI NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateSuaNgayDK.Focus();
                return false;
            }
            return true;
        }
    }
}