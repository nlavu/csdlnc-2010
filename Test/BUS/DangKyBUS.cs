using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class DangKyBUS
    {
        #region 1. Inserting
        public static bool GhiDanh(HocVienDTO hv, DangKyDTO dk)
        {
            try
            {
                return DangKyDAO.GhiDanh(hv, dk);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 2. Updating
        // Cần thì thêm vào
        #endregion

        #region 3. Deleting
        // Cần thì thêm vào
        #endregion

        #region 4. Retrieving
        public static DataTable LayDanhSachHocVien(string maLopMo)
        {
            try
            {
                return DangKyDAO.LayDanhSachHocVien(maLopMo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
