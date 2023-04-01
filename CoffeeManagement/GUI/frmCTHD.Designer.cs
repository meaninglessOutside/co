namespace CoffeeManagement
{
    partial class frmCTHD
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtgCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXuatHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.lbTHTv = new System.Windows.Forms.Label();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.lbGGv = new System.Windows.Forms.Label();
            this.lbSoHD = new System.Windows.Forms.Label();
            this.lbTTv = new System.Windows.Forms.Label();
            this.lbNGThanhToan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbIDKH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLoaiKH = new System.Windows.Forms.Label();
            this.tbTongTien = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbLoaiKHv = new System.Windows.Forms.Label();
            this.lbSHDv = new System.Windows.Forms.Label();
            this.lbHoTenv = new System.Windows.Forms.Label();
            this.lbNGTTv = new System.Windows.Forms.Label();
            this.lbIDKHv = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.mainPanel.Controls.Add(this.lbTitle);
            this.mainPanel.Controls.Add(this.dtgCTHD);
            this.mainPanel.Controls.Add(this.btnXuatHoaDon);
            this.mainPanel.Controls.Add(this.lbTHTv);
            this.mainPanel.Controls.Add(this.btnBack);
            this.mainPanel.Controls.Add(this.lbGGv);
            this.mainPanel.Controls.Add(this.lbSoHD);
            this.mainPanel.Controls.Add(this.lbTTv);
            this.mainPanel.Controls.Add(this.lbNGThanhToan);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.lbIDKH);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.lbLoaiKH);
            this.mainPanel.Controls.Add(this.tbTongTien);
            this.mainPanel.Controls.Add(this.lbHoTen);
            this.mainPanel.Controls.Add(this.lbLoaiKHv);
            this.mainPanel.Controls.Add(this.lbSHDv);
            this.mainPanel.Controls.Add(this.lbHoTenv);
            this.mainPanel.Controls.Add(this.lbNGTTv);
            this.mainPanel.Controls.Add(this.lbIDKHv);
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(460, 510);
            this.mainPanel.TabIndex = 55;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(113, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(193, 19);
            this.lbTitle.TabIndex = 36;
            this.lbTitle.Text = "HÓA ĐƠN THANH TOÁN";
            // 
            // dtgCTHD
            // 
            this.dtgCTHD.AllowUserToAddRows = false;
            this.dtgCTHD.AllowUserToDeleteRows = false;
            this.dtgCTHD.AllowUserToResizeColumns = false;
            this.dtgCTHD.AllowUserToResizeRows = false;
            this.dtgCTHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.dtgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCTHD.ColumnHeadersVisible = false;
            this.dtgCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgCTHD.Location = new System.Drawing.Point(23, 175);
            this.dtgCTHD.Name = "dtgCTHD";
            this.dtgCTHD.ReadOnly = true;
            this.dtgCTHD.RowHeadersVisible = false;
            this.dtgCTHD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCTHD.Size = new System.Drawing.Size(410, 172);
            this.dtgCTHD.TabIndex = 53;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMatHang";
            this.Column2.HeaderText = "TenMH";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Gia";
            this.Column3.HeaderText = "Gia";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SL";
            this.Column4.HeaderText = "SL";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 30;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TongTien";
            this.Column5.HeaderText = "TongTien";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnXuatHoaDon.Appearance.BackColor2 = System.Drawing.Color.Navy;
            this.btnXuatHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.Appearance.Options.UseBackColor = true;
            this.btnXuatHoaDon.Appearance.Options.UseFont = true;
            this.btnXuatHoaDon.Appearance.Options.UseForeColor = true;
            this.btnXuatHoaDon.AppearanceHovered.BackColor = System.Drawing.Color.GreenYellow;
            this.btnXuatHoaDon.AppearanceHovered.BackColor2 = System.Drawing.Color.Green;
            this.btnXuatHoaDon.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnXuatHoaDon.AppearanceHovered.Options.UseBackColor = true;
            this.btnXuatHoaDon.AppearanceHovered.Options.UseForeColor = true;
            this.btnXuatHoaDon.AppearancePressed.BackColor = System.Drawing.Color.Green;
            this.btnXuatHoaDon.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnXuatHoaDon.AppearancePressed.Options.UseBackColor = true;
            this.btnXuatHoaDon.AppearancePressed.Options.UseForeColor = true;
            this.btnXuatHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(48, 449);
            this.btnXuatHoaDon.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnXuatHoaDon.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(183, 44);
            this.btnXuatHoaDon.TabIndex = 33;
            this.btnXuatHoaDon.Text = "Xuất hoá đơn";
            this.btnXuatHoaDon.Click += new System.EventHandler(this.btnXuatHoaDon_Click);
            // 
            // lbTHTv
            // 
            this.lbTHTv.AutoSize = true;
            this.lbTHTv.Location = new System.Drawing.Point(305, 423);
            this.lbTHTv.Name = "lbTHTv";
            this.lbTHTv.Size = new System.Drawing.Size(73, 13);
            this.lbTHTv.TabIndex = 52;
            this.lbTHTv.Text = "THÀNH TIỀN";
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnBack.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnBack.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseBorderColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.AppearanceHovered.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBack.AppearanceHovered.BackColor2 = System.Drawing.Color.Green;
            this.btnBack.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.AppearanceHovered.ForeColor = System.Drawing.Color.Black;
            this.btnBack.AppearanceHovered.Options.UseBackColor = true;
            this.btnBack.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBack.AppearanceHovered.Options.UseForeColor = true;
            this.btnBack.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.btnBack.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnBack.AppearancePressed.Options.UseBackColor = true;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(292, 453);
            this.btnBack.LookAndFeel.SkinName = "Office 2016 Black";
            this.btnBack.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnBack.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 40);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Đóng";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbGGv
            // 
            this.lbGGv.AutoSize = true;
            this.lbGGv.Location = new System.Drawing.Point(305, 395);
            this.lbGGv.Name = "lbGGv";
            this.lbGGv.Size = new System.Drawing.Size(55, 13);
            this.lbGGv.TabIndex = 51;
            this.lbGGv.Text = "GIẢM GIÁ";
            // 
            // lbSoHD
            // 
            this.lbSoHD.AutoSize = true;
            this.lbSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoHD.Location = new System.Drawing.Point(20, 55);
            this.lbSoHD.Name = "lbSoHD";
            this.lbSoHD.Size = new System.Drawing.Size(75, 13);
            this.lbSoHD.TabIndex = 37;
            this.lbSoHD.Text = "SỐ HÓA ĐƠN";
            // 
            // lbTTv
            // 
            this.lbTTv.AutoSize = true;
            this.lbTTv.Location = new System.Drawing.Point(305, 366);
            this.lbTTv.Name = "lbTTv";
            this.lbTTv.Size = new System.Drawing.Size(66, 13);
            this.lbTTv.TabIndex = 50;
            this.lbTTv.Text = "TỔNG TIỀN";
            // 
            // lbNGThanhToan
            // 
            this.lbNGThanhToan.AutoSize = true;
            this.lbNGThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNGThanhToan.Location = new System.Drawing.Point(20, 77);
            this.lbNGThanhToan.Name = "lbNGThanhToan";
            this.lbNGThanhToan.Size = new System.Drawing.Size(111, 13);
            this.lbNGThanhToan.TabIndex = 38;
            this.lbNGThanhToan.Text = "NGÀY THANH TOÁN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "THÀNH TIỀN";
            // 
            // lbIDKH
            // 
            this.lbIDKH.AutoSize = true;
            this.lbIDKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDKH.Location = new System.Drawing.Point(20, 101);
            this.lbIDKH.Name = "lbIDKH";
            this.lbIDKH.Size = new System.Drawing.Size(97, 13);
            this.lbIDKH.TabIndex = 39;
            this.lbIDKH.Text = "MÃ KHÁCH HÀNG";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "GIẢM GIÁ";
            // 
            // lbLoaiKH
            // 
            this.lbLoaiKH.AutoSize = true;
            this.lbLoaiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiKH.Location = new System.Drawing.Point(20, 148);
            this.lbLoaiKH.Name = "lbLoaiKH";
            this.lbLoaiKH.Size = new System.Drawing.Size(105, 13);
            this.lbLoaiKH.TabIndex = 40;
            this.lbLoaiKH.Text = "LOẠI KHÁCH HÀNG";
            // 
            // tbTongTien
            // 
            this.tbTongTien.AutoSize = true;
            this.tbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.Location = new System.Drawing.Point(20, 366);
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.Size = new System.Drawing.Size(66, 13);
            this.tbTongTien.TabIndex = 47;
            this.tbTongTien.Text = "TỔNG TIỀN";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(20, 124);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(122, 13);
            this.lbHoTen.TabIndex = 41;
            this.lbHoTen.Text = "HỌ TÊN KHÁCH HÀNG";
            // 
            // lbLoaiKHv
            // 
            this.lbLoaiKHv.AutoSize = true;
            this.lbLoaiKHv.Location = new System.Drawing.Point(311, 148);
            this.lbLoaiKHv.Name = "lbLoaiKHv";
            this.lbLoaiKHv.Size = new System.Drawing.Size(105, 13);
            this.lbLoaiKHv.TabIndex = 46;
            this.lbLoaiKHv.Text = "LOẠI KHÁCH HÀNG";
            // 
            // lbSHDv
            // 
            this.lbSHDv.AutoSize = true;
            this.lbSHDv.Location = new System.Drawing.Point(311, 55);
            this.lbSHDv.Name = "lbSHDv";
            this.lbSHDv.Size = new System.Drawing.Size(75, 13);
            this.lbSHDv.TabIndex = 42;
            this.lbSHDv.Text = "SỐ HÓA ĐƠN";
            // 
            // lbHoTenv
            // 
            this.lbHoTenv.AutoSize = true;
            this.lbHoTenv.Location = new System.Drawing.Point(311, 124);
            this.lbHoTenv.Name = "lbHoTenv";
            this.lbHoTenv.Size = new System.Drawing.Size(122, 13);
            this.lbHoTenv.TabIndex = 45;
            this.lbHoTenv.Text = "HỌ TÊN KHÁCH HÀNG";
            // 
            // lbNGTTv
            // 
            this.lbNGTTv.AutoSize = true;
            this.lbNGTTv.Location = new System.Drawing.Point(311, 77);
            this.lbNGTTv.Name = "lbNGTTv";
            this.lbNGTTv.Size = new System.Drawing.Size(111, 13);
            this.lbNGTTv.TabIndex = 43;
            this.lbNGTTv.Text = "NGÀY THANH TOÁN";
            // 
            // lbIDKHv
            // 
            this.lbIDKHv.AutoSize = true;
            this.lbIDKHv.Location = new System.Drawing.Point(311, 101);
            this.lbIDKHv.Name = "lbIDKHv";
            this.lbIDKHv.Size = new System.Drawing.Size(97, 13);
            this.lbIDKHv.TabIndex = 44;
            this.lbIDKHv.Text = "MÃ KHÁCH HÀNG";
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(466, 516);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCTHD";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridView dtgCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevExpress.XtraEditors.SimpleButton btnXuatHoaDon;
        private System.Windows.Forms.Label lbTHTv;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private System.Windows.Forms.Label lbGGv;
        private System.Windows.Forms.Label lbSoHD;
        private System.Windows.Forms.Label lbTTv;
        private System.Windows.Forms.Label lbNGThanhToan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbIDKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLoaiKH;
        private System.Windows.Forms.Label tbTongTien;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbLoaiKHv;
        private System.Windows.Forms.Label lbSHDv;
        private System.Windows.Forms.Label lbHoTenv;
        private System.Windows.Forms.Label lbNGTTv;
        private System.Windows.Forms.Label lbIDKHv;
    }
}