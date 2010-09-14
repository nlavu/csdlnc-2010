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
    public partial class frmClassInfo : Form
    {
        #region Retrieving
        public frmClassInfo()
        {
            InitializeComponent();
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClassInfo_Load(object sender, EventArgs e)
        {
            try
            {
                CapNhatCBX_Course();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CapNhatCBX_Course()
        {
            try
            {
                DataTable dt = LopBUS.LayDanhSachLop();
                cbCourse.DataSource = dt;
                cbCourse.ValueMember = "maLop";
                cbCourse.DisplayMember = "tenLop";
                cbCourse.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CapNhatCBX_Class()
        {
            try
            {
                string chuoiLenh = "sp_Lay_DanhSach_LopMo_TheoMaLop";
                string maLop = cbCourse.SelectedValue.ToString();
                DataTable dt = LopMoBUS.LayDanhSachLopMo(chuoiLenh, maLop);
                cbClass.DataSource = dt;
                cbClass.ValueMember = "maLopMo";
                cbClass.DisplayMember = "maLopMo";
                cbClass.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbCourse_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CapNhatCBX_Class();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbClass_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string maLopMo = cbClass.SelectedValue.ToString();
                dtgvDanhSachHocVien.Rows.Clear();

                DataTable dt = LopMoBUS.LayThongTinLopMo(maLopMo);

                lbSiSo.Text = dt.Rows[0]["siSo"].ToString();
                lbGioHoc.Text = dt.Rows[0]["gioHoc"].ToString();
                lbPhongHoc.Text = dt.Rows[0]["phongHoc"].ToString();
                lbNgayHoc.Text = dt.Rows[0]["ngayHoc"].ToString();
                lbNgayBatDau.Text = dt.Rows[0]["ngayBatDau"].ToString();
                lbNgayKetThuc.Text = dt.Rows[0]["ngayKetThuc"].ToString();

                dt = DangKyBUS.LayDanhSachHocVien(maLopMo);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtgvDanhSachHocVien.Rows.Add(i + 1, dt.Rows[i]["tenHocVien"], dt.Rows[i]["ngaySinh"], dt.Rows[i]["diaChi"], dt.Rows[i]["dienThoai"], dt.Rows[i]["CMND"], dt.Rows[i]["dongTien"]);
                }
                dtgvDanhSachHocVien.AutoResizeColumns();                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion
    }
}
