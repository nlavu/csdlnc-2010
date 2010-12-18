using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;

namespace DAO
{
    public class LopMoDAO
    {

        #region Retrieving
        public static DataTable LayDanhSachLopMoDuocDangKy(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = SqlDataAccessHelper.ExecuteQuery(sql);
            }
            catch (Exception ex)
            {
                
            }
            return dt;
        }
        #endregion
    }
}
