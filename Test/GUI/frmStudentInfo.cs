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
    public partial class frmStudentInfo : Form
    {
        #region Retrieving
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoiLenh = KiemTra();
                if (chuoiLenh != "")
                {
                    MessageBox.Show(chuoiLenh);
                }
                else
                {
                    string tenHocVien = txtTenHocVien.Text;
                    dtgvDanhSach.DataSource = HocVienBUS.LayDanhSachHocVien_TenHocVien(tenHocVien);
                    dtgvDanhSach.AutoResizeColumns();

                    LamSach();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dtgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgvDanhSach.CurrentRow != null)
                {
                    lbMaHocVien.Text = dtgvDanhSach.CurrentRow.Cells["maHocVien"].Value.ToString();
                    lbTenHocVien.Text = dtgvDanhSach.CurrentRow.Cells["tenHocVien"].Value.ToString();
                    lbNgaySinh.Text = dtgvDanhSach.CurrentRow.Cells["ngaySinh"].Value.ToString();
                    lbDiaChi.Text = dtgvDanhSach.CurrentRow.Cells["diaChi"].Value.ToString();
                    lbDienThoai.Text = dtgvDanhSach.CurrentRow.Cells["dienThoai"].Value.ToString();
                    lbCMND.Text = dtgvDanhSach.CurrentRow.Cells[5].Value.ToString();
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
                if (txtTenHocVien.Text == "")
                {
                    chuoiLenh = "Xin nhập tên học viên.";
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
                txtTenHocVien.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
