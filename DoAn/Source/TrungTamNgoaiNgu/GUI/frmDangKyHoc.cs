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
    public partial class frmDangKyHoc : Form
    {
        public frmDangKyHoc()
        {
            InitializeComponent();
            DuaThongTinVaoComboBox("sp_LopMo_LayDanhSachDuocDangKy",cbxLopMo, "maLopMo", "maLopMo");
            Reset();
        }

        #region Retrieving
        public void DuaThongTinVaoComboBox(String chuoiLenh, ComboBox cbx, String valueMember, String displayMember)
        {
            DataTable dt = LopMoBUS.LayDanhSachLopMoDuocDangKy(chuoiLenh);
            cbxLopMo.DataSource = dt;
            cbxLopMo.ValueMember = valueMember;
            cbxLopMo.DisplayMember = displayMember;
            cbxLopMo.SelectedIndex = -1;
        }

        public void Reset()
        {
            cbxLopMo.SelectedItem = -1;
            checkBoxFlag.Checked = false;
            gbxNhapMa.Enabled = false;
            gbxNhapThongTin.Enabled = true;

            lbThongBao.Visible = false;
        }
        
        public String KiemTra()//kiểm tra dữ liệu người dùng có nhập vào đúng ko
        {
            String chuoiLenh = "";// khởi tạo chuỗi lệnh rộng
            if (cbxLopMo.SelectedIndex == -1) // nếu không chọn lớp
            {
                chuoiLenh = "Bạn chưa chọn lớp!";
            }
            else if (checkBoxFlag.Checked == false)
            {
                if (txtTenHocVien.Text == "")
                {
                    chuoiLenh = "Bạn chưa nhập tên học viên!";
                }
                else
                    return chuoiLenh;
            }
            else if (checkBoxFlag.Checked == true)
            {
                if(txtMaHocVien.Text == "")
                {
                    chuoiLenh = "Bạn chưa nhập mã học viên!";
                }
            }
            

            return chuoiLenh;
        }
        #endregion

        #region Event
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            String chuoiLenh = KiemTra();
            try
            {
                if (chuoiLenh != "")
                {
                    lbThongBao.Visible = true;
                    lbThongBao.ForeColor = Color.Red;
                    lbThongBao.Text = chuoiLenh;
                }
                else
                {
                    //Neu nhap thong tin hoc vien - Insert HocVien - Va tra ve ma hoc vien vua insert - HocVienBus.Insert()
                    
                    // Insert vao DangKy - DangKyBUS.Insert

                    chuoiLenh = "Đăng ký thành công";
                    lbThongBao.Visible = true;
                    lbThongBao.ForeColor = Color.Blue;
                    lbThongBao.Text = chuoiLenh;
                    Reset();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFlag.Checked == false)
            {
                gbxNhapMa.Enabled = false;
                gbxNhapThongTin.Enabled = true;
            }
            else
            {
                gbxNhapMa.Enabled = true;
                gbxNhapThongTin.Enabled = false;
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
