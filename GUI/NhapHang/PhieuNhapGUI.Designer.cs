namespace WindowsFormsApp1.NhapHang
{
    partial class PhieuNhapGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grid_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.CotmaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotmaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotmaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotngayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CottongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Tim = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ChiTiet = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_ThemPhieuNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1110, 608);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.grid_PhieuNhap, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1110, 566);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grid_PhieuNhap
            // 
            this.grid_PhieuNhap.AllowUserToAddRows = false;
            this.grid_PhieuNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid_PhieuNhap.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_PhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_PhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CotmaPN,
            this.CotmaNV,
            this.CotmaNCC,
            this.CotngayLap,
            this.CottongTien});
            this.tableLayoutPanel2.SetColumnSpan(this.grid_PhieuNhap, 2);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_PhieuNhap.DefaultCellStyle = dataGridViewCellStyle4;
            this.grid_PhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_PhieuNhap.Location = new System.Drawing.Point(3, 137);
            this.grid_PhieuNhap.Margin = new System.Windows.Forms.Padding(0);
            this.grid_PhieuNhap.Name = "grid_PhieuNhap";
            this.grid_PhieuNhap.ReadOnly = true;
            this.grid_PhieuNhap.RowHeadersVisible = false;
            this.grid_PhieuNhap.RowHeadersWidth = 51;
            this.grid_PhieuNhap.RowTemplate.Height = 24;
            this.grid_PhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_PhieuNhap.Size = new System.Drawing.Size(1104, 426);
            this.grid_PhieuNhap.TabIndex = 0;
            // 
            // CotmaPN
            // 
            this.CotmaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotmaPN.DataPropertyName = "maPN";
            this.CotmaPN.HeaderText = "Mã Phiếu Nhập";
            this.CotmaPN.MinimumWidth = 6;
            this.CotmaPN.Name = "CotmaPN";
            this.CotmaPN.ReadOnly = true;
            // 
            // CotmaNV
            // 
            this.CotmaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotmaNV.DataPropertyName = "maNV";
            this.CotmaNV.HeaderText = "Mã Nhân Viên";
            this.CotmaNV.MinimumWidth = 6;
            this.CotmaNV.Name = "CotmaNV";
            this.CotmaNV.ReadOnly = true;
            // 
            // CotmaNCC
            // 
            this.CotmaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotmaNCC.DataPropertyName = "maNCC";
            this.CotmaNCC.HeaderText = "Mã NCC";
            this.CotmaNCC.MinimumWidth = 6;
            this.CotmaNCC.Name = "CotmaNCC";
            this.CotmaNCC.ReadOnly = true;
            // 
            // CotngayLap
            // 
            this.CotngayLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotngayLap.DataPropertyName = "ngayLap";
            this.CotngayLap.FillWeight = 150F;
            this.CotngayLap.HeaderText = "Ngày Lập";
            this.CotngayLap.MinimumWidth = 6;
            this.CotngayLap.Name = "CotngayLap";
            this.CotngayLap.ReadOnly = true;
            // 
            // CottongTien
            // 
            this.CottongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CottongTien.DataPropertyName = "tongTien";
            this.CottongTien.FillWeight = 150F;
            this.CottongTien.HeaderText = "Tổng Tiền";
            this.CottongTien.MinimumWidth = 6;
            this.CottongTien.Name = "CottongTien";
            this.CottongTien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.tb_Tim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(9, 6, 0, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(300, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm";
            // 
            // tb_Tim
            // 
            this.tb_Tim.Location = new System.Drawing.Point(3, 26);
            this.tb_Tim.Name = "tb_Tim";
            this.tb_Tim.Size = new System.Drawing.Size(294, 30);
            this.tb_Tim.TabIndex = 0;
            this.tb_Tim.TextChanged += new System.EventHandler(this.tb_Tim_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.btn_Loc);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(9, 6, 0, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(560, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo ngày";
            // 
            // btn_Loc
            // 
            this.btn_Loc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Loc.BackColor = System.Drawing.Color.Azure;
            this.btn_Loc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Loc.Location = new System.Drawing.Point(466, 11);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(94, 48);
            this.btn_Loc.TabIndex = 4;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = false;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(283, 25);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(160, 30);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Xoa, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_ChiTiet, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(858, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(240, 61);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btn_ChiTiet
            // 
            this.btn_ChiTiet.BackColor = System.Drawing.Color.Azure;
            this.btn_ChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ChiTiet.Location = new System.Drawing.Point(0, 0);
            this.btn_ChiTiet.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ChiTiet.Name = "btn_ChiTiet";
            this.btn_ChiTiet.Size = new System.Drawing.Size(120, 61);
            this.btn_ChiTiet.TabIndex = 6;
            this.btn_ChiTiet.Text = "Chi Tiết";
            this.btn_ChiTiet.UseVisualStyleBackColor = false;
            this.btn_ChiTiet.Click += new System.EventHandler(this.btn_ChiTiet_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Azure;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Xoa.Location = new System.Drawing.Point(120, 0);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 61);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btn_Reload, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_ThemPhieuNhap, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(723, 73);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(375, 61);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btn_Reload
            // 
            this.btn_Reload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Reload.BackColor = System.Drawing.Color.Azure;
            this.btn_Reload.Image = global::WindowsFormsApp1.Properties.Resources.reload;
            this.btn_Reload.Location = new System.Drawing.Point(300, 0);
            this.btn_Reload.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(75, 60);
            this.btn_Reload.TabIndex = 6;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_ThemPhieuNhap
            // 
            this.btn_ThemPhieuNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_ThemPhieuNhap.BackColor = System.Drawing.Color.Navy;
            this.btn_ThemPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btn_ThemPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.btn_ThemPhieuNhap.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ThemPhieuNhap.Name = "btn_ThemPhieuNhap";
            this.btn_ThemPhieuNhap.Size = new System.Drawing.Size(300, 61);
            this.btn_ThemPhieuNhap.TabIndex = 3;
            this.btn_ThemPhieuNhap.Text = "Thêm phiếu nhập";
            this.btn_ThemPhieuNhap.UseVisualStyleBackColor = false;
            this.btn_ThemPhieuNhap.Click += new System.EventHandler(this.btn_ThemPhieuNhap_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(472, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập Hàng";
            // 
            // PhieuNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 608);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhieuNhapGUI";
            this.Text = "PhieuNhapGUI";
            this.Load += new System.EventHandler(this.PhieuNhapGUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_PhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView grid_PhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Tim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_ChiTiet;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_ThemPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotngayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn CottongTien;
    }
}