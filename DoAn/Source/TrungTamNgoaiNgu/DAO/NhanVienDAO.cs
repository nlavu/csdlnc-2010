using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class NhanVienDAO
    {
        #region Insert
        public static bool Insert(NhanVienDTO nv)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams =  new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@hoTen", nv.hoTen));
                sqlParams.Add(new SqlParameter("@diaChi", nv.diaChi));
                sqlParams.Add(new SqlParameter("@soDienThoai", nv.soDienThoai));
                sqlParams.Add(new SqlParameter("@username", nv.username));
                sqlParams.Add(new SqlParameter("@password", nv.password));
                sqlParams.Add(new SqlParameter("@maChucVu", nv.maChucVu));

                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_NhanVien_Insert", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }
            if (result == false) { Console.WriteLine("Insert NhanVien Fail"); }
            return result;
        }
        #endregion

        #region Delete
        public static bool Delete(NhanVienDTO nv)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@maNhanVien", nv.maNhanVien));

                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_NhanVien_Delete", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (result == false) { Console.WriteLine("Delete NhanVien Fail"); }
            return result;
        }
        #endregion

        #region Update
        public static bool Update(NhanVienDTO nv)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@maNhanVien", nv.maNhanVien));
                sqlParams.Add(new SqlParameter("@hoTen", nv.hoTen));
                sqlParams.Add(new SqlParameter("@diaChi", nv.diaChi));
                sqlParams.Add(new SqlParameter("@soDienThoai", nv.soDienThoai));
                sqlParams.Add(new SqlParameter("@username", nv.username));
                sqlParams.Add(new SqlParameter("@password", nv.password));
                sqlParams.Add(new SqlParameter("@maChucVu", nv.maChucVu));

                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_NhanVien_Update", sqlParams);
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (result == false) { Console.WriteLine("Update NhanVien Fail"); }
            return result;
        }
        #endregion

        #region Retrieving
        public static bool IsNhanVienExist(NhanVienDTO nv) 
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@maNhanVien", nv.maNhanVien));

                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_NhanVien_IsNhanVienExist", sqlParams);
                if (n == 0)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public static bool IsUsernameExist(NhanVienDTO nv)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@username", nv.username));

                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_NhanVien_IsUsernameExist", sqlParams);
                if (n == 0)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        #endregion
    }
}
