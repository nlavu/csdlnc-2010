using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DangKyDAO
    {
        #region 1. Inserting
        public static bool GhiDanh(HocVienDTO hv, DangKyDTO dk)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@tenHocVien", hv.tenHocVien));
                sqlParams.Add(new SqlParameter("@ngaySinh", hv.ngaySinh));
                sqlParams.Add(new SqlParameter("@diaChi", hv.diaChi));
                sqlParams.Add(new SqlParameter("@dienThoai", hv.dienThoai));
                sqlParams.Add(new SqlParameter("@CMND", hv.CMND));
                sqlParams.Add(new SqlParameter("@maLopMo", dk.maLopMo));
                sqlParams.Add(new SqlParameter("@dongTien", dk.dongTien));
                // Call Store Procedure
                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_GhiDanh", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
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
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = SqlDataAccessHelper.ConnectionString;
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "sp_Lay_DanhSach_HocVien_HocLop";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maLopMo", maLopMo));
                cmd.ExecuteNonQuery();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                connect.Close();
                return table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
