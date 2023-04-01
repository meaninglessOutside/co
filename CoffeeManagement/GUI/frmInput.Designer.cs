namespace CoffeeManagement
{
    partial class frmInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Appearance.Options.UseBackColor = true;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Location = new System.Drawing.Point(156, 114);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(95, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnChuyen.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnChuyen.Appearance.Options.UseBackColor = true;
            this.btnChuyen.Appearance.Options.UseFont = true;
            this.btnChuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuyen.Location = new System.Drawing.Point(33, 114);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(98, 36);
            this.btnChuyen.TabIndex = 6;
            this.btnChuyen.Text = "Chuyển bàn";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(105, 64);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 21);
            this.tbID.TabIndex = 5;
            this.tbID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập bàn muốn chuyển đến?";
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 173);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmInput";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmThanhToan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmThanhToan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmThanhToan_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnChuyen;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
    }
}