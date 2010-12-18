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
        #region Insert
        public static bool Insert(HocVienDTO hv)
        {
            try
            {
                return HocVienDAO.Insert(hv);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
    }
}
