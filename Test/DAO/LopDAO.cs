using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class LopDAO
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
        public static DataTable LayDanhSachLop()
        {
            try
            {
                SqlConnection connect = new SqlConnection();
                connect.ConnectionString = SqlDataAccessHelper.ConnectionString;
                connect.Open();
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = "sp_Lay_DanhSach_Lop";
                cmd.CommandType = CommandType.StoredProcedure;
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
