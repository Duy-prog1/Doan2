﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BanHangDAL : DatabaseConnect
    {
        // 1 -- hiển thị danh sách sản phẩm
        public DataTable getDSSP()
        {
            var cmd = new SqlCommand("SELECT maSP, tenSP, giaBan, maLoai,soLuong, img FROM sanPham WHERE soLuong>0", _conn);
            var da = new SqlDataAdapter(cmd);
            var dt = new DataTable();

            da.Fill(dt);

            return dt;
        }
        // 2 -- lấy ra danh sách sản phẩm
        public List<SanPhamDTO> DanhSachSanPham()
        {
            List<SanPhamDTO> productList = new List<SanPhamDTO>();
            try
            {
                _conn.Open();
                string SQL = "SELECT * FROM sanPham";
                SqlCommand command = new SqlCommand(SQL, _conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SanPhamDTO dto = new SanPhamDTO
                    {
                        maSanPham = reader["maSP"].ToString(),
                        tenSanPham = reader["tenSP"].ToString(),
                        giaBan = (float)reader["giaBan"],
                        soLuong = Convert.ToInt32(reader["soLuong"]),
                        img = (byte[])reader["img"],
                        thoiGianBaoHanh = Convert.ToInt32(reader["thoiGianBaoHanh"]),
                        tinhTrang = Convert.ToBoolean(reader["tinhTrang"]),
                        maLoai = Convert.ToInt32(reader["maLoai"])

                    };

                    productList.Add(dto);

                }
                return productList;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return null;
        }
        // 3 -- tìm kiếm sản phẩm
        // 3 -- Tìm kiếm sản phẩm
        public DataTable TimKiemSanPham(string keyword)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da;
            try
            {
                _conn.Open();
                string SQL = "SELECT maSP, tenSP, giaBan, maLoai, img FROM sanPham WHERE tenSP LIKE @Keyword";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                da = new SqlDataAdapter(command);
                da.Fill(dataTable);
            }
            catch (Exception ex)
            {


            }
            finally
            {
                _conn.Close();
            }
            return dataTable;
        }
        // cập nhật số lượng trong danh sách sản phẩm
        public bool CapNhatSoLuongSPTrongDB(string maSP, int soLuongCapNhat)
        {
            try
            {
                _conn.Open();
                string SQL = "UPDATE sanPham SET soLuong = soLuong - @soLuongCapNhat WHERE maSP = @maSP";
                using (SqlCommand cmd = new SqlCommand(SQL, _conn))
                {
                    cmd.Parameters.AddWithValue("@soLuongCapNhat", soLuongCapNhat);
                    cmd.Parameters.AddWithValue("@maSP", maSP);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
        public DataTable getkhuyenMaiBanhang()
        {
            DataTable dtKhuyenMai = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT KM.maKM, KM.tenKM, KM.ngayBD, KM.ngayKT, CTKM.donViGiam,CTKM.giaTriGiam FROM khuyenMai KM JOIN CT_KhuyenMai CTKM ON KM.maKM = CTKM.maKM", _conn))
            {
                adapter.Fill(dtKhuyenMai);
            }

            return dtKhuyenMai;
        }
        // lấy mã khuyến mãi

        public DataTable LayMaKhuyenMai(string tenSanPham)
        {
            DataTable dtMaKhuyenMai = new DataTable();
            try
            {
                _conn.Open();
                string SQL = "SELECT KM.maKM, KM.donViGiam,KM.giaTriGiam, kk.tenKM,KK.ngayBD,KK.ngayKT FROM sanPham SP JOIN CT_KhuyenMai KM ON SP.maSP = KM.maSP\r\nJOIN khuyenMai KK ON KM.maKM = KK.maKM WHERE SP.tenSP = @TenSanPham";
                using (SqlCommand command = new SqlCommand(SQL, _conn))
                {
                    command.Parameters.AddWithValue("@TenSanPham", tenSanPham);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtMaKhuyenMai);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
            }
            finally
            {
                _conn.Close();
            }
            return dtMaKhuyenMai;
        }
        public DataTable LayMaSP()
        {
            DataTable dtMaSanPham = new DataTable();
            try
            {
                _conn.Open();
                string SQL = "SELECT maSP FROM sanPham";

                using (SqlCommand command = new SqlCommand(SQL, _conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtMaSanPham);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dtMaSanPham;
        }





    }
}
