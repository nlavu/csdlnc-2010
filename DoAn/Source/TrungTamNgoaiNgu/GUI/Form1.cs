using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbTest.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String chuoiLenh = KiemTra();
            lbTest.Visible = true;
            if (chuoiLenh.ToString() != "")
            {
                lbTest.ForeColor = Color.Red;
                lbTest.Text = chuoiLenh.ToString();
            }
            else
            {

                HocVienDTO hv = new HocVienDTO();
                hv.tenHocVien = txtHoTen.Text;
                hv.soDienThoaiHV = txtDienThoai.Text;

                bool result = HocVienBUS.Insert(hv);
                if (result == true)
                {
                    lbTest.ForeColor = Color.Blue;
                    lbTest.Text = hv.maHocVien;
                    ResetForm();
                }
                else
                {
                    lbTest.ForeColor = Color.Red;
                    lbTest.Text = "Tạo học viên thất bại";
                }
            }

            //frmDangKyHoc form = new frmDangKyHoc();
            //form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private String KiemTra()
        {
            String chuoiLenh = "";
            if (txtHoTen.Text == "")
            {
                chuoiLenh = "Xin bạn nhập tên";
            }
            else if (txtDienThoai.Text == "")
            {
                chuoiLenh = "Xin bạn nhập số điện thoại";
            }
            return chuoiLenh;
        }

        private void ResetForm()
        {
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
        }

        private void lbTest_Click(object sender, EventArgs e)
        {

        }
    }
}
