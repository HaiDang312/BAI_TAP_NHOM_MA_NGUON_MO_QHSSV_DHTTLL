using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Dal_DangNhap:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable DangNhap()
        {
            adap = new SqlDataAdapter("SELECT * FROM DANGNHAP", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public bool themDN(DTO_DangNhap pDN)
        {
            dbConn.Open();
            string cmd = "INSERT INTO DANGNHAP VALUES(N'" + pDN.Id + "',N'" + pDN.HoTen + "',N'" + pDN.TenDN + "',N'" + pDN.MK1 + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaDN(DTO_DangNhap pDN)
        {
            dbConn.Open();
            string cmd = "UPDATE DANGNHAP SET id=N'" + pDN.Id + "', hoTen=N'" + pDN.HoTen + "', tenDangNhap='" + pDN.TenDN + "',matKhau='" + pDN.MK1 + "' WHERE id='" + pDN.Id + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaDN(String id)
        {
            dbConn.Open();
            string cmd = "DELETE FROM DANGNHAP WHERE id='" + id + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
