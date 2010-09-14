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
    public partial class frmCourseInfo : Form
    {
        #region Retrieving
        public frmCourseInfo()
        {
            InitializeComponent();
        }

        private void frmCourseInfo_Load(object sender, EventArgs e)
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
                DataTable dt =  LopBUS.LayDanhSachLop();
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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            try
            {
                dtgvThongTin.Rows.Clear();
                string maLop = "";
                if (cbCourse.SelectedIndex != -1)
                {
                    maLop = cbCourse.SelectedValue.ToString();
                }
                string chuoiLenh = "sp_Lay_DanhSach_LopMo_TheoMaLop";
                if (maLop == "")
                {
                    chuoiLenh = "sp_Lay_DanhSach_LopMo";
                }

                DataTable dt = LopMoBUS.LayDanhSachLopMo(chuoiLenh, maLop);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtgvThongTin.Rows.Add(i + 1, dt.Rows[i]["maLopMo"], dt.Rows[i]["phongHoc"], dt.Rows[i]["ngayHoc"], dt.Rows[i]["gioHoc"], dt.Rows[i]["ngayBatDau"], dt.Rows[i]["ngayKetThuc"], dt.Rows[i]["siSo"]);
                }
                dtgvThongTin.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region LamSachText
        public void LamSach()
        {
            try
            {
                cbCourse.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
