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
    public class DAL_LoaiHB:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable LoaiHB()
        {
            da = new SqlDataAdapter("SELECT * FROM LOAIHOCBONG", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable SV()
        {
            da = new SqlDataAdapter("SELECT * FROM SINHVIEN", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // thêm LHB
        public bool themLHB(DTO_LoaiHB pLHB)
        {
            dbConn.Open();
            string cmd = "INSERT INTO LOAIHOCBONG VALUES('" + pLHB.MaHB + "',N'" + pLHB.TenHB + "','" + pLHB.MucHB + "', '" + pLHB.SoTien + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa LHB
        public bool suaLHB(DTO_LoaiHB pLHB)
        {
            dbConn.Open();
            string cmd = "UPDATE LOAIHOCBONG SET TENHB=N'" + pLHB.TenHB + "',MUCHB='" + pLHB.MucHB + "', SOTIEN='" + pLHB.SoTien + "' WHERE MAHB='" + pLHB.MaHB + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa LHB
        public bool xoaLHB(String maHB)
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
