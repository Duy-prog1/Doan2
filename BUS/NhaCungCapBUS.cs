using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        NhaCungCapDAL dalNhaCungCap = new NhaCungCapDAL();
        public DataTable getNhaCungCap()
        {
            return dalNhaCungCap.getNhaCungCap();
        }

        public DataTable getMaNhaCungCap()
        {
            return dalNhaCungCap.getMaNhaCungCap();
        }
    }
}
