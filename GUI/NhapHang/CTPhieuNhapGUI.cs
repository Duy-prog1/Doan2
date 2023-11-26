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
    public partial class CTPhieuNhapGUI : Form
    {
        ChiTietPhieuNhapBUS ctpnBus = new ChiTietPhieuNhapBUS();
        string maPN, maNV, maNCC, ngayLap, tongTien;
        public CTPhieuNhapGUI(string maPN, string maNV, string maNCC, string ngayLap, string tongTien)
        {
            InitializeComponent();
            this.maPN = maPN;
            this.maNV = maNV;
            this.maNCC = maNCC;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
        }

        private void CTPhieuNhapGUI_Load(object sender, EventArgs e)
        {
            tb_MaPhieuNhap.Text = maPN;
            tb_MaNhanVien.Text = maNV;
            tb_NCC.Text = maNCC;
            dtp_NgayLap.Text = ngayLap;
            label6.Text = tongTien;
            grid_ChiTietPhieuNhap.DataSource = ctpnBus.getCTPNByMaPhieuNhap(maPN);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
