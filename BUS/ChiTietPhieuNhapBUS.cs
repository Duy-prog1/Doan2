using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAL dalChiTietPhieuNhap = new ChiTietPhieuNhapDAL();

        public DataTable getCTPNByMaPhieuNhap(string maPhieuNhap)
        {
            return dalChiTietPhieuNhap.getCTPNByMaPhieuNhap(maPhieuNhap);
        }

        public bool themChiTietPhieuNhap(ChiTietPhieuNhapDTO ctpn)
        {
            return dalChiTietPhieuNhap.themChiTietPhieuNhap(ctpn);
        }
    }
}
