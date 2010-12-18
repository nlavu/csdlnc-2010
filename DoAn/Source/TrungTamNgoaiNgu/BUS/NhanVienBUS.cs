using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        #region Insert
        public static bool Insert (NhanVienDTO nv)
        {
            bool result = false;
            try
            {
                bool temp = NhanVienDAO.IsNhanVienExist(nv);
                Console.WriteLine(temp);
                
            }
            catch (Exception ex)
            {
            
            }
            return result;
        }

        public void temp() { }
        #endregion
    }
}
