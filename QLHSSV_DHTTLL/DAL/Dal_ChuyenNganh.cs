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

    public class Dal_ChuyenNganh:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable Nganh()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public bool themNganh(DTO_ChuyenNganh pNganh)
        {
            dbConn.Open();
            string cmd = "INSERT INTO CHUYENNGANH VALUES(N'" + pNganh.MaNganh + "',N'" + pNganh.TenNganh + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaNganh(DTO_ChuyenNganh pNganh)
        {
            dbConn.Open();
            string cmd = "UPDATE CHUYENNGANH SET TENNGANH=N'" + pNganh.TenNganh + "' WHERE MANGANH='" + pNganh.MaNganh + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaNganh(String maNganh)
        {
            dbConn.Open();
            string cmd = "DELETE FROM CHUYENNGANH WHERE MANGANH='" + maNganh + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        public DataTable SinhVien_DS()
        {
            string cmd = "SELECT SINHVIEN.MASV, HOSV+' '+ TENSV as [Họ Tên SV], TENNGANH, TENLOP, TENKHOA, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH)";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable SinhVien_DSLop(String maNganh)
        {
            string cmd = "SELECT SINHVIEN.MASV, HOSV +' '+ TENSV as [Họ Tên SV], TENNGANH, LOP.TENLOP, TENKHOA, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MANGANH = CHUYENNGANH.MANGANH) and CHUYENNGANH.MANGANH='" + maNganh + "'";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

    }
}
