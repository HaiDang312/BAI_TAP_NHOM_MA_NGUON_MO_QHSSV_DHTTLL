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
    public class DAL_DoiTuong:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        public DataTable DT()
        {
            da = new SqlDataAdapter("SELECT * FROM DOITUONG", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // thêm DT
        public bool themDT(DTO_DoiTuong pDT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO DOITUONG VALUES('" + pDT.MaDT + "',N'" + pDT.TenDT + "','" + pDT.CheDoMG + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa DT
        public bool suaDT(DTO_DoiTuong pDT)
        {
            dbConn.Open();
            string cmd = "UPDATE DOITUONG SET TENDOITUONG=N'" + pDT.TenDT + "',CHEDOMIENGIAM='" + pDT.CheDoMG + "' WHERE MADT='" + pDT.MaDT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa DT
        public bool xoaDT(string maDT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM DOITUONG WHERE MADT='" + maDT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
