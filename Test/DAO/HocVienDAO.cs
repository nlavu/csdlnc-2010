using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class HocVienDAO
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
            List<HocVienDTO> list = new List<HocVienDTO>();
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@tenHocVien", tenHocVien));

                DataTable dt = SqlDataAccessHelper.ExecuteQuery("spChonHocVienBangTenHocVien", sqlParams);
                foreach (DataRow dr in dt.Rows)
                {
                    HocVienDTO emp = new HocVienDTO();
                    emp.maHocVien = dr["maHocVien"].ToString();
                    emp.tenHocVien = dr["tenHocVien"].ToString();
                    emp.ngaySinh = DateTime.Parse(dr["ngaySinh"].ToString());
                    emp.diaChi = dr["diaChi"].ToString();
                    emp.dienThoai = dr["dienThoai"].ToString();
                    emp.CMND = dr["CMND"].ToString();
                    list.Add(emp);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
        #endregion
    }
}
