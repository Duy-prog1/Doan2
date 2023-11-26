﻿namespace WindowsFormsApp1
{
    partial class KhachhangGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tblKh = new System.Windows.Forms.DataGridView();
            this.cotMaKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTenKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTichDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cotTongChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 499);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 499);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(824, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tblKh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 446);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tblKh
            // 
            this.tblKh.AllowUserToAddRows = false;
            this.tblKh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tblKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cotMaKh,
            this.cotTenKh,
            this.cotSdt,
            this.cotTichDiem,
            this.cotTongChi});
            this.tblKh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblKh.Location = new System.Drawing.Point(3, 47);
            this.tblKh.Name = "tblKh";
            this.tblKh.RowHeadersWidth = 51;
            this.tblKh.Size = new System.Drawing.Size(814, 396);
            this.tblKh.TabIndex = 4;
            this.tblKh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cotMaKh
            // 
            this.cotMaKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotMaKh.DataPropertyName = "maKH";
            this.cotMaKh.HeaderText = "Mã Khách Hàng";
            this.cotMaKh.MinimumWidth = 6;
            this.cotMaKh.Name = "cotMaKh";
            // 
            // cotTenKh
            // 
            this.cotTenKh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotTenKh.DataPropertyName = "tenKH";
            this.cotTenKh.HeaderText = "Họ Tên ";
            this.cotTenKh.MinimumWidth = 6;
            this.cotTenKh.Name = "cotTenKh";
            // 
            // cotSdt
            // 
            this.cotSdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotSdt.DataPropertyName = "sdt";
            this.cotSdt.HeaderText = "Số Điện Thoại";
            this.cotSdt.MinimumWidth = 6;
            this.cotSdt.Name = "cotSdt";
            // 
            // cotTichDiem
            // 
            this.cotTichDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotTichDiem.DataPropertyName = "tichDiem";
            this.cotTichDiem.HeaderText = "Tích Điểm";
            this.cotTichDiem.MinimumWidth = 6;
            this.cotTichDiem.Name = "cotTichDiem";
            // 
            // cotTongChi
            // 
            this.cotTongChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cotTongChi.DataPropertyName = "tongChi";
            this.cotTongChi.HeaderText = "Tổng Chi";
            this.cotTongChi.MinimumWidth = 6;
            this.cotTongChi.Name = "cotTongChi";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KhachhangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 499);
            this.Controls.Add(this.panel1);
            this.Name = "KhachhangGUI";
            this.Text = "KhachhangGUI";
            this.Load += new System.EventHandler(this.KhachhangGUI_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblKh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView tblKh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotMaKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTenKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTichDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cotTongChi;
    }
}