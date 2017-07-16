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
    public class DAL_HocBong:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable HB()
        {
            da = new SqlDataAdapter("SELECT * FROM HOCBONG", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // hàm lấy dữ liệu từ csdl
        public DataTable HB_DS()
        {
            string cmd = "SELECT * FROM HOCBONG";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // hàm lấy dữ liệu từ csdl
        public DataTable SV_DS()
        {
            string cmd = "SELECT * FROM HOCBONG";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // thêm HB
        public bool themHB(DTO_HocBong pHB)
        {
            dbConn.Open();
            string cmd = "INSERT INTO HOCBONG VALUES('" + pHB.MaHB + "','" + pHB.MaSV + "','" + pHB.HocKy + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa HB
        public bool suaHB(DTO_HocBong pHB)
        {
            dbConn.Open();
            string cmd = "UPDATE HOCBONG SET MASV='" + pHB.MaSV + "',HOCKY='" + pHB.HocKy + "' WHERE MAHB='" + pHB.MaHB + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa HB
        public bool xoaHB(string maHB, string maSV)
        {
            dbConn.Open();
            string cmd = "DELETE FROM HOCBONG WHERE MAHB='" + maHB + "' AND MASV='" + maSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
