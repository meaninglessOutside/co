using CoffeeManagement.DataAcessObject;
using DevExpress.XtraEditors;
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
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
            txtUsername.Text = Global.GlobalUser;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserLoginDAO userLoginDAO = new UserLoginDAO();
            bool isSuccess = userLoginDAO.ChangePassword(txtUsername.Text,txtCurrentPass.Text,txtNewPassword.Text);
            if (isSuccess)
            {
                (new frmDialog("Cập nhật thành công!", Message.SUCCESS)).Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật mật khẩu, Vui lòng kiểm tra lại thông tin");
            }
        }
    }
}