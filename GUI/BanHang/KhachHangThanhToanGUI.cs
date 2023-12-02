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
        public string TenKhachHang { get; private set; }
        public string SoDienThoai { get; private set; }
        KhachHangBUS khachHangBUS = new KhachHangBUS();
        KhachHangDTO khachHangDTO ;
        List <KhachHangDTO> list = new List<KhachHangDTO> ();
        public KhachHangThanhToanGUI()
        {

            InitializeComponent();
               this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Retrieve entered information and close the form
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TenKhachHang = tbKh.Text;
           
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbKh_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbTenKh_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
