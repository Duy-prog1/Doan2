namespace WindowsFormsApp1.BanHang
{
    partial class KhachHangThanhToanGUI
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbKh = new System.Windows.Forms.TextBox();
            this.lbSdt = new System.Windows.Forms.Label();
            this.lbTenKh = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTenKh);
            this.panel2.Controls.Add(this.lbSdt);
            this.panel2.Controls.Add(this.tbKh);
            this.panel2.Controls.Add(this.tbSdt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 100);
            this.panel3.TabIndex = 2;
            // 
            // tbSdt
            // 
            this.tbSdt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSdt.Location = new System.Drawing.Point(337, 52);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(239, 32);
            this.tbSdt.TabIndex = 0;
            this.tbSdt.TextChanged += new System.EventHandler(this.tbSdt_TextChanged);
            // 
            // tbKh
            // 
            this.tbKh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKh.Location = new System.Drawing.Point(337, 115);
            this.tbKh.Name = "tbKh";
            this.tbKh.Size = new System.Drawing.Size(239, 32);
            this.tbKh.TabIndex = 1;
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSdt.Location = new System.Drawing.Point(198, 55);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(134, 24);
            this.lbSdt.TabIndex = 2;
            this.lbSdt.Text = "Số điện thoại:";
            // 
            // lbTenKh
            // 
            this.lbTenKh.AutoSize = true;
            this.lbTenKh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKh.Location = new System.Drawing.Point(210, 120);
            this.lbTenKh.Name = "lbTenKh";
            this.lbTenKh.Size = new System.Drawing.Size(121, 24);
            this.lbTenKh.TabIndex = 3;
            this.lbTenKh.Text = "Khách hàng:";
            // 
            // KhachHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHangGUI";
            this.Text = "KhachHangGUI";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTenKh;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.TextBox tbKh;
        private System.Windows.Forms.TextBox tbSdt;
    }
}