namespace WindowsFormsApp1.NhapHang
{
    partial class ThemPhieuNhapGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grid_CTPhieuNhap = new System.Windows.Forms.DataGridView();
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.CotmaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CottenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotgiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotsoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotimg = new System.Windows.Forms.DataGridViewImageColumn();
            this.CotthoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CottinhTrang = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CotmaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.tb_MaNhanVien = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotxoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.grid_CTPhieuNhap, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grid_SanPham, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 49);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 651);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // grid_CTPhieuNhap
            // 
            this.grid_CTPhieuNhap.AllowUserToAddRows = false;
            this.grid_CTPhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_CTPhieuNhap.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_CTPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.grid_CTPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CTPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Cotxoa});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_CTPhieuNhap.DefaultCellStyle = dataGridViewCellStyle18;
            this.grid_CTPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_CTPhieuNhap.Location = new System.Drawing.Point(6, 164);
            this.grid_CTPhieuNhap.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.grid_CTPhieuNhap.Name = "grid_CTPhieuNhap";
            this.grid_CTPhieuNhap.RowHeadersVisible = false;
            this.grid_CTPhieuNhap.RowHeadersWidth = 51;
            this.grid_CTPhieuNhap.RowTemplate.Height = 24;
            this.grid_CTPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_CTPhieuNhap.Size = new System.Drawing.Size(709, 416);
            this.grid_CTPhieuNhap.TabIndex = 2;
            this.grid_CTPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CTPhieuNhap_CellClick);
            this.grid_CTPhieuNhap.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CTPhieuNhap_CellValueChanged);
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.AllowUserToAddRows = false;
            this.grid_SanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CotmaSP,
            this.CottenSP,
            this.CotgiaBan,
            this.CotsoLuong,
            this.Cotimg,
            this.CotthoiGian,
            this.CottinhTrang,
            this.CotmaLoai});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_SanPham.DefaultCellStyle = dataGridViewCellStyle20;
            this.grid_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_SanPham.Location = new System.Drawing.Point(721, 0);
            this.grid_SanPham.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.ReadOnly = true;
            this.grid_SanPham.RowHeadersVisible = false;
            this.grid_SanPham.RowHeadersWidth = 51;
            this.tableLayoutPanel2.SetRowSpan(this.grid_SanPham, 2);
            this.grid_SanPham.RowTemplate.Height = 24;
            this.grid_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SanPham.Size = new System.Drawing.Size(473, 580);
            this.grid_SanPham.TabIndex = 3;
            this.grid_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SanPham_CellClick);
            // 
            // CotmaSP
            // 
            this.CotmaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CotmaSP.DataPropertyName = "maSP";
            this.CotmaSP.HeaderText = "Mã sản phẩm";
            this.CotmaSP.MinimumWidth = 6;
            this.CotmaSP.Name = "CotmaSP";
            this.CotmaSP.ReadOnly = true;
            this.CotmaSP.Width = 146;
            // 
            // CottenSP
            // 
            this.CottenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CottenSP.DataPropertyName = "tenSP";
            this.CottenSP.HeaderText = "Tên sản phẩm";
            this.CottenSP.MinimumWidth = 6;
            this.CottenSP.Name = "CottenSP";
            this.CottenSP.ReadOnly = true;
            this.CottenSP.Width = 153;
            // 
            // CotgiaBan
            // 
            this.CotgiaBan.DataPropertyName = "giaBan";
            this.CotgiaBan.HeaderText = "Giá bán";
            this.CotgiaBan.MinimumWidth = 6;
            this.CotgiaBan.Name = "CotgiaBan";
            this.CotgiaBan.ReadOnly = true;
            this.CotgiaBan.Visible = false;
            this.CotgiaBan.Width = 125;
            // 
            // CotsoLuong
            // 
            this.CotsoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CotsoLuong.DataPropertyName = "soLuong";
            this.CotsoLuong.HeaderText = "Số lượng hiện tại";
            this.CotsoLuong.MinimumWidth = 6;
            this.CotsoLuong.Name = "CotsoLuong";
            this.CotsoLuong.ReadOnly = true;
            this.CotsoLuong.Width = 152;
            // 
            // Cotimg
            // 
            this.Cotimg.DataPropertyName = "img";
            this.Cotimg.HeaderText = "Hình ảnh";
            this.Cotimg.MinimumWidth = 6;
            this.Cotimg.Name = "Cotimg";
            this.Cotimg.ReadOnly = true;
            this.Cotimg.Visible = false;
            this.Cotimg.Width = 125;
            // 
            // CotthoiGian
            // 
            this.CotthoiGian.DataPropertyName = "thoiGian";
            this.CotthoiGian.HeaderText = "Thời hạn bảo hành";
            this.CotthoiGian.MinimumWidth = 6;
            this.CotthoiGian.Name = "CotthoiGian";
            this.CotthoiGian.ReadOnly = true;
            this.CotthoiGian.Visible = false;
            this.CotthoiGian.Width = 125;
            // 
            // CottinhTrang
            // 
            this.CottinhTrang.DataPropertyName = "tinhTrang";
            this.CottinhTrang.HeaderText = "Tình Trạng";
            this.CottinhTrang.MinimumWidth = 6;
            this.CottinhTrang.Name = "CottinhTrang";
            this.CottinhTrang.ReadOnly = true;
            this.CottinhTrang.Visible = false;
            this.CottinhTrang.Width = 125;
            // 
            // CotmaLoai
            // 
            this.CotmaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CotmaLoai.DataPropertyName = "maLoai";
            this.CotmaLoai.HeaderText = "Mã loại";
            this.CotmaLoai.MinimumWidth = 6;
            this.CotmaLoai.Name = "CotmaLoai";
            this.CotmaLoai.ReadOnly = true;
            this.CotmaLoai.Width = 96;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Azure;
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label5, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_MaPhieuNhap, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dtp_NgayLap, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbb_NCC, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tb_MaNhanVien, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(709, 158);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày lập";
            // 
            // tb_MaPhieuNhap
            // 
            this.tb_MaPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaPhieuNhap.Enabled = false;
            this.tb_MaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaPhieuNhap.Location = new System.Drawing.Point(170, 22);
            this.tb_MaPhieuNhap.Margin = new System.Windows.Forms.Padding(0);
            this.tb_MaPhieuNhap.Name = "tb_MaPhieuNhap";
            this.tb_MaPhieuNhap.Size = new System.Drawing.Size(148, 34);
            this.tb_MaPhieuNhap.TabIndex = 2;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_NgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Enabled = false;
            this.dtp_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(508, 101);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(0);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(151, 34);
            this.dtp_NgayLap.TabIndex = 5;
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(170, 100);
            this.cbb_NCC.Margin = new System.Windows.Forms.Padding(0);
            this.cbb_NCC.MaxDropDownItems = 20;
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(148, 37);
            this.cbb_NCC.TabIndex = 4;
            // 
            // tb_MaNhanVien
            // 
            this.tb_MaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaNhanVien.Enabled = false;
            this.tb_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNhanVien.Location = new System.Drawing.Point(508, 22);
            this.tb_MaNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.tb_MaNhanVien.Name = "tb_MaNhanVien";
            this.tb_MaNhanVien.Size = new System.Drawing.Size(163, 34);
            this.tb_MaNhanVien.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Tao, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(718, 580);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(476, 65);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btn_Tao
            // 
            this.btn_Tao.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Tao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Tao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tao.Location = new System.Drawing.Point(312, 3);
            this.btn_Tao.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(164, 62);
            this.btn_Tao.TabIndex = 1;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = false;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(302, 62);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng số tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(483, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tạo Phiếu Nhập";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "maPN";
            this.Column1.FillWeight = 75F;
            this.Column1.HeaderText = "Mã phiếu nhập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "maSP";
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "giaNhap";
            this.Column3.HeaderText = "Giá nhập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "soLuong";
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "tinhTrang";
            this.Column5.FillWeight = 50F;
            this.Column5.HeaderText = "Tình trạng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // Cotxoa
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cotxoa.DefaultCellStyle = dataGridViewCellStyle17;
            this.Cotxoa.HeaderText = "";
            this.Cotxoa.MinimumWidth = 6;
            this.Cotxoa.Name = "Cotxoa";
            this.Cotxoa.Text = "Xóa";
            this.Cotxoa.UseColumnTextForButtonValue = true;
            this.Cotxoa.Width = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "VND";
            // 
            // ThemPhieuNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThemPhieuNhapGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemPhieuNhapGUI";
            this.Load += new System.EventHandler(this.ThemPhieuNhapGUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView grid_CTPhieuNhap;
        private System.Windows.Forms.DataGridView grid_SanPham;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_MaPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CottenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotgiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotsoLuong;
        private System.Windows.Forms.DataGridViewImageColumn Cotimg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotthoiGian;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CottinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Cotxoa;
        private System.Windows.Forms.Label label7;
    }
}