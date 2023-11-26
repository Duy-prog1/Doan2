using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL : DatabaseConnect
    {
        public DataTable getPhieuNhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT maPN, maNV, maNCC, ngayLap, tongTien FROM phieuNhap WHERE tinhTrang = 1", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getDeletedPhieuNhap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT maPN, maNV, maNCC, ngayLap, tongTien FROM phieuNhap WHERE tinhTrang = 0", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool taoPhieuNhap(PhieuNhapDTO pn)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO phieuNhap values(@maPN, @maNV, @maNCC, @ngayLap, @tongTien, @tinhTrang)", _conn);
                cmd.Parameters.AddWithValue("@maPN", pn.maPN);
                cmd.Parameters.AddWithValue("@maNV", pn.maNV);
                cmd.Parameters.AddWithValue("@maNCC", pn.maNCC);
                cmd.Parameters.AddWithValue("@ngayLap", pn.ngayLap);
                cmd.Parameters.AddWithValue("@tongTien", pn.tongTien);
                cmd.Parameters.AddWithValue("@tinhTrang", pn.tinhTrang);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public bool xoaPhieuNhap(string maPN)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE phieuNhap SET tinhTrang = 'false' WHERE maPN = @maPN", _conn);
                cmd.Parameters.AddWithValue("@maPN", maPN);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex) { }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public DataTable timPhieuNhap(string text)
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT maPN, maNV, maNCC, ngayLap, tongTien FROM phieuNhap WHERE tinhTrang = 1 AND (maPN LIKE '%{text}%' OR maNV LIKE '%{text}%' OR maNCC LIKE '%{text}%')", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable timPhieuNhapTheoKhoangNgay(string fromDay, string toDay)
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT maPN, maNV, maNCC, ngayLap, tongTien FROM phieuNhap WHERE tinhTrang = 1 AND ngayLap BETWEEN '{fromDay}' AND '{toDay}'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
