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
    public class DAL_SVDoiTuong:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl
        public DataTable SV()
        {
            string cmd = "SELECT * FROM SINHVIEN";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // hàm lấy dữ liệu từ csdl
        public DataTable DT()
        {
            string cmd = "SELECT * FROM DOITUONG";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // hàm lấy dữ liệu từ csdl
        public DataTable DSSVDT(string maSV)
        {
            string cmd = "select svdt.MASV, HOSV, TENSV, TENLOP, TENKHOA, dt.MADT, TENDOITUONG, CHEDOMIENGIAM from SINHVIEN sv join LOP lp on sv.MALOP=lp.MALOP join KHOA kh on lp.MAKHOA= kh.MAKHOA join SV_DOITUONG svdt on sv.MASV=svdt.MASV join DOITUONG dt on svdt.MADT=dt.MADT  WHERE svdt.MASV LIKE '%" + maSV + "%'";
            da = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // thêm DT
        public bool themDT(DTO_SVDoiTuong pDT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO SV_DOITUONG VALUES('" + pDT.MaSV+ "','" + pDT.MaDT + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa DT
        public bool suaDT(DTO_SVDoiTuong pDT)
        {
            dbConn.Open();
            string cmd = "UPDATE SV_DOITUONG SET MADT='" + pDT.MaDT + "' WHERE MASV='" + pDT.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa DT
        public bool xoaDT(string maSV, string maDT)
        {
            dbConn.Open();
            string cmd = "DELETE FROM SV_DOITUONG WHERE MASV='" + maSV + "' AND MADT='" + maDT + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
