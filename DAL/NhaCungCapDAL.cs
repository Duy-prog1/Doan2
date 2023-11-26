using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL:DatabaseConnect
    {
        public DataTable getNhaCungCap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT maNCC, tenNCC, sdt, diaChi FROM ncc WHERE tinhTrang = 1", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getMaNhaCungCap()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT maNCC FROM ncc WHERE tinhTrang = 1", _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
