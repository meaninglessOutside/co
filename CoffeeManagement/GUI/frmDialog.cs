using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public enum Message
    {
        SUCCESS = 1, ERROR = -1, NOTIFICATION = 0
    }
    public partial class frmDialog : Form
    {
        string message;
        Message type;
        public frmDialog(String msg, Message type)
        {
            InitializeComponent();
            
            this.message = msg;
            this.type = type;
        }

        private void frmDialog_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(lbmsg.Size.Width + 100 + btnClose.Size.Width + 50, 60);
            btnClose.Image = new Bitmap(Properties.Resources.closeDialog, new Size(36, 36));
            Top = 20;
            Left = 20;
            this.TopMost = true;
            timerClose.Enabled = true;
            this.lbmsg.Text = message;
            if(type == Message.ERROR)
            {
                this.BackColor = Color.FromArgb(189, 13, 13);
            }
            else if(type == Message.SUCCESS)
            {
                this.BackColor = Color.FromArgb(81, 186, 15);
            }
            Point position = new Point(
                this.Size.Width / 2 - lbmsg.Size.Width / 2 - btnClose.Width,
                this.Size.Height / 2 - lbmsg.Size.Height / 2
                );
            lbmsg.Location = position;
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDialog_MouseHover(object sender, EventArgs e)
        {
            timerClose.Enabled = false;
        }

        private void frmDialog_MouseLeave(object sender, EventArgs e)
        {
            timerClose.Enabled = true;
            timerClose.Interval = 1000;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

    }
}
