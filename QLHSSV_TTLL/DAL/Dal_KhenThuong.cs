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
    public class Dal_KhenThuong : connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable KT()
        {
            da = new SqlDataAdapter("SELECT * FROM KHENTHUONG", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }



        // thêm KT
        public bool themKT(DTO_KhenThuong pKT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO KHENTHUONG VALUES(N'" + pKT.MaKT + "',N'" + pKT.TenKT + "',N'" + pKT.GhiChu + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa KT
        public bool suaKT(DTO_KhenThuong pKT)
        {
            dbConn.Open();
            string cmd = "UPDATE KHENTHUONG SET TENKT=N'" + pKT.TenKT + "',GHICHU='" + pKT.GhiChu + "' WHERE MAKT='" + pKT.MaKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa KT
        public bool xoaKT(String maKT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM KHENTHUONG WHERE MAKT='" + maKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
