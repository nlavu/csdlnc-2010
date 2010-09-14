using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public class LopMoBUS
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
        public static DataTable LayDanhSachLopMo(string chuoiLenh, string maLop)
        {
            try
            {
                return LopMoDAO.LayDanhSachLopMo(chuoiLenh, maLop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable LayThongTinLopMo(string maLopMo)
        {
            try
            {
                return LopMoDAO.LayThongTinLopMo(maLopMo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
