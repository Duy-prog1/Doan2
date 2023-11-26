using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.TaiKhoan
{
    public partial class TaiKhoanGUI : Form
    {
        TaiKhoanDTO tkDto = new TaiKhoanDTO();
        TaiKhoanBUS tkBus = new TaiKhoanBUS();
        public TaiKhoanGUI()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoanGUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.tkBus.getTaiKhoan();
            comboBox2.DataSource = this.tkBus.getAllMaNhanVien();
            comboBox1.DataSource = this.tkBus.getAllMaQuyen();
        }

        private bool ValidateInput(string maNV, string maQuyen, string tenDangNhap, string matKhau)
        {
            // Kiểm tra điều kiện validate ở đây
            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(maQuyen) ||
                string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            if (tenDangNhap.Length <= 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 7 ký tự.");
                return false;
            }

            if (matKhau.Length <= 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 7 ký tự.");
                return false;
            }

            return true; 
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tkDto = new TaiKhoanDTO();
            string maNV = comboBox2.Text;
            string maQuyenStr = comboBox1.Text;
            string tenDangNhap = textBox5.Text;
            string matKhau = textBox6.Text;

            if (ValidateInput(maNV, maQuyenStr, tenDangNhap, matKhau))
            {
                if (int.TryParse(maQuyenStr, out int maQuyen))
                {
                    // Lấy đối tượng tài khoản
                    var existingAccount = this.tkBus.getTk(maNV);

                    if (existingAccount != null && existingAccount.maNhanVien == maNV)
                    {
                        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                    }
                    else
                    {
                        tkDto.maNhanVien = maNV;
                        tkDto.maQuyen = maQuyen;
                        tkDto.tenDangNhap = tenDangNhap;
                        tkDto.matKhau = matKhau;
                        Console.Write(tkDto.maNhanVien);

                        if (tkBus.themTaiKhoan(tkDto))
                        {
                            MessageBox.Show("Thêm thành công!");
                            dataGridView1.DataSource = this.tkBus.getTaiKhoan();
                            comboBox1.Text = string.Empty;
                            comboBox2.Text = string.Empty;
                            textBox5.Text = string.Empty;
                            textBox6.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công. Kiểm tra lại thông tin.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã quyền không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string maNVToDelete = comboBox2.Text;

            // Check if maNVToDelete is not empty
            if (!string.IsNullOrEmpty(maNVToDelete))
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Call a method to delete the account
                    if (tkBus.xoaNhanVien(maNVToDelete))
                    {
                        MessageBox.Show("Xóa thành công!");
                        dataGridView1.DataSource = this.tkBus.getTaiKhoan(); // Update the DataGridView
                                                                                // Clear the input fields
                        comboBox1.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        textBox5.Text = string.Empty;
                        textBox6.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công. Kiểm tra lại thông tin.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tài khoản để xóa.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột trong hàng được chọn và hiển thị lên các TextBox
                comboBox2.Text = row.Cells["Column1"].Value.ToString();// Thay "Column1" bằng tên cột thích hợp
                comboBox1.Text = row.Cells["Column2"].Value.ToString();
                textBox5.Text = row.Cells["Column3"].Value.ToString();
                textBox6.Text = row.Cells["Column4"].Value.ToString();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            tkDto = new TaiKhoanDTO();
            string maNV = comboBox2.Text;
            string maQuyenStr = comboBox1.Text;
            string tenDangNhap = textBox5.Text;
            string matKhau = textBox6.Text;

            if (ValidateInput(maNV, maQuyenStr, tenDangNhap, matKhau))
            {
                if (int.TryParse(maQuyenStr, out int maQuyen))
                {
                    tkDto.maNhanVien = maNV;
                    tkDto.maQuyen = maQuyen;
                    tkDto.tenDangNhap = tenDangNhap;
                    tkDto.matKhau = matKhau;

                    if (tkBus.suaTaiKhoan(tkDto))
                    {
                        MessageBox.Show("Sửa thành công!");
                        dataGridView1.DataSource = this.tkBus.getTaiKhoan();
                        comboBox1.Text = string.Empty;
                        comboBox2.Text = string.Empty;
                        textBox5.Text = string.Empty;
                        textBox6.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công. Kiểm tra lại thông tin.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã quyền không hợp lệ. Vui lòng kiểm tra lại.");
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }
    }
}
