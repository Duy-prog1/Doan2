﻿namespace WindowsFormsApp1.NhapHang
{
    partial class CTPhieuNhapGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_ChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.CotmaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotmaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotgiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotsoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CottinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaNhanVien = new System.Windows.Forms.TextBox();
            this.tb_NCC = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 50);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi tiết phiếu nhập";
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(601, 636);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(100, 40);
            this.btn_Close.TabIndex = 28;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(279, 58);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng số tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "0";
            // 
            // grid_ChiTietPhieuNhap
            // 
            this.grid_ChiTietPhieuNhap.AllowUserToAddRows = false;
            this.grid_ChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.grid_ChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ChiTietPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_ChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CotmaPN,
            this.CotmaSP,
            this.CotgiaNhap,
            this.CotsoLuong,
            this.CottinhTrang});
            this.grid_ChiTietPhieuNhap.Location = new System.Drawing.Point(41, 290);
            this.grid_ChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(0);
            this.grid_ChiTietPhieuNhap.Name = "grid_ChiTietPhieuNhap";
            this.grid_ChiTietPhieuNhap.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_ChiTietPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_ChiTietPhieuNhap.RowHeadersVisible = false;
            this.grid_ChiTietPhieuNhap.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid_ChiTietPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_ChiTietPhieuNhap.RowTemplate.Height = 24;
            this.grid_ChiTietPhieuNhap.Size = new System.Drawing.Size(660, 343);
            this.grid_ChiTietPhieuNhap.TabIndex = 26;
            // 
            // CotmaPN
            // 
            this.CotmaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotmaPN.DataPropertyName = "maPN";
            this.CotmaPN.HeaderText = "Mã phiếu nhập";
            this.CotmaPN.MinimumWidth = 6;
            this.CotmaPN.Name = "CotmaPN";
            this.CotmaPN.ReadOnly = true;
            this.CotmaPN.Visible = false;
            // 
            // CotmaSP
            // 
            this.CotmaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotmaSP.DataPropertyName = "maSP";
            this.CotmaSP.HeaderText = "Mã sản phẩm";
            this.CotmaSP.MinimumWidth = 6;
            this.CotmaSP.Name = "CotmaSP";
            this.CotmaSP.ReadOnly = true;
            // 
            // CotgiaNhap
            // 
            this.CotgiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotgiaNhap.DataPropertyName = "giaNhap";
            this.CotgiaNhap.HeaderText = "Giá Nhập";
            this.CotgiaNhap.MinimumWidth = 6;
            this.CotgiaNhap.Name = "CotgiaNhap";
            this.CotgiaNhap.ReadOnly = true;
            // 
            // CotsoLuong
            // 
            this.CotsoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CotsoLuong.DataPropertyName = "soLuong";
            this.CotsoLuong.HeaderText = "Số lượng";
            this.CotsoLuong.MinimumWidth = 6;
            this.CotsoLuong.Name = "CotsoLuong";
            this.CotsoLuong.ReadOnly = true;
            // 
            // CottinhTrang
            // 
            this.CottinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CottinhTrang.DataPropertyName = "tinhTrang";
            this.CottinhTrang.HeaderText = "Tình trạng";
            this.CottinhTrang.MinimumWidth = 6;
            this.CottinhTrang.Name = "CottinhTrang";
            this.CottinhTrang.ReadOnly = true;
            this.CottinhTrang.Visible = false;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_NgayLap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Enabled = false;
            this.dtp_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLap.Location = new System.Drawing.Point(533, 154);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(0);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(151, 34);
            this.dtp_NgayLap.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã NCC";
            // 
            // tb_MaPhieuNhap
            // 
            this.tb_MaPhieuNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaPhieuNhap.Enabled = false;
            this.tb_MaPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaPhieuNhap.Location = new System.Drawing.Point(213, 86);
            this.tb_MaPhieuNhap.Margin = new System.Windows.Forms.Padding(0);
            this.tb_MaPhieuNhap.Name = "tb_MaPhieuNhap";
            this.tb_MaPhieuNhap.Size = new System.Drawing.Size(138, 34);
            this.tb_MaPhieuNhap.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // tb_MaNhanVien
            // 
            this.tb_MaNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MaNhanVien.Enabled = false;
            this.tb_MaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaNhanVien.Location = new System.Drawing.Point(533, 86);
            this.tb_MaNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.tb_MaNhanVien.Name = "tb_MaNhanVien";
            this.tb_MaNhanVien.Size = new System.Drawing.Size(138, 34);
            this.tb_MaNhanVien.TabIndex = 29;
            // 
            // tb_NCC
            // 
            this.tb_NCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NCC.Enabled = false;
            this.tb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NCC.Location = new System.Drawing.Point(213, 156);
            this.tb_NCC.Margin = new System.Windows.Forms.Padding(0);
            this.tb_NCC.Name = "tb_NCC";
            this.tb_NCC.Size = new System.Drawing.Size(138, 34);
            this.tb_NCC.TabIndex = 30;
            // 
            // CTPhieuNhapGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 700);
            this.Controls.Add(this.tb_NCC);
            this.Controls.Add(this.tb_MaNhanVien);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_ChiTietPhieuNhap);
            this.Controls.Add(this.dtp_NgayLap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_MaPhieuNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CTPhieuNhapGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CTPhieuNhapGUI";
            this.Load += new System.EventHandler(this.CTPhieuNhapGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grid_ChiTietPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MaPhieuNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaNhanVien;
        private System.Windows.Forms.TextBox tb_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotmaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotgiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotsoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn CottinhTrang;
    }
}