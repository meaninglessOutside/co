namespace CoffeeManagement
{
    partial class frmThanhToan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoaiThanhVien = new DevExpress.XtraEditors.TextEdit();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgThanhToan = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiamGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbIDTV = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiThanhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamGia.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongTien";
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenMatHang";
            this.Column2.HeaderText = "Mặt hàng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 137;
            // 
            // txtLoaiThanhVien
            // 
            this.txtLoaiThanhVien.Location = new System.Drawing.Point(180, 98);
            this.txtLoaiThanhVien.Name = "txtLoaiThanhVien";
            this.txtLoaiThanhVien.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtLoaiThanhVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiThanhVien.Properties.Appearance.Options.UseBackColor = true;
            this.txtLoaiThanhVien.Properties.Appearance.Options.UseFont = true;
            this.txtLoaiThanhVien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtLoaiThanhVien.Properties.ReadOnly = true;
            this.txtLoaiThanhVien.Size = new System.Drawing.Size(115, 24);
            this.txtLoaiThanhVien.TabIndex = 34;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThanhToan.Appearance.BackColor2 = System.Drawing.Color.Navy;
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Appearance.Options.UseBackColor = true;
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Appearance.Options.UseForeColor = true;
            this.btnThanhToan.AppearanceHovered.BackColor = System.Drawing.Color.GreenYellow;
            this.btnThanhToan.AppearanceHovered.BackColor2 = System.Drawing.Color.Green;
            this.btnThanhToan.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.AppearanceHovered.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnThanhToan.AppearanceHovered.Options.UseBackColor = true;
            this.btnThanhToan.AppearanceHovered.Options.UseForeColor = true;
            this.btnThanhToan.AppearancePressed.BackColor = System.Drawing.Color.Green;
            this.btnThanhToan.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.AppearancePressed.Options.UseBackColor = true;
            this.btnThanhToan.AppearancePressed.Options.UseForeColor = true;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Location = new System.Drawing.Point(62, 267);
            this.btnThanhToan.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnThanhToan.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(287, 44);
            this.btnThanhToan.TabIndex = 32;
            this.btnThanhToan.Text = "Thanh toán - Xuất hoá đơn";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(131, 17);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseBackColor = true;
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtTongTien.Properties.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(218, 24);
            this.txtTongTien.TabIndex = 31;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 19);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Tổng tiền:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(131, 200);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Properties.Appearance.Options.UseBackColor = true;
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtThanhTien.Properties.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(218, 24);
            this.txtThanhTien.TabIndex = 29;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(3, 199);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 19);
            this.labelControl2.TabIndex = 28;
            this.labelControl2.Text = "Thành tiền:";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // dtgThanhToan
            // 
            this.dtgThanhToan.AllowUserToAddRows = false;
            this.dtgThanhToan.AllowUserToDeleteRows = false;
            this.dtgThanhToan.AllowUserToResizeRows = false;
            this.dtgThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgThanhToan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dtgThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgThanhToan.Location = new System.Drawing.Point(9, 21);
            this.dtgThanhToan.Margin = new System.Windows.Forms.Padding(0);
            this.dtgThanhToan.Name = "dtgThanhToan";
            this.dtgThanhToan.RowHeadersVisible = false;
            this.dtgThanhToan.ShowEditingIcon = false;
            this.dtgThanhToan.Size = new System.Drawing.Size(345, 332);
            this.dtgThanhToan.TabIndex = 41;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SL";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 50;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(131, 147);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.txtGiamGia.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Properties.Appearance.Options.UseBackColor = true;
            this.txtGiamGia.Properties.Appearance.Options.UseFont = true;
            this.txtGiamGia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtGiamGia.Properties.ReadOnly = true;
            this.txtGiamGia.Size = new System.Drawing.Size(218, 24);
            this.txtGiamGia.TabIndex = 27;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(3, 146);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 19);
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "Giảm giá:";
            // 
            // lbIDTV
            // 
            this.lbIDTV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDTV.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lbIDTV.Appearance.Options.UseFont = true;
            this.lbIDTV.Appearance.Options.UseForeColor = true;
            this.lbIDTV.Location = new System.Drawing.Point(3, 73);
            this.lbIDTV.Name = "lbIDTV";
            this.lbIDTV.Size = new System.Drawing.Size(96, 19);
            this.lbIDTV.TabIndex = 24;
            this.lbIDTV.Text = "Thành viên:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtLoaiThanhVien);
            this.panel2.Controls.Add(this.btnThanhToan);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.labelControl3);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.labelControl1);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.lbIDTV);
            this.panel2.Location = new System.Drawing.Point(354, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 350);
            this.panel2.TabIndex = 40;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(131, 68);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(130)))), ((int)(((byte)(66)))));
            this.txtSDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Properties.Appearance.Options.UseBackColor = true;
            this.txtSDT.Properties.Appearance.Options.UseFont = true;
            this.txtSDT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtSDT.Size = new System.Drawing.Size(218, 24);
            this.txtSDT.TabIndex = 25;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // frmThanhToan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(729, 357);
            this.Controls.Add(this.dtgThanhToan);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiThanhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamGia.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private DevExpress.XtraEditors.TextEdit txtLoaiThanhVien;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dtgThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevExpress.XtraEditors.TextEdit txtGiamGia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbIDTV;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}