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

namespace WindowsFormsApp1.BanHang
{
    public partial class KhachHangThanhToanGUI : Form
    {
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        KhachHangDTO khachHangDTO ;
        List <KhachHangDTO> list = new List<KhachHangDTO> ();
        public KhachHangThanhToanGUI()
        {
            InitializeComponent();
        }

     
        private void tbSdt_TextChanged(object sender, EventArgs e)
        {
           
            list = khachHangBUS.getList();
            string sdt = tbSdt.Text.Trim();
           // MessageBox.Show(sdt);
            khachHangDTO = khachHangBUS.findSdt(sdt);
          //  foreach (KhachHangDTO item in list)
         //   {

                if (khachHangDTO != null)
                {
                    tbKh.Text = khachHangDTO.tenKh;
                }
             /*   if (sdt.Equals(item.sdtKh))
                {
                    
                    MessageBox.Show(item.tenKh);
                    tbKh.Text = item.tenKh; break;
                }
                
            }*/


        }
    }
}
