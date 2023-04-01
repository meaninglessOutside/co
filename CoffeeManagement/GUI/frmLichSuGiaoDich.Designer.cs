namespace CoffeeManagement
{
    partial class frmLichSuGiaoDich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLichSuGiaoDich));
            this.contextMenuHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.tbTTTo = new System.Windows.Forms.TextBox();
            this.cbNgayGD = new System.Windows.Forms.CheckBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.cbTT = new System.Windows.Forms.CheckBox();
            this.lbKhongCoGDNao = new System.Windows.Forms.Label();
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelThang = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNam1 = new System.Windows.Forms.ComboBox();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.tbHoTen = new System.Windows.Forms.TextBox();
            this.panelNam = new System.Windows.Forms.Panel();
            this.cbNam2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelNangCao = new System.Windows.Forms.Panel();
            this.tbTTFrom = new System.Windows.Forms.TextBox();
            this.panelNgay = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.panelTuan = new System.Windows.Forms.Panel();
            this.dtpTuan = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.panelThang.SuspendLayout();
            this.panelNam.SuspendLayout();
            this.panelNangCao.SuspendLayout();
            this.panelNgay.SuspendLayout();
            this.panelTuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuHoaDon
            // 
            this.contextMenuHoaDon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem,
            this.xuấtHóaĐơnToolStripMenuItem});
            this.contextMenuHoaDon.Name = "contextMenuHoaDon";
            this.contextMenuHoaDon.Size = new System.Drawing.Size(172, 56);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Image = global::CoffeeManagement.Properties.Resources.detail;
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // xuấtHóaĐơnToolStripMenuItem
            // 
            this.xuấtHóaĐơnToolStripMenuItem.Image = global::CoffeeManagement.Properties.Resources.exportFile;
            this.xuấtHóaĐơnToolStripMenuItem.Name = "xuấtHóaĐơnToolStripMenuItem";
            this.xuấtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.xuấtHóaĐơnToolStripMenuItem.Text = "Xuất hóa đơn";
            this.xuấtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xuấtHóaĐơnToolStripMenuItem_Click);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(119, 4);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(104, 23);
            this.dtpDateFrom.TabIndex = 22;
            this.dtpDateFrom.ValueChanged += new System.EventHandler(this.dtpDateFrom_ValueChanged);
            // 
            // tbTTTo
            // 
            this.tbTTTo.Location = new System.Drawing.Point(622, 4);
            this.tbTTTo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTTTo.Name = "tbTTTo";
            this.tbTTTo.Size = new System.Drawing.Size(104, 23);
            this.tbTTTo.TabIndex = 26;
            this.tbTTTo.Text = "0";
            this.tbTTTo.TextChanged += new System.EventHandler(this.tbTTTo_TextChanged);
            // 
            // cbNgayGD
            // 
            this.cbNgayGD.AutoSize = true;
            this.cbNgayGD.Location = new System.Drawing.Point(4, 5);
            this.cbNgayGD.Margin = new System.Windows.Forms.Padding(4);
            this.cbNgayGD.Name = "cbNgayGD";
            this.cbNgayGD.Size = new System.Drawing.Size(112, 20);
            this.cbNgayGD.TabIndex = 20;
            this.cbNgayGD.Text = "Ngày giao dịch";
            this.cbNgayGD.UseVisualStyleBackColor = true;
            this.cbNgayGD.CheckedChanged += new System.EventHandler(this.cbNgayGD_CheckedChanged);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(229, 4);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(104, 23);
            this.dtpDateTo.TabIndex = 25;
            this.dtpDateTo.ValueChanged += new System.EventHandler(this.dtpDateTo_ValueChanged);
            // 
            // cbTT
            // 
            this.cbTT.AutoSize = true;
            this.cbTT.Location = new System.Drawing.Point(397, 5);
            this.cbTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbTT.Name = "cbTT";
            this.cbTT.Size = new System.Drawing.Size(83, 20);
            this.cbTT.TabIndex = 21;
            this.cbTT.Text = "Tổng tiền";
            this.cbTT.UseVisualStyleBackColor = true;
            this.cbTT.CheckedChanged += new System.EventHandler(this.cbTT_CheckedChanged);
            // 
            // lbKhongCoGDNao
            // 
            this.lbKhongCoGDNao.AutoSize = true;
            this.lbKhongCoGDNao.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKhongCoGDNao.Location = new System.Drawing.Point(877, 111);
            this.lbKhongCoGDNao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhongCoGDNao.Name = "lbKhongCoGDNao";
            this.lbKhongCoGDNao.Size = new System.Drawing.Size(206, 24);
            this.lbKhongCoGDNao.TabIndex = 45;
            this.lbKhongCoGDNao.Text = "DONT TOUCH THIS!";
            // 
            // dtgHoaDon
            // 
            this.dtgHoaDon.AllowUserToAddRows = false;
            this.dtgHoaDon.AllowUserToDeleteRows = false;
            this.dtgHoaDon.AllowUserToResizeColumns = false;
            this.dtgHoaDon.AllowUserToResizeRows = false;
            this.dtgHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgHoaDon.Location = new System.Drawing.Point(27, 132);
            this.dtgHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.ReadOnly = true;
            this.dtgHoaDon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgHoaDon.RowHeadersVisible = false;
            this.dtgHoaDon.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(126)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgHoaDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoaDon.Size = new System.Drawing.Size(1070, 521);
            this.dtgHoaDon.TabIndex = 44;
            this.dtgHoaDon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtgHoaDon_MouseDown);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayThanhToan";
            this.Column2.HeaderText = "Ngày thanh toán";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GiamGia";
            this.Column3.HeaderText = "Giảm giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "IDBan";
            this.Column4.HeaderText = "Bàn";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IDThanhVien";
            this.Column5.HeaderText = "Mã thành viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "HoTen";
            this.Column9.HeaderText = "Tên thành viên";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TrangThai";
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TongTien";
            this.Column7.HeaderText = "Tổng tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ThanhTien";
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // cbViewMode
            // 
            this.cbViewMode.FormattingEnabled = true;
            this.cbViewMode.Items.AddRange(new object[] {
            "Ngày",
            "Tuần",
            "Tháng",
            "Năm",
            "Nâng cao",
            "Tất cả"});
            this.cbViewMode.Location = new System.Drawing.Point(118, 30);
            this.cbViewMode.Margin = new System.Windows.Forms.Padding(4);
            this.cbViewMode.Name = "cbViewMode";
            this.cbViewMode.Size = new System.Drawing.Size(83, 24);
            this.cbViewMode.TabIndex = 31;
            this.cbViewMode.Text = "Ngày";
            this.cbViewMode.TextChanged += new System.EventHandler(this.cbViewMode_TextChanged);
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.gbFilter.Controls.Add(this.button1);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.cbViewMode);
            this.gbFilter.Controls.Add(this.label6);
            this.gbFilter.Controls.Add(this.panelThang);
            this.gbFilter.Controls.Add(this.tbHoTen);
            this.gbFilter.Controls.Add(this.panelNam);
            this.gbFilter.Controls.Add(this.panelNangCao);
            this.gbFilter.Controls.Add(this.panelNgay);
            this.gbFilter.Controls.Add(this.panelTuan);
            this.gbFilter.ForeColor = System.Drawing.Color.Black;
            this.gbFilter.Location = new System.Drawing.Point(27, 7);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(0);
            this.gbFilter.Size = new System.Drawing.Size(1088, 103);
            this.gbFilter.TabIndex = 46;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc và tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Xem theo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 21);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tìm kiếm theo thành viên";
            // 
            // panelThang
            // 
            this.panelThang.Controls.Add(this.label4);
            this.panelThang.Controls.Add(this.cbNam1);
            this.panelThang.Controls.Add(this.cbThang);
            this.panelThang.Location = new System.Drawing.Point(245, 30);
            this.panelThang.Margin = new System.Windows.Forms.Padding(4);
            this.panelThang.Name = "panelThang";
            this.panelThang.Size = new System.Drawing.Size(348, 31);
            this.panelThang.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chọn tháng";
            // 
            // cbNam1
            // 
            this.cbNam1.FormattingEnabled = true;
            this.cbNam1.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbNam1.Location = new System.Drawing.Point(145, 0);
            this.cbNam1.Margin = new System.Windows.Forms.Padding(4);
            this.cbNam1.Name = "cbNam1";
            this.cbNam1.Size = new System.Drawing.Size(79, 24);
            this.cbNam1.TabIndex = 8;
            this.cbNam1.Text = "2023";
            this.cbNam1.TextChanged += new System.EventHandler(this.cbNam1_TextChanged);
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(79, 0);
            this.cbThang.Margin = new System.Windows.Forms.Padding(4);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(53, 24);
            this.cbThang.TabIndex = 9;
            this.cbThang.Text = "12";
            this.cbThang.TextChanged += new System.EventHandler(this.cbThang_TextChanged);
            // 
            // tbHoTen
            // 
            this.tbHoTen.Location = new System.Drawing.Point(245, 69);
            this.tbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.tbHoTen.Name = "tbHoTen";
            this.tbHoTen.Size = new System.Drawing.Size(237, 23);
            this.tbHoTen.TabIndex = 38;
            this.tbHoTen.TextChanged += new System.EventHandler(this.tbHoTen_TextChanged);
            this.tbHoTen.Enter += new System.EventHandler(this.tbHoTen_Enter);
            // 
            // panelNam
            // 
            this.panelNam.Controls.Add(this.cbNam2);
            this.panelNam.Controls.Add(this.label5);
            this.panelNam.Location = new System.Drawing.Point(245, 30);
            this.panelNam.Margin = new System.Windows.Forms.Padding(4);
            this.panelNam.Name = "panelNam";
            this.panelNam.Size = new System.Drawing.Size(348, 31);
            this.panelNam.TabIndex = 34;
            // 
            // cbNam2
            // 
            this.cbNam2.FormattingEnabled = true;
            this.cbNam2.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cbNam2.Location = new System.Drawing.Point(79, 0);
            this.cbNam2.Margin = new System.Windows.Forms.Padding(4);
            this.cbNam2.Name = "cbNam2";
            this.cbNam2.Size = new System.Drawing.Size(104, 24);
            this.cbNam2.TabIndex = 3;
            this.cbNam2.Text = "2023";
            this.cbNam2.TextChanged += new System.EventHandler(this.cbNam2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chọn năm";
            // 
            // panelNangCao
            // 
            this.panelNangCao.Controls.Add(this.dtpDateFrom);
            this.panelNangCao.Controls.Add(this.tbTTTo);
            this.panelNangCao.Controls.Add(this.cbNgayGD);
            this.panelNangCao.Controls.Add(this.dtpDateTo);
            this.panelNangCao.Controls.Add(this.cbTT);
            this.panelNangCao.Controls.Add(this.tbTTFrom);
            this.panelNangCao.Location = new System.Drawing.Point(245, 30);
            this.panelNangCao.Margin = new System.Windows.Forms.Padding(4);
            this.panelNangCao.Name = "panelNangCao";
            this.panelNangCao.Size = new System.Drawing.Size(744, 31);
            this.panelNangCao.TabIndex = 40;
            // 
            // tbTTFrom
            // 
            this.tbTTFrom.Location = new System.Drawing.Point(510, 4);
            this.tbTTFrom.Margin = new System.Windows.Forms.Padding(4);
            this.tbTTFrom.Name = "tbTTFrom";
            this.tbTTFrom.Size = new System.Drawing.Size(104, 23);
            this.tbTTFrom.TabIndex = 24;
            this.tbTTFrom.Text = "0";
            this.tbTTFrom.TextChanged += new System.EventHandler(this.tbTTFrom_TextChanged);
            // 
            // panelNgay
            // 
            this.panelNgay.Controls.Add(this.label2);
            this.panelNgay.Controls.Add(this.dtpNgay);
            this.panelNgay.Location = new System.Drawing.Point(245, 30);
            this.panelNgay.Margin = new System.Windows.Forms.Padding(4);
            this.panelNgay.Name = "panelNgay";
            this.panelNgay.Size = new System.Drawing.Size(348, 30);
            this.panelNgay.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn ngày";
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(79, 0);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(104, 23);
            this.dtpNgay.TabIndex = 10;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.dtpNgay_ValueChanged);
            // 
            // panelTuan
            // 
            this.panelTuan.Controls.Add(this.dtpTuan);
            this.panelTuan.Controls.Add(this.label3);
            this.panelTuan.Location = new System.Drawing.Point(245, 30);
            this.panelTuan.Margin = new System.Windows.Forms.Padding(4);
            this.panelTuan.Name = "panelTuan";
            this.panelTuan.Size = new System.Drawing.Size(348, 31);
            this.panelTuan.TabIndex = 35;
            // 
            // dtpTuan
            // 
            this.dtpTuan.CustomFormat = "dd/MM/yyyy";
            this.dtpTuan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuan.Location = new System.Drawing.Point(79, 0);
            this.dtpTuan.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTuan.Name = "dtpTuan";
            this.dtpTuan.Size = new System.Drawing.Size(104, 23);
            this.dtpTuan.TabIndex = 11;
            this.dtpTuan.ValueChanged += new System.EventHandler(this.dtpTuan_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn tuần";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(996, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 41;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLichSuGiaoDich
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 661);
            this.Controls.Add(this.lbKhongCoGDNao);
            this.Controls.Add(this.dtgHoaDon);
            this.Controls.Add(this.gbFilter);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmLichSuGiaoDich.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLichSuGiaoDich";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BÁO CÁO DOANH THU THEO THỜI GIAN";
            this.contextMenuHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.panelThang.ResumeLayout(false);
            this.panelThang.PerformLayout();
            this.panelNam.ResumeLayout(false);
            this.panelNam.PerformLayout();
            this.panelNangCao.ResumeLayout(false);
            this.panelNangCao.PerformLayout();
            this.panelNgay.ResumeLayout(false);
            this.panelNgay.PerformLayout();
            this.panelTuan.ResumeLayout(false);
            this.panelTuan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.TextBox tbTTTo;
        private System.Windows.Forms.CheckBox cbNgayGD;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.CheckBox cbTT;
        private System.Windows.Forms.Label lbKhongCoGDNao;
        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox cbViewMode;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNam1;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.TextBox tbHoTen;
        private System.Windows.Forms.Panel panelNam;
        private System.Windows.Forms.ComboBox cbNam2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelNangCao;
        private System.Windows.Forms.TextBox tbTTFrom;
        private System.Windows.Forms.Panel panelNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Panel panelTuan;
        private System.Windows.Forms.DateTimePicker dtpTuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}