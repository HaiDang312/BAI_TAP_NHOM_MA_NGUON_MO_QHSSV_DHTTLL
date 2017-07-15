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
    public class DAL_QTKyLuat:connect
    {
        SqlDataAdapter da;
        DataTable dt;
        public DataTable KL()
        {
            da = new SqlDataAdapter("SELECT * FROM KYLUAT", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable DSKL( string maSV)
        {
            da = new SqlDataAdapter("select qtkl.MASV, HOSV, TENSV, lp.TENLOP, kh.TENKHOA, kl.MAKL, TENKL, NGAYKL,NGAYHH, GHICHU from SINHVIEN sv join LOP lp on sv.MALOP=lp.MALOP join KHOA kh on lp.MAKHOA=kh.MAKHOA join QTKYLUAT qtkl on sv.MASV=qtkl.MASV join KYLUAT kl on qtkl.MAKL=kl.MAKL WHERE qtkl.MASV LIKE '%" + maSV + "%'", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        // thêm QTKL
        public bool themQTKL(DTO_QTKyLuat pQTKL)
        {
            dbConn.Open();
            string cmd = "INSERT INTO QTKYLUAT VALUES(N'" + pQTKL.MaSV + "','" + pQTKL.MaKL + "','" + pQTKL.NgayKL + "' ,'" + pQTKL.NgayHH + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa QTKT
        public bool suaQTKL(DTO_QTKyLuat pQTKL)
        {
            dbConn.Open();
            string cmd = "UPDATE QTKYLUAT SET MAKL='" + pQTKL.MaKL + "',NGAYKL='" + pQTKL.NgayKL + "',NGAYHH='" + pQTKL.NgayHH + "' WHERE MASV='" + pQTKL.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa QTKT
        public bool xoaQTKL(string maSV, string maKL)
        {
            dbConn.Open();
            string cmd = "DELETE FROM  QTKYLUAT WHERE MASV ='" + maSV + "' AND MAKL='" + maKL + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
