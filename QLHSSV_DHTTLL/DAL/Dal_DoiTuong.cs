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
    public class Dal_DoiTuong:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable DoiTuong()
        {
            adap = new SqlDataAdapter("SELECT * FROM DOITUONG", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }
        
        public bool themLop(DTO_DoiTuong pDT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO DOITUONG VALUES(N'" + pDT.MaDT + "',N'" + pDT.TenDT + "',N'" + pDT.CheDoMienGiam + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaLop(DTO_DoiTuong pDT)
        {
            dbConn.Open();
            string cmd = "UPDATE DOITUONG SET TENDOITUONG=N'" + pDT.TenDT + "',CHEDOMIENGIAM='" + pDT.CheDoMienGiam + "' WHERE MADT='" + pDT.MaDT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaLop(String maDT)
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
