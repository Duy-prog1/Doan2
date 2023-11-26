﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public string maNv { get; set; }
        public string tenNv { get; set; }
        public String gioiTinhNv { get; set; }    
        public string sdtNv { get; set; }
        public string diaChiNv { get; set; }
        public string chucVu { get; set; }       
        public string ngaySinhNv { get; set; }
        public bool trangThai { get; set; }

        public NhanVienDTO() { }

        public NhanVienDTO(string maNv, string tenNv, String gioiTinhNv, string sdtNv, string diaChiNv, string chucVu, string ngaySinhNv, bool trangThai)
        {
            this.maNv = maNv;
            this.tenNv = tenNv;
            this.gioiTinhNv = gioiTinhNv;
            this.sdtNv = sdtNv;
            this.diaChiNv = diaChiNv;
            this.chucVu = chucVu;
            this.ngaySinhNv = ngaySinhNv;
            this.trangThai = trangThai;
        }
    }
}
