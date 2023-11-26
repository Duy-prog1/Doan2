using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.NhapHang
{
    public partial class PhieuNhapGUI : Form
    {
        PhieuNhapBUS pnBus = new PhieuNhapBUS();

        public PhieuNhapGUI()
        {
            InitializeComponent();
        }
        private void PhieuNhapGUI_Load(object sender, EventArgs e)
        {
            grid_PhieuNhap.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PhieuNhap.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PhieuNhap.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PhieuNhap.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_PhieuNhap.DataSource = this.pnBus.getPhieuNhap();
        }

        private void btn_ThemPhieuNhap_Click(object sender, EventArgs e)
        {
            ThemPhieuNhapGUI themPhieuNhap = new ThemPhieuNhapGUI(grid_PhieuNhap);
            themPhieuNhap.ShowDialog();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này không?", "Xóa phiếu nhập", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string maPN = grid_PhieuNhap.SelectedRows[0].Cells[0].Value.ToString();
                if (pnBus.xoaPhieuNhap(maPN))
                {
                    MessageBox.Show("Xóa thành công");
                    grid_PhieuNhap.DataSource = pnBus.getPhieuNhap();
                }
                else
                    MessageBox.Show("Xóa thất bại");
            }
            else
            {
                return;
            }
        }

        private void btn_ChiTiet_Click(object sender, EventArgs e)
        {
            CTPhieuNhapGUI ctPhieuNhap = new CTPhieuNhapGUI(grid_PhieuNhap.SelectedRows[0].Cells[0].Value.ToString(),
                                                            grid_PhieuNhap.SelectedRows[0].Cells[1].Value.ToString(),
                                                            grid_PhieuNhap.SelectedRows[0].Cells[2].Value.ToString(),
                                                            grid_PhieuNhap.SelectedRows[0].Cells[3].Value.ToString(),
                                                            grid_PhieuNhap.SelectedRows[0].Cells[4].Value.ToString());
            ctPhieuNhap.ShowDialog();
        }

        private void tb_Tim_TextChanged(object sender, EventArgs e)
        {
            if(tb_Tim.Text == "")
                grid_PhieuNhap.DataSource = this.pnBus.getPhieuNhap();
            else
                grid_PhieuNhap.DataSource = this.pnBus.timPhieuNhap(tb_Tim.Text);
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            string fromDay, toDay;
            fromDay = dateTimePicker1.Value.ToString("yyyy-MM-dd"); toDay = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            grid_PhieuNhap.DataSource = this.pnBus.timPhieuNhapTheoKhoangNgay(fromDay, toDay);
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            grid_PhieuNhap.DataSource = this.pnBus.getPhieuNhap();
        }

    }
}
