namespace CoffeeManagement
{
    partial class frmQuanLyMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyMatHang));
            this.grNhapKho = new DevExpress.XtraEditors.GroupControl();
            this.cbDVT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbDVT = new DevExpress.XtraEditors.LabelControl();
            this.cbLoaiMH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbLoaiMH = new DevExpress.XtraEditors.LabelControl();
            this.btnDK = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGiaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMatHang = new DevExpress.XtraEditors.TextEdit();
            this.lbĐonGiaKho = new DevExpress.XtraEditors.LabelControl();
            this.lbMatHangKho = new DevExpress.XtraEditors.LabelControl();
            this.grTKKho = new DevExpress.XtraEditors.GroupControl();
            this.cbDoAn = new DevExpress.XtraEditors.CheckEdit();
            this.cbDoUong = new DevExpress.XtraEditors.CheckEdit();
            this.btnTimKiemMH = new DevExpress.XtraEditors.SimpleButton();
            this.lbTenMatHangTimKiem = new DevExpress.XtraEditors.LabelControl();
            this.txtMatHangTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgMatHangKho = new System.Windows.Forms.DataGridView();
            this.btnXoaTV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaTV = new DevExpress.XtraEditors.SimpleButton();
            this.checkAnother = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grNhapKho)).BeginInit();
            this.grNhapKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiMH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTKKho)).BeginInit();
            this.grTKKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDoAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDoUong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatHangTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatHangKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnother.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grNhapKho
            // 
            this.grNhapKho.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.grNhapKho.Appearance.Options.UseBackColor = true;
            this.grNhapKho.Controls.Add(this.cbDVT);
            this.grNhapKho.Controls.Add(this.lbDVT);
            this.grNhapKho.Controls.Add(this.cbLoaiMH);
            this.grNhapKho.Controls.Add(this.lbLoaiMH);
            this.grNhapKho.Controls.Add(this.btnDK);
            this.grNhapKho.Controls.Add(this.txtDonGiaKho);
            this.grNhapKho.Controls.Add(this.txtTenMatHang);
            this.grNhapKho.Controls.Add(this.lbĐonGiaKho);
            this.grNhapKho.Controls.Add(this.lbMatHangKho);
            this.grNhapKho.Location = new System.Drawing.Point(477, 132);
            this.grNhapKho.Name = "grNhapKho";
            this.grNhapKho.Size = new System.Drawing.Size(366, 322);
            this.grNhapKho.TabIndex = 15;
            this.grNhapKho.Text = "NHẬP KHO";
            // 
            // cbDVT
            // 
            this.cbDVT.Location = new System.Drawing.Point(147, 156);
            this.cbDVT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDVT.Properties.Appearance.Options.UseFont = true;
            this.cbDVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDVT.Properties.Items.AddRange(new object[] {
            "Ly",
            "Đĩa",
            "Gói"});
            this.cbDVT.Size = new System.Drawing.Size(186, 28);
            this.cbDVT.TabIndex = 8;
            // 
            // lbDVT
            // 
            this.lbDVT.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDVT.Appearance.Options.UseFont = true;
            this.lbDVT.Location = new System.Drawing.Point(11, 159);
            this.lbDVT.Name = "lbDVT";
            this.lbDVT.Size = new System.Drawing.Size(34, 19);
            this.lbDVT.TabIndex = 7;
            this.lbDVT.Text = "ĐVT";
            // 
            // cbLoaiMH
            // 
            this.cbLoaiMH.Location = new System.Drawing.Point(147, 115);
            this.cbLoaiMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiMH.Name = "cbLoaiMH";
            this.cbLoaiMH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiMH.Properties.Appearance.Options.UseFont = true;
            this.cbLoaiMH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbLoaiMH.Properties.Items.AddRange(new object[] {
            "Đồ uống",
            "Đồ ăn",
            "Khác"});
            this.cbLoaiMH.Size = new System.Drawing.Size(186, 28);
            this.cbLoaiMH.TabIndex = 6;
            // 
            // lbLoaiMH
            // 
            this.lbLoaiMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiMH.Appearance.Options.UseFont = true;
            this.lbLoaiMH.Location = new System.Drawing.Point(11, 117);
            this.lbLoaiMH.Name = "lbLoaiMH";
            this.lbLoaiMH.Size = new System.Drawing.Size(115, 19);
            this.lbLoaiMH.TabIndex = 5;
            this.lbLoaiMH.Text = "Loại Mặt hàng";
            // 
            // btnDK
            // 
            this.btnDK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.Appearance.Options.UseFont = true;
            this.btnDK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDK.ImageOptions.Image = global::CoffeeManagement.Properties.Resources.logoLuaChon;
            this.btnDK.Location = new System.Drawing.Point(147, 223);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(119, 45);
            this.btnDK.TabIndex = 3;
            this.btnDK.Text = "Thêm ";
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // txtDonGiaKho
            // 
            this.txtDonGiaKho.Location = new System.Drawing.Point(147, 77);
            this.txtDonGiaKho.Name = "txtDonGiaKho";
            this.txtDonGiaKho.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaKho.Properties.Appearance.Options.UseFont = true;
            this.txtDonGiaKho.Size = new System.Drawing.Size(186, 26);
            this.txtDonGiaKho.TabIndex = 1;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(147, 38);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Properties.Appearance.Options.UseFont = true;
            this.txtTenMatHang.Size = new System.Drawing.Size(186, 26);
            this.txtTenMatHang.TabIndex = 0;
            // 
            // lbĐonGiaKho
            // 
            this.lbĐonGiaKho.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbĐonGiaKho.Appearance.Options.UseFont = true;
            this.lbĐonGiaKho.Location = new System.Drawing.Point(11, 80);
            this.lbĐonGiaKho.Name = "lbĐonGiaKho";
            this.lbĐonGiaKho.Size = new System.Drawing.Size(62, 19);
            this.lbĐonGiaKho.TabIndex = 0;
            this.lbĐonGiaKho.Text = "Đơn giá";
            // 
            // lbMatHangKho
            // 
            this.lbMatHangKho.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatHangKho.Appearance.Options.UseFont = true;
            this.lbMatHangKho.Location = new System.Drawing.Point(11, 41);
            this.lbMatHangKho.Name = "lbMatHangKho";
            this.lbMatHangKho.Size = new System.Drawing.Size(112, 19);
            this.lbMatHangKho.TabIndex = 0;
            this.lbMatHangKho.Text = "Tên Mặt hàng";
            // 
            // grTKKho
            // 
            this.grTKKho.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.grTKKho.Appearance.Options.UseBackColor = true;
            this.grTKKho.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.grTKKho.AppearanceCaption.Options.UseBackColor = true;
            this.grTKKho.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.grTKKho.Controls.Add(this.checkAnother);
            this.grTKKho.Controls.Add(this.cbDoAn);
            this.grTKKho.Controls.Add(this.cbDoUong);
            this.grTKKho.Controls.Add(this.btnTimKiemMH);
            this.grTKKho.Controls.Add(this.lbTenMatHangTimKiem);
            this.grTKKho.Controls.Add(this.txtMatHangTimKiem);
            this.grTKKho.Location = new System.Drawing.Point(21, 7);
            this.grTKKho.Name = "grTKKho";
            this.grTKKho.Size = new System.Drawing.Size(425, 119);
            this.grTKKho.TabIndex = 16;
            this.grTKKho.Text = "TÌM KIẾM KHO HÀNG";
            // 
            // cbDoAn
            // 
            this.cbDoAn.EditValue = true;
            this.cbDoAn.Location = new System.Drawing.Point(187, 26);
            this.cbDoAn.Name = "cbDoAn";
            this.cbDoAn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoAn.Properties.Appearance.Options.UseFont = true;
            this.cbDoAn.Properties.Caption = "Đồ ăn";
            this.cbDoAn.Size = new System.Drawing.Size(75, 20);
            this.cbDoAn.TabIndex = 8;
            this.cbDoAn.CheckedChanged += new System.EventHandler(this.cbDoAn_CheckedChanged);
            // 
            // cbDoUong
            // 
            this.cbDoUong.EditValue = true;
            this.cbDoUong.Location = new System.Drawing.Point(27, 26);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoUong.Properties.Appearance.Options.UseFont = true;
            this.cbDoUong.Properties.Caption = "Đồ uống";
            this.cbDoUong.Size = new System.Drawing.Size(75, 20);
            this.cbDoUong.TabIndex = 9;
            this.cbDoUong.CheckedChanged += new System.EventHandler(this.cbDoUong_CheckedChanged);
            // 
            // btnTimKiemMH
            // 
            this.btnTimKiemMH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemMH.Appearance.Options.UseFont = true;
            this.btnTimKiemMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemMH.ImageOptions.Image = global::CoffeeManagement.Properties.Resources.logoTimKiem;
            this.btnTimKiemMH.Location = new System.Drawing.Point(307, 57);
            this.btnTimKiemMH.Name = "btnTimKiemMH";
            this.btnTimKiemMH.Size = new System.Drawing.Size(115, 45);
            this.btnTimKiemMH.TabIndex = 7;
            this.btnTimKiemMH.Text = "Tìm kiếm";
            this.btnTimKiemMH.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbTenMatHangTimKiem
            // 
            this.lbTenMatHangTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenMatHangTimKiem.Appearance.Options.UseFont = true;
            this.lbTenMatHangTimKiem.Location = new System.Drawing.Point(18, 70);
            this.lbTenMatHangTimKiem.Name = "lbTenMatHangTimKiem";
            this.lbTenMatHangTimKiem.Size = new System.Drawing.Size(62, 19);
            this.lbTenMatHangTimKiem.TabIndex = 0;
            this.lbTenMatHangTimKiem.Text = "Tên MH";
            // 
            // txtMatHangTimKiem
            // 
            this.txtMatHangTimKiem.Location = new System.Drawing.Point(104, 67);
            this.txtMatHangTimKiem.Name = "txtMatHangTimKiem";
            this.txtMatHangTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatHangTimKiem.Properties.Appearance.Options.UseFont = true;
            this.txtMatHangTimKiem.Size = new System.Drawing.Size(176, 26);
            this.txtMatHangTimKiem.TabIndex = 6;
            this.txtMatHangTimKiem.TextChanged += new System.EventHandler(this.txtMatHangTimKiem_TextChanged);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Gia";
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LoaiMatHang";
            this.Column5.HeaderText = "Loại mặt hàng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMatHang";
            this.Column2.HeaderText = "Tên Mặt Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonViTinh";
            this.Column3.HeaderText = "ĐVT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // dtgMatHangKho
            // 
            this.dtgMatHangKho.AllowUserToAddRows = false;
            this.dtgMatHangKho.AllowUserToDeleteRows = false;
            this.dtgMatHangKho.AllowUserToResizeColumns = false;
            this.dtgMatHangKho.AllowUserToResizeRows = false;
            this.dtgMatHangKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.dtgMatHangKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgMatHangKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMatHangKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dtgMatHangKho.Location = new System.Drawing.Point(21, 132);
            this.dtgMatHangKho.Name = "dtgMatHangKho";
            this.dtgMatHangKho.ReadOnly = true;
            this.dtgMatHangKho.RowHeadersVisible = false;
            this.dtgMatHangKho.RowHeadersWidth = 51;
            this.dtgMatHangKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMatHangKho.Size = new System.Drawing.Size(425, 322);
            this.dtgMatHangKho.TabIndex = 17;
            // 
            // btnXoaTV
            // 
            this.btnXoaTV.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoaTV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTV.Appearance.Options.UseBackColor = true;
            this.btnXoaTV.Appearance.Options.UseFont = true;
            this.btnXoaTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaTV.ImageOptions.Image")));
            this.btnXoaTV.Location = new System.Drawing.Point(672, 47);
            this.btnXoaTV.Name = "btnXoaTV";
            this.btnXoaTV.Size = new System.Drawing.Size(119, 45);
            this.btnXoaTV.TabIndex = 19;
            this.btnXoaTV.Text = "Xóa";
            this.btnXoaTV.Click += new System.EventHandler(this.btnXoaTV_Click);
            // 
            // btnSuaTV
            // 
            this.btnSuaTV.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSuaTV.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaTV.Appearance.Options.UseBackColor = true;
            this.btnSuaTV.Appearance.Options.UseFont = true;
            this.btnSuaTV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaTV.ImageOptions.Image")));
            this.btnSuaTV.Location = new System.Drawing.Point(513, 47);
            this.btnSuaTV.Name = "btnSuaTV";
            this.btnSuaTV.Size = new System.Drawing.Size(119, 45);
            this.btnSuaTV.TabIndex = 18;
            this.btnSuaTV.Text = "Sửa";
            this.btnSuaTV.Click += new System.EventHandler(this.btnSuaTV_Click);
            // 
            // checkAnother
            // 
            this.checkAnother.EditValue = true;
            this.checkAnother.Location = new System.Drawing.Point(323, 26);
            this.checkAnother.Name = "checkAnother";
            this.checkAnother.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAnother.Properties.Appearance.Options.UseFont = true;
            this.checkAnother.Properties.Caption = "Khác";
            this.checkAnother.Size = new System.Drawing.Size(75, 20);
            this.checkAnother.TabIndex = 10;
            this.checkAnother.CheckedChanged += new System.EventHandler(this.cbAnother_CheckedChanged);
            // 
            // frmQuanLyMatHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 460);
            this.Controls.Add(this.btnXoaTV);
            this.Controls.Add(this.grNhapKho);
            this.Controls.Add(this.grTKKho);
            this.Controls.Add(this.btnSuaTV);
            this.Controls.Add(this.dtgMatHangKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmQuanLyMatHang.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuanLyMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QUẢN LÝ MẶT HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.grNhapKho)).EndInit();
            this.grNhapKho.ResumeLayout(false);
            this.grNhapKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLoaiMH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grTKKho)).EndInit();
            this.grTKKho.ResumeLayout(false);
            this.grTKKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDoAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDoUong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatHangTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMatHangKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnother.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoaTV;
        private DevExpress.XtraEditors.SimpleButton btnDK;
        private DevExpress.XtraEditors.GroupControl grNhapKho;
        private DevExpress.XtraEditors.ComboBoxEdit cbDVT;
        private DevExpress.XtraEditors.LabelControl lbDVT;
        private DevExpress.XtraEditors.ComboBoxEdit cbLoaiMH;
        private DevExpress.XtraEditors.LabelControl lbLoaiMH;
        private DevExpress.XtraEditors.TextEdit txtDonGiaKho;
        private DevExpress.XtraEditors.TextEdit txtTenMatHang;
        private DevExpress.XtraEditors.LabelControl lbĐonGiaKho;
        private DevExpress.XtraEditors.LabelControl lbMatHangKho;
        private DevExpress.XtraEditors.SimpleButton btnTimKiemMH;
        private DevExpress.XtraEditors.GroupControl grTKKho;
        private DevExpress.XtraEditors.CheckEdit cbDoAn;
        private DevExpress.XtraEditors.CheckEdit cbDoUong;
        private DevExpress.XtraEditors.LabelControl lbTenMatHangTimKiem;
        private DevExpress.XtraEditors.TextEdit txtMatHangTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevExpress.XtraEditors.SimpleButton btnSuaTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dtgMatHangKho;
        private DevExpress.XtraEditors.CheckEdit checkAnother;
    }
}