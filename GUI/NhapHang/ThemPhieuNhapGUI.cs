using BUS;
using DTO;
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
    public partial class ThemPhieuNhapGUI : Form
    {
        PhieuNhapBUS pnBus = new PhieuNhapBUS();
        ChiTietPhieuNhapBUS ctpnBus = new ChiTietPhieuNhapBUS();
        SanPhamBUS spBus = new SanPhamBUS();
        DataGridView gridpn;
        float tongTien = 0;
        public ThemPhieuNhapGUI(DataGridView gridpn)
        {
            InitializeComponent();
            this.gridpn = gridpn;
        }

        private void ThemPhieuNhapGUI_Load(object sender, EventArgs e)
        {
            tb_MaPhieuNhap.Text = updateNewMaPhieuNhap();

            string maNhanVien = new TaiKhoanBUS().LayMaNhanVien(DangNhapGUI.tenDangNhap, DangNhapGUI.matKhau);
            tb_MaNhanVien.Text = maNhanVien;

            DataTable dt = new NhaCungCapBUS().getMaNhaCungCap();
            cbb_NCC.DisplayMember = "maNCC";
            cbb_NCC.DataSource = dt;

            grid_SanPham.DataSource = new SanPhamBUS().getSanPham();

            label6.Text = tongTien.ToString();
        }

        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_CTPhieuNhap.Rows.Add(tb_MaPhieuNhap.Text, grid_SanPham.SelectedRows[0].Cells["CotmaSP"].Value.ToString(), "0", "0");
        }

        private void grid_CTPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid_CTPhieuNhap.Columns[e.ColumnIndex].Name == "Cotxoa")
            {
                grid_CTPhieuNhap.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void grid_CTPhieuNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = grid_CTPhieuNhap.Columns[e.ColumnIndex].Name;
            if (columnName == "Column3" || columnName == "Column4")
                label6.Text = tinhTongTien();
        }
        private void btn_Tao_Click(object sender, EventArgs e)
        {
            //Thêm phiếu nhập vào database
            PhieuNhapDTO pnDTO = new PhieuNhapDTO(int.Parse(tb_MaPhieuNhap.Text), 
                tb_MaNhanVien.Text, int.Parse(cbb_NCC.Text), dtp_NgayLap.Value, 
                float.Parse(label6.Text), true);
            if (pnBus.taoPhieuNhap(pnDTO))
            {
                MessageBox.Show("Thêm phiếu nhập thành công");
                gridpn.DataSource = pnBus.getPhieuNhap();
            }
            else
                MessageBox.Show("Thêm phiếu nhập thất bại");
            //Thêm chi tiết phiếu nhập tăng số lượng sản phẩm
            int maPN, soLuong;
            string maSP;
            float giaNhap = 0;
            for (int i = 0; i < grid_CTPhieuNhap.Rows.Count; i++)
            {
                maPN = int.Parse(tb_MaPhieuNhap.Text);
                maSP = grid_CTPhieuNhap.Rows[i].Cells[1].Value.ToString();
                float.TryParse(grid_CTPhieuNhap.Rows[i].Cells[2].Value.ToString(), out giaNhap);
                int.TryParse(grid_CTPhieuNhap.Rows[i].Cells[3].Value.ToString(), out soLuong);
                ChiTietPhieuNhapDTO ctpnDto = new ChiTietPhieuNhapDTO(maPN, maSP, giaNhap, soLuong, true);
                
                if (!ctpnBus.themChiTietPhieuNhap(ctpnDto) || !spBus.tangSoLuongSanPham(maSP, soLuong))
                {
                    MessageBox.Show("Lỗi khi thêm chi tiết phiếu nhập");
                }
            }
            this.Close();
        }

        private string tinhTongTien()
        {
            double tongTien = 0;
            for (int i = 0; i < grid_CTPhieuNhap.Rows.Count; i++)
            {
                double donGia = Convert.ToDouble(grid_CTPhieuNhap.Rows[i].Cells[2].Value);
                int soLuong = Convert.ToInt32(grid_CTPhieuNhap.Rows[i].Cells[3].Value);
                tongTien += soLuong * donGia;
            }
            return tongTien.ToString();
        }

        private string updateNewMaPhieuNhap()
        {
            DataTable dt1 = pnBus.getPhieuNhap(); DataTable dt2 = pnBus.getDeletedPhieuNhap();
            int maPhieuNhap = dt1.Rows.Count + dt2.Rows.Count + 1;
            return maPhieuNhap.ToString();
        }

    }
}
