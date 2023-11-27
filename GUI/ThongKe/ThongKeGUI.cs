using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class ThongKeGUI : Form
    {
        ThongKeBUS thongKeBUS = new ThongKeBUS();
        public ThongKeGUI()
        {
            InitializeComponent();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            //kiem tra da chon cac truong chưa
            if(comboDSSP.Items.Count==1 || comboThoiGian.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để thống kê và thời gian thống kê");
                return;
            }

            //loaiBo default
            int numOfSeries1 = chart1.Series.Count;
            for (int i= 0;i < numOfSeries1;i++)
            {
                chart1.Series.RemoveAt(0);
            }
            int numOfSeries2 = chart2.Series.Count;
            for (int i= 0; i < numOfSeries2; i++)
            {
                chart2.Series.RemoveAt(0);
            }
            /*
             cần có trong thống kê:
                points
                Series SP
                Thời gian
             */

            //lay ds loai SP
            //List<String> danhSachLoaiSP = sanPhamBUS.getDSLoaiSP();

            //lay listSP
            List<String> listSP = new List<String>();
            for (int i = 1; i < comboDSSP.Items.Count; i++)
            {
                listSP.Add(comboDSSP.Items[i].ToString());
            }
            //sort lai list SP
            listSP.Sort();
            //for(int i = 0; i < listSP.Count; i++)
            //{
            //    Console.WriteLine(listSP[i]);
            //}
            Console.WriteLine("guiok");

            //lay thoiGian
            String thoiGian = comboThoiGian.SelectedItem.ToString().Substring(5); //theo tuan,thang,quy
            //lay begin va end
            DateTime batDau = dateTimePicker1.Value.Date;
            DateTime ketThuc = dateTimePicker2.Value.Date;

            //get Series thống kê doanh thu
            List<Series> series1 = new List<Series>();
            List<Series> series2 = new List<Series>();

            for (int i = 0; i < listSP.Count; i++)
            {
                //series1
                series1.Insert(i, new Series());
                series1[i].ChartArea = "ChartArea1";
                series1[i].ChartType = SeriesChartType.Column;
                series1[i].Legend = "Legend1";
                series1[i].Name = listSP[i] + "(" + (i+1).ToString() + ")";
                //series2
                series2.Insert(i, new Series());
                series2[i].ChartArea = "ChartArea1";
                series2[i].ChartType = SeriesChartType.Line;
                series2[i].Legend = "Legend1";
                series2[i].Name = listSP[i] + "(" + (i + 1).ToString() + ")";
            }

            //add point trước khi thêm vào chart
            thongKeBUS.getPointAllTK(listSP, thoiGian, batDau, ketThuc, series1, series2);

            for (int i = 0; i < listSP.Count; i++)
            {
                //them vao chart1
                chart1.Series.Add(series1[i]);

                //them vao chart2
                chart2.Series.Add(series2[i]);
            }


            String tongThu = thongKeBUS.getTongThu(batDau, ketThuc);
            textBoxTongThu.Text = tongThu;
            String tongChi = thongKeBUS.getTongChi(tongThu,batDau, ketThuc);
            textBoxTongChi.Text = tongChi;
            //String loiNhuan=thongKeBUS.getLoiNhuan(listSP, thoiGian, batDau, ketThuc);
            textBoxLoiNhuan.Text = (Convert.ToDouble(tongThu)-Convert.ToDouble(tongChi)).ToString();
        }

        private void comboSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected=comboSP.SelectedIndex;
            if(indexSelected != 0)
            {
                if(indexSelected == comboSP.Items.Count - 1)
                {
                    for(int i = comboSP.Items.Count-2; i > 0; i--) //0 -> n-1;
                    {
                        //lay index khac 0
                        String temp = comboSP.Items[i].ToString();
                        //move value to danh sach sp
                        comboSP.Items.RemoveAt(i);
                        comboDSSP.Items.Add(temp);
                    }
                }
                else
                {
                    //lay index khac 0
                    String temp = comboSP.SelectedItem.ToString();
                    //move value to danh sach sp
                    comboSP.Items.RemoveAt(indexSelected);
                    comboDSSP.Items.Add(temp);
                }
                comboSP.SelectedIndex = 0;
            }
        }

        private void comboDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboDSSP.SelectedIndex;
            if (indexSelected != 0)
            {
                //lay index khac 0
                String temp = comboDSSP.SelectedItem.ToString();
                //remove value in dssp
                comboDSSP.Items.RemoveAt(indexSelected);
                //lay toanBoSP ra
                comboSP.Items.RemoveAt(comboSP.Items.Count - 1);
                //them lai SP
                comboSP.Items.Add(temp);
                //them lai toanBoSP
                comboSP.Items.Add("Toàn bộ SP");
                //set select 0
                comboDSSP.SelectedIndex = 0;
            }
        }

        private void ThongKeGUI_Load(object sender, EventArgs e)
        {
            int tab1TempCount = comboSP.Items.Count;
            for(int i=0;i<tab1TempCount;i++)
            {
                comboSP.Items.RemoveAt(0);
            }
            int tab2TempCount=comboBox1.Items.Count;
            for (int i = 0; i < tab2TempCount; i++)
            {
                comboBox1.Items.RemoveAt(0);
            }

            comboSP.Items.Add("Sản phẩm");
            comboBox1.Items.Add("Nhân viên");
            SanPhamBUS sanPhamBUS=new SanPhamBUS();
            List<String> tempSPList = sanPhamBUS.getDSLoaiSP();
            for(int i=0;i< tempSPList.Count;i++)
            {
                comboSP.Items.Add(tempSPList[i]);
            }
            comboSP.Items.Add("Toàn bộ SP");
            NhanVienBUS nvBUS=new NhanVienBUS();
            List<String> tempNVList = nvBUS.getDSNV();
            for (int i = 0; i < tempNVList.Count; i++)
            {
                comboBox1.Items.Add(tempNVList[i]);
            }
            comboBox1.Items.Add("Toàn bộ NV");


            //select default combobox
            comboSP.SelectedIndex = 0;
            comboDSSP.SelectedIndex = 0;
            comboThoiGian.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        //button thong ke theo NV và KH
        private void button1_Click(object sender, EventArgs e)
        {
            //kiem tra da chon cac truong chưa
            if (comboBox3.Items.Count == 1 || comboBox2.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để thống kê và thời gian thống kê");
                return;
            }

            //loaiBo default
            int numOfSeries3 = chart3.Series.Count;
            for (int i = 0; i < numOfSeries3; i++)
            {
                chart3.Series.RemoveAt(0);
            }
            int numOfSeries4 = chart4.Series.Count;
            for (int i = 0; i < numOfSeries4; i++)
            {
                chart4.Series.RemoveAt(0);
            }
            /*
             cần có trong thống kê:
                points
                Series NV
                Thời gian
             */

            //lay listNV
            List<String> listNV = new List<String>();
            for (int i = 1; i < comboBox3.Items.Count; i++)
            {
                listNV.Add(comboBox3.Items[i].ToString());
            }
            //sort lai list NV
            listNV.Sort();
            List<String> listKH = new List<String>();
            listKH = thongKeBUS.getDSKHwithNV(listNV);
            Console.WriteLine("guiNVok");

            //lay thoiGian
            String thoiGian = comboBox2.SelectedItem.ToString().Substring(5); //theo tuan,thang,quy
            //lay begin va end
            DateTime batDau = dateTimePicker3.Value.Date;
            DateTime ketThuc = dateTimePicker4.Value.Date;

            //get Series thống kê doanh thu
            List<Series> series3 = new List<Series>();
            List<Series> series4 = new List<Series>();

            for (int i = 0; i < listNV.Count; i++)
            {
                //series3
                series4.Insert(i, new Series());
                series4[i].ChartArea = "ChartArea1";
                series4[i].ChartType = SeriesChartType.Line;
                series4[i].Legend = "Legend1";
                series4[i].Name = listNV[i] + "(" + (i + 1).ToString() + ")";
            }

            for (int i = 0; i < listKH.Count; i++)
            {
                //series4
                series3.Insert(i, new Series());
                series3[i].ChartArea = "ChartArea1";
                series3[i].ChartType = SeriesChartType.Line;
                series3[i].Legend = "Legend1";
                series3[i].Name = "KH-" + listKH[i] + "(" + (i + 1).ToString() + ")";
            }

            //add point trước khi thêm vào chart
            List<string> listDoanhThu=new List<string>();
            for(int i = 0; i < 3; i++)
            {
                string temp=null;
                listDoanhThu.Add(temp);
            }
            thongKeBUS.getPointNV_KH(listNV,listKH, thoiGian, batDau, ketThuc, series3, series4, listDoanhThu);

            for (int i = 0; i < listNV.Count; i++)
            {
                //them vao chart3
                chart3.Series.Add(series3[i]);
            }
            for (int i = 0; i < listKH.Count; i++)
            {
                //them vao chart4
                chart4.Series.Add(series4[i]);
            }
            textBox1.Text = listDoanhThu[0];
            textBox2.Text = listDoanhThu[1];
            textBox3.Text = listDoanhThu[2];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int indexSelected = comboBox1.SelectedIndex;
                if (indexSelected != 0)
                {
                    if (indexSelected == comboBox1.Items.Count - 1)
                    {
                        for (int i = comboBox1.Items.Count - 2; i > 0; i--) //0 -> n-1;
                        {
                            //lay index khac 0
                            String temp = comboBox1.Items[i].ToString();
                            //move value to danh sach sp
                            comboBox1.Items.RemoveAt(i);
                            comboBox3.Items.Add(temp);
                        }
                    }
                    else
                    {
                        //lay index khac 0
                        String temp = comboBox1.SelectedItem.ToString();
                        //move value to danh sach sp
                        comboBox1.Items.RemoveAt(indexSelected);
                        comboBox3.Items.Add(temp);
                    }
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelected = comboBox3.SelectedIndex;
            if (indexSelected != 0)
            {
                //lay index khac 0
                String temp = comboBox3.SelectedItem.ToString();
                //remove value in dssp
                comboBox3.Items.RemoveAt(indexSelected);
                //lay toanBoSP ra
                comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
                //them lai SP
                comboBox1.Items.Add(temp);
                //them lai toanBoSP
                comboBox1.Items.Add("Toàn bộ NV");
                //set select 0
                comboBox3.SelectedIndex = 0;
            }
        }
    }
}
