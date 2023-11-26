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
    public class PhieuNhapBUS
    {
        PhieuNhapDAL dalPhieuNhap = new PhieuNhapDAL();

        public DataTable getPhieuNhap()
        {
            return dalPhieuNhap.getPhieuNhap();
        }

        public DataTable getDeletedPhieuNhap()
        {
            return dalPhieuNhap.getDeletedPhieuNhap();
        }

        public bool taoPhieuNhap(PhieuNhapDTO pn)
        {
            return dalPhieuNhap.taoPhieuNhap(pn);
        }

        public bool xoaPhieuNhap(string maPN)
        {
            return dalPhieuNhap.xoaPhieuNhap(maPN);
        }

        public DataTable timPhieuNhap(string text)
        {
            return dalPhieuNhap.timPhieuNhap(text);
        }

        public DataTable timPhieuNhapTheoKhoangNgay(string fromDay, string toDay)
        {
            return dalPhieuNhap.timPhieuNhapTheoKhoangNgay(fromDay, toDay);
        }
    }
}
