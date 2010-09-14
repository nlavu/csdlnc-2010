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
    public partial class frmRegister : Form
    {
        #region Retrieving
        public frmRegister()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            try
            {
                CapNhatCBX();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CapNhatCBX()
        {
            try
            {
                string chuoiLenh = "sp_Lay_DanhSach_LopMo";
                DataTable dt = LopMoBUS.LayDanhSachLopMo(chuoiLenh, "");
                cbCourse.DataSource = dt;
                cbCourse.ValueMember = "maLopMo";
                cbCourse.DisplayMember = "maLopMo";
                cbCourse.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LamSach();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoiLenh = "";
                if (chuoiLenh != "")
                {
                    MessageBox.Show(chuoiLenh);
                }
                else
                {
                    HocVienDTO hv = new HocVienDTO();
                    hv.tenHocVien = txtFullName.Text;
                    hv.ngaySinh = dtBirthday.MinDate;
                    hv.diaChi = txtAddress.Text;
                    hv.dienThoai = txtPhone.Text;
                    hv.CMND = txtCMND.Text;

                    DangKyDTO dk = new DangKyDTO();
                    dk.maLopMo = cbCourse.SelectedValue.ToString();

                    if (checkPremium.Checked == true)
                    {
                        dk.dongTien = "Y";
                    }
                    else
                    {
                        dk.dongTien = "N";
                    }

                    bool result = DangKyBUS.GhiDanh(hv, dk);
                    if (result == true)
                    {
                        MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LamSach();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region KiemTraHopLe
        public string KiemTra()
        {
            string chuoiLenh = "";
            try
            {
                if (txtFullName.Text == "")
                {
                    chuoiLenh = "Xin nhập họ tên.";
                }
                if (txtAddress.Text == "")
                {
                    chuoiLenh = "Xin nhập địa chỉ.";
                }
                if (txtPhone.Text == "")
                {
                    chuoiLenh = "Xin nhập số điện thoại.";
                }
                if (txtCMND.Text == "")
                {
                    chuoiLenh = "Xin nhập CMND.";
                }
                if (cbCourse.SelectedIndex == -1)
                {
                    chuoiLenh = "Xin chọn lớp bạn muốn học.";
                    return chuoiLenh;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return chuoiLenh;
        }
        #endregion

        #region LamSachText
        public void LamSach()
        {
            try
            {
                txtFullName.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtCMND.Text = "";
                cbCourse.SelectedValue = 0;
                checkPremium.Checked = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
