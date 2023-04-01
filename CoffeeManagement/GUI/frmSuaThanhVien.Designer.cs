namespace CoffeeManagement
{
    partial class frmSuaThanhVien
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
            this.lbIDTV = new DevExpress.XtraEditors.LabelControl();
            this.lbHoTenTV = new DevExpress.XtraEditors.LabelControl();
            this.lbSDTTV = new DevExpress.XtraEditors.LabelControl();
            this.lbHangTV = new DevExpress.XtraEditors.LabelControl();
            this.lbDiemTichLuy = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayDK = new DevExpress.XtraEditors.LabelControl();
            this.txtSuaID = new DevExpress.XtraEditors.TextEdit();
            this.txtSuaHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSuaSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtSuaHangTV = new DevExpress.XtraEditors.TextEdit();
            this.txtSuaDiem = new DevExpress.XtraEditors.TextEdit();
            this.dateSuaNgayDK = new DevExpress.XtraEditors.DateEdit();
            this.btnSuaThanhVien = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaHangTV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaDiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuaNgayDK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuaNgayDK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIDTV
            // 
            this.lbIDTV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTV.Appearance.Options.UseFont = true;
            this.lbIDTV.Location = new System.Drawing.Point(34, 32);
            this.lbIDTV.Name = "lbIDTV";
            this.lbIDTV.Size = new System.Drawing.Size(114, 19);
            this.lbIDTV.TabIndex = 0;
            this.lbIDTV.Text = "ID Thành viên";
            // 
            // lbHoTenTV
            // 
            this.lbHoTenTV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTenTV.Appearance.Options.UseFont = true;
            this.lbHoTenTV.Location = new System.Drawing.Point(34, 85);
            this.lbHoTenTV.Name = "lbHoTenTV";
            this.lbHoTenTV.Size = new System.Drawing.Size(54, 19);
            this.lbHoTenTV.TabIndex = 0;
            this.lbHoTenTV.Text = "Họ tên";
            // 
            // lbSDTTV
            // 
            this.lbSDTTV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDTTV.Appearance.Options.UseFont = true;
            this.lbSDTTV.Location = new System.Drawing.Point(34, 135);
            this.lbSDTTV.Name = "lbSDTTV";
            this.lbSDTTV.Size = new System.Drawing.Size(48, 19);
            this.lbSDTTV.TabIndex = 0;
            this.lbSDTTV.Text = "Số ĐT";
            // 
            // lbHangTV
            // 
            this.lbHangTV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHangTV.Appearance.Options.UseFont = true;
            this.lbHangTV.Location = new System.Drawing.Point(34, 184);
            this.lbHangTV.Name = "lbHangTV";
            this.lbHangTV.Size = new System.Drawing.Size(69, 19);
            this.lbHangTV.TabIndex = 0;
            this.lbHangTV.Text = "Hạng TV";
            // 
            // lbDiemTichLuy
            // 
            this.lbDiemTichLuy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiemTichLuy.Appearance.Options.UseFont = true;
            this.lbDiemTichLuy.Location = new System.Drawing.Point(34, 275);
            this.lbDiemTichLuy.Name = "lbDiemTichLuy";
            this.lbDiemTichLuy.Size = new System.Drawing.Size(106, 19);
            this.lbDiemTichLuy.TabIndex = 0;
            this.lbDiemTichLuy.Text = "Điểm tích lũy";
            // 
            // lbNgayDK
            // 
            this.lbNgayDK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDK.Appearance.Options.UseFont = true;
            this.lbNgayDK.Location = new System.Drawing.Point(34, 228);
            this.lbNgayDK.Name = "lbNgayDK";
            this.lbNgayDK.Size = new System.Drawing.Size(110, 19);
            this.lbNgayDK.TabIndex = 0;
            this.lbNgayDK.Text = "Ngày đăng ký";
            // 
            // txtSuaID
            // 
            this.txtSuaID.Enabled = false;
            this.txtSuaID.Location = new System.Drawing.Point(186, 27);
            this.txtSuaID.Name = "txtSuaID";
            this.txtSuaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaID.Properties.Appearance.Options.UseFont = true;
            this.txtSuaID.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSuaID.Size = new System.Drawing.Size(201, 24);
            this.txtSuaID.TabIndex = 1;
            // 
            // txtSuaHoTen
            // 
            this.txtSuaHoTen.Location = new System.Drawing.Point(186, 80);
            this.txtSuaHoTen.Name = "txtSuaHoTen";
            this.txtSuaHoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaHoTen.Properties.Appearance.Options.UseFont = true;
            this.txtSuaHoTen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSuaHoTen.Size = new System.Drawing.Size(201, 24);
            this.txtSuaHoTen.TabIndex = 2;
            // 
            // txtSuaSDT
            // 
            this.txtSuaSDT.Location = new System.Drawing.Point(186, 130);
            this.txtSuaSDT.Name = "txtSuaSDT";
            this.txtSuaSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSuaSDT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSuaSDT.Size = new System.Drawing.Size(201, 24);
            this.txtSuaSDT.TabIndex = 3;
            // 
            // txtSuaHangTV
            // 
            this.txtSuaHangTV.Enabled = false;
            this.txtSuaHangTV.Location = new System.Drawing.Point(186, 179);
            this.txtSuaHangTV.Name = "txtSuaHangTV";
            this.txtSuaHangTV.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaHangTV.Properties.Appearance.Options.UseFont = true;
            this.txtSuaHangTV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSuaHangTV.Size = new System.Drawing.Size(201, 24);
            this.txtSuaHangTV.TabIndex = 4;
            // 
            // txtSuaDiem
            // 
            this.txtSuaDiem.Enabled = false;
            this.txtSuaDiem.Location = new System.Drawing.Point(186, 270);
            this.txtSuaDiem.Name = "txtSuaDiem";
            this.txtSuaDiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuaDiem.Properties.Appearance.Options.UseFont = true;
            this.txtSuaDiem.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSuaDiem.Size = new System.Drawing.Size(201, 24);
            this.txtSuaDiem.TabIndex = 6;
            // 
            // dateSuaNgayDK
            // 
            this.dateSuaNgayDK.EditValue = null;
            this.dateSuaNgayDK.Enabled = false;
            this.dateSuaNgayDK.Location = new System.Drawing.Point(186, 223);
            this.dateSuaNgayDK.Name = "dateSuaNgayDK";
            this.dateSuaNgayDK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSuaNgayDK.Properties.Appearance.Options.UseFont = true;
            this.dateSuaNgayDK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.dateSuaNgayDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSuaNgayDK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateSuaNgayDK.Size = new System.Drawing.Size(201, 24);
            this.dateSuaNgayDK.TabIndex = 5;
            // 
            // btnSuaThanhVien
            // 
            this.btnSuaThanhVien.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            this.btnSuaThanhVien.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThanhVien.Appearance.Options.UseBackColor = true;
            this.btnSuaThanhVien.Appearance.Options.UseFont = true;
            this.btnSuaThanhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaThanhVien.Location = new System.Drawing.Point(186, 323);
            this.btnSuaThanhVien.Name = "btnSuaThanhVien";
            this.btnSuaThanhVien.Size = new System.Drawing.Size(121, 44);
            this.btnSuaThanhVien.TabIndex = 7;
            this.btnSuaThanhVien.Text = "Cập nhật";
            this.btnSuaThanhVien.Click += new System.EventHandler(this.btnSuaThanhVien_Click);
            // 
            // frmSuaThanhVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 379);
            this.Controls.Add(this.btnSuaThanhVien);
            this.Controls.Add(this.dateSuaNgayDK);
            this.Controls.Add(this.txtSuaDiem);
            this.Controls.Add(this.txtSuaHangTV);
            this.Controls.Add(this.txtSuaSDT);
            this.Controls.Add(this.txtSuaHoTen);
            this.Controls.Add(this.txtSuaID);
            this.Controls.Add(this.lbDiemTichLuy);
            this.Controls.Add(this.lbNgayDK);
            this.Controls.Add(this.lbHangTV);
            this.Controls.Add(this.lbSDTTV);
            this.Controls.Add(this.lbHoTenTV);
            this.Controls.Add(this.lbIDTV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaThanhVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.frmSuaThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaHangTV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuaDiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuaNgayDK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSuaNgayDK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbIDTV;
        private DevExpress.XtraEditors.LabelControl lbHoTenTV;
        private DevExpress.XtraEditors.LabelControl lbSDTTV;
        private DevExpress.XtraEditors.LabelControl lbHangTV;
        private DevExpress.XtraEditors.LabelControl lbDiemTichLuy;
        private DevExpress.XtraEditors.LabelControl lbNgayDK;
        private DevExpress.XtraEditors.TextEdit txtSuaID;
        private DevExpress.XtraEditors.TextEdit txtSuaHoTen;
        private DevExpress.XtraEditors.TextEdit txtSuaSDT;
        private DevExpress.XtraEditors.TextEdit txtSuaHangTV;
        private DevExpress.XtraEditors.TextEdit txtSuaDiem;
        private DevExpress.XtraEditors.DateEdit dateSuaNgayDK;
        private DevExpress.XtraEditors.SimpleButton btnSuaThanhVien;
    }
}