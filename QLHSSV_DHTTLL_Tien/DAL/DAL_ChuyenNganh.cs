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
    public class DAL_ChuyenNganh:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable ChuyenNganh()
        {
            da = new SqlDataAdapter("SELECT * FROM CHUYENNGANH", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // thêm KT
        public bool themCN(DTO_ChuyenNganh pKT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO CHUYENNGANH VALUES(N'" + pKT.MaChuyenNganh + "',N'" + pKT.TenChuyenNganh + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa KT
        public bool suaCN(DTO_ChuyenNganh pKT)
        {
            dbConn.Open();
            string cmd = "UPDATE CHUYENNGANH SET TENNGANH=N'" + pKT.TenChuyenNganh + "' WHERE MANGANH='" + pKT.MaChuyenNganh + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa KT
        public bool xoaCN(String maCN)
        {
            dbConn.Open();
            string cmd = "DELETE FROM CHUYENNGANH WHERE MANGANH='" + maCN + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
