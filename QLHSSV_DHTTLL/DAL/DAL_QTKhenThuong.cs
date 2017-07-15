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
    public class DAL_QTKhenThuong:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable SV()
        {
            da = new SqlDataAdapter("SELECT * FROM SINHVIEN", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable KT()
        {
            da = new SqlDataAdapter("SELECT * FROM KHENTHUONG", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable DSSVKT(string maSV)
        {
            da = new SqlDataAdapter("select qtkt.MASV, HOSV, TENSV, lp.TENLOP, kh.TENKHOA, kt.MAKT, TENKT, NGAYKT, GHICHU from SINHVIEN sv join LOP lp on sv.MALOP=lp.MALOP join KHOA kh on lp.MAKHOA=kh.MAKHOA join QTKHENTHUONG qtkt on sv.MASV=qtkt.MASV join KHENTHUONG kt on qtkt.MAKT=kt.MAKT WHERE qtkt.MASV LIKE '%" + maSV + "%'", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // thêm QTKT
        public bool themQTKT(DTO_QTKhenThuong pQTKT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO QTKHENTHUONG VALUES(N'" + pQTKT.MaSV + "','" + pQTKT.MaKT+ "',N'" + pQTKT.NgayKT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa QTKT
        public bool suaQTKT(DTO_QTKhenThuong pQTKT)
        {
            dbConn.Open();
            string cmd = "UPDATE QTKHENTHUONG SET MAKT='" + pQTKT.MaKT + "',NGAYKT='" + pQTKT.NgayKT + "' WHERE MASV='" + pQTKT.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa QTKT
        public bool xoaQTKT(string maSV, string maKT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM QTKHENTHUONG WHERE MASV ='"+maSV+"' AND MAKT='" + maKT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
