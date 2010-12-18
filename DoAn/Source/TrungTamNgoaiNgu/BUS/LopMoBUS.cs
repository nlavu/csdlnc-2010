using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using DAO;

namespace BUS
{
    public class LopMoBUS
    {

        #region Retrieving
        public static DataTable LayDanhSachLopMoDuocDangKy(String sql)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = LopMoDAO.LayDanhSachLopMoDuocDangKy(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        #endregion
    }
}
