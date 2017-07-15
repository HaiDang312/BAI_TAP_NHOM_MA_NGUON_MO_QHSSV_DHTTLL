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
    public class Dal_LoaiHocBong:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable LoaiHB()
        {
            adap = new SqlDataAdapter("SELECT * FROM LOAIHOCBONG", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }
       
        public bool themLoaiHB(DTO_LoaiHocBong pLoaiHB)
        {
            dbConn.Open();
            string cmd = "INSERT INTO LOAIHOCBONG VALUES(N'" + pLoaiHB.MaHB + "',N'" + pLoaiHB.MucHB + "',N'" + pLoaiHB.SoTien + "',N'" + pLoaiHB.TenHB + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaLopLoaiHB(DTO_LoaiHocBong pLoaiHB)
        {
            dbConn.Open();
            string cmd = "UPDATE LOAIHOCBONG SET MUCHB=N'" + pLoaiHB.MucHB + "',SOTIEN='" + pLoaiHB.SoTien + "',TENHB='" + pLoaiHB.TenHB + "'  WHERE MAHB='" + pLoaiHB.MaHB + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaLopLoaiHB(String maHB)
        {
            dbConn.Open();
            string cmd = "DELETE FROM LOAIHOCBONG WHERE MAHB='" + maHB + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
