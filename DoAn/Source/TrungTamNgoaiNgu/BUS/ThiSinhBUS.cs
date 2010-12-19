using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class ThiSinhBUS
    {
        #region Insert
        public static bool Insert(ThiSinhDTO ts)
        {
            try
            {
                return ThiSinhDAO.Insert(ts);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
