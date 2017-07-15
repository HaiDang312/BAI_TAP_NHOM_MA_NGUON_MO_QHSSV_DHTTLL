using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_KyLuat:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable KL()
        {
            da = new SqlDataAdapter("SELECT * FROM KYLUAT", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // thêm KL
        public bool themKL(DTO_KyLuat pKL)
        {
            dbConn.Open();
            string cmd = "INSERT INTO KYLUAT VALUES(N'" + pKL.MaKL + "',N'" + pKL.TenKL + "',N'" + pKL.GhiChu + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa KL
        public bool suaKL(DTO_KyLuat pKL)
        {
            dbConn.Open();
            string cmd = "UPDATE KYLUAT SET TENKL=N'" + pKL.TenKL + "',GHICHU='" + pKL.GhiChu + "' WHERE MAKL='" + pKL.MaKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa KL
        public bool xoaKL(string maKL)
        {
            dbConn.Open();
            string cmd = "DELETE FROM KYLUAT WHERE MAKL='" + maKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
