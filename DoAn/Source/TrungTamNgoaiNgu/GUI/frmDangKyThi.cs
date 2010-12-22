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
       public partial class frmDangKyThi : Form
   {
        public frmDangKyThi()
        {
            InitializeComponent();
            lbTest.Visible = false;
        }

       private void btDangKy_Click(object sender, EventArgs e)
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
                ThiSinhDTO ts = new ThiSinhDTO();
                ts.tenThiSinh = txtHoTen.Text;
                ts.soDienThoaiTS = txtSoDT.Text;

                bool resultts = ThiSinhBUS.Insert(ts);
                if ( resultts == true )
                {
                    lbTest.ForeColor = Color.Blue;
                    lbTest.Text = "Đăng ký thi thành công";
                    ResetForm();
                }
                else
                {
                    lbTest.ForeColor = Color.Red;
                    lbTest.Text = "Đăng ký thất bại";
                }
            }
        }               
        private String KiemTra()
        {
            String chuoiLenh = "";
            if (txtHoTen.Text == "")
            {
                chuoiLenh = "Xin bạn nhập tên";
            }
            else if (txtSoDT.Text == "")
            {
                chuoiLenh = "Xin bạn nhập số điện thoại";
            }
            return chuoiLenh;
        }
        private void ResetForm()
        {
           txtHoTen.Text = "";
           txtSoDT.Text = "";
        }
        private void frmDangKyThi_Load(object sender, EventArgs e)
        {
            
        }
    }
}

