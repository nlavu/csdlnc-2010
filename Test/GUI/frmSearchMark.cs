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
    public partial class frmSearchMark : Form
    {
        #region Retrieving
        public frmSearchMark()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
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
                    string maHocVien = txtMaHocVien.Text;
                    dtgvDiemThi.DataSource = KetQuaMonBUS.LayDiemThiCuaHocVien(maHocVien);
                    dtgvDiemThi.AutoResizeColumns();

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
                if (txtMaHocVien.Text == "")
                {
                    chuoiLenh = "Xin nhập mã học viên.";
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
                txtMaHocVien.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
