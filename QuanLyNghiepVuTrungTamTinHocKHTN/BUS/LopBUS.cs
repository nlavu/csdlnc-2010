using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class LopBUS
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
        public static DataTable LayDanhSachLop()
        {
            try
            {
                return LopDAO.LayDanhSachLop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
