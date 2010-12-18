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
        #region Insert
        public static bool Insert(HocVienDTO hv)
        {
            bool result = false;
            try
            {
                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("@maHocVien", hv.maHocVien));
                sqlParams.Add(new SqlParameter("@tenHocVien", hv.tenHocVien));
                sqlParams.Add(new SqlParameter("@soDienThoaiHV", hv.soDienThoaiHV));

                sqlParams[0].Direction = ParameterDirection.Output;

                int n = SqlDataAccessHelper.ExecuteNoneQuery("sp_HocVien_Insert", sqlParams);

                hv.maHocVien = sqlParams[0].Value.ToString();
                if (n == 1)
                    result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (result == false) { Console.WriteLine("Insert HocVien Fail"); }
            return result;
        }
        #endregion
    }
}
