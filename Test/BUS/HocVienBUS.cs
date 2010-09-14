using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class HocVienBUS
    {
        #region 1. Inserting
        // Cần thì thêm vào
        #endregion

        #region 2. Updating
        // Cần thì thêm vào
        #endregion

        #region 3. Deleting
        // Cần thì thêm vào
        #endregion

        #region 4. Retrieving
        public static List<HocVienDTO> LayDanhSachHocVien_TenHocVien(string tenHocVien)
        {
            try
            {
                return HocVienDAO.LayDanhSachHocVien_TenHocVien(tenHocVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
