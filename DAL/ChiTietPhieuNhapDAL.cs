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
    public class ChiTietPhieuNhapDAL:DatabaseConnect
    {
        public DataTable getCTPNByMaPhieuNhap(string maPhieuNhap)
        {
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM CT_PhieuNhap WHERE tinhTrang = 1 AND maPN = '{maPhieuNhap}'", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool themChiTietPhieuNhap(ChiTietPhieuNhapDTO ctpn)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CT_PhieuNhap values(@maPN, @maSP, @giaNhap, @soLuong, @tinhTrang)", _conn);
                cmd.Parameters.AddWithValue("@maPN", ctpn.maPN);
                cmd.Parameters.AddWithValue("@maSP", ctpn.maSP);
                cmd.Parameters.AddWithValue("@giaNhap", ctpn.giaNhap);
                cmd.Parameters.AddWithValue("@soLuong", ctpn.soLuong);
                cmd.Parameters.AddWithValue("@tinhTrang", ctpn.tinhTrang);
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
    }
}
