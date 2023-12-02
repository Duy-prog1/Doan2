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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTenKh = new System.Windows.Forms.Label();
            this.tbKh = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lbTenKh);
            this.panel2.Controls.Add(this.tbKh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 214);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTenKh
            // 
            this.lbTenKh.AutoSize = true;
            this.lbTenKh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKh.Location = new System.Drawing.Point(31, 23);
            this.lbTenKh.Name = "lbTenKh";
            this.lbTenKh.Size = new System.Drawing.Size(121, 24);
            this.lbTenKh.TabIndex = 3;
            this.lbTenKh.Text = "Khách hàng:";
            this.lbTenKh.Click += new System.EventHandler(this.lbTenKh_Click);
            // 
            // tbKh
            // 
            this.tbKh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKh.Location = new System.Drawing.Point(194, 23);
            this.tbKh.Name = "tbKh";
            this.tbKh.Size = new System.Drawing.Size(239, 32);
            this.tbKh.TabIndex = 1;
            this.tbKh.TextChanged += new System.EventHandler(this.tbKh_TextChanged);
            // 
            // KhachHangThanhToanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 214);
            this.Controls.Add(this.panel2);
            this.Name = "KhachHangThanhToanGUI";
            this.Text = "KhachHangGUI";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTenKh;
        private System.Windows.Forms.TextBox tbKh;
        private System.Windows.Forms.Button button1;
    }
}