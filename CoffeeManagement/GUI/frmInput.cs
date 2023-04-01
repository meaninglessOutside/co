using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CoffeeManagement
{
    public partial class frmInput : DevExpress.XtraEditors.XtraForm
    {
        public frmInput()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            tbID.Focus();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            bool condition = checkExisting(GetData());

            if (condition)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else
            {
                (new frmDialog("Không tồn tại bàn này!", Message.NOTIFICATION)).Show();
                tbID.Focus();
                tbID.Select();
            }
        }

        private void tbID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bool condition = checkExisting(GetData());

                if (condition)
                {
                    DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    (new frmDialog("Không tồn tại bàn này!", Message.NOTIFICATION)).Show();
                    tbID.Focus();
                    tbID.Select();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public string GetData()
        {
            int number = Convert.ToInt32(tbID.Text);
            string IDBan = "B" + String.Format("{0:000}", number);
            return IDBan;
        }

        private bool checkExisting(string ID)
        {
            List<Ban> List = BanDAO.Instance.GetData();
            Ban ban = List.Find(item => item.ID == ID);
            if (ban != null) return true;
            return false;
        }


        // Để di chuyển form
        private void frmThanhToan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                x = e.X;
                y = e.Y;
            }
        }

        private void frmThanhToan_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Left += e.X - x;
                Top += e.Y - y;
            }
        }

        private void frmThanhToan_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        int x, y;


        private bool isMouseDown = false;
    }
}