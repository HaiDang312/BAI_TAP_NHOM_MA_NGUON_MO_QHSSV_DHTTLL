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
    public class Dal_SVHocBong:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable svHB()
        {
            adap = new SqlDataAdapter("SELECT * FROM HOCBONG", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable ds_svHB()
        {
            adap = new SqlDataAdapter("SELECT SV.MASV as[Ma SV], HOSV+' '+TENSV as HoTen, MALOP, TENHB, SOTIEN,HOCKY FROM SINHVIEN as SV, HOCBONG as HB , LOAIHOCBONG as LHB where SV.MASV=HB.MASV and HB.MAHB=LHB.MAHB", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable ds_svHB_Lop(string maLop)
        {
            adap = new SqlDataAdapter("SELECT SV.MASV as[Ma SV], HOSV+' '+TENSV as HoTen, MALOP, TENHB, SOTIEN,HOCKY FROM SINHVIEN as SV, HOCBONG as HB , LOAIHOCBONG as LHB where SV.MASV=HB.MASV and HB.MAHB=LHB.MAHB and MALOP='"+maLop+"'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public bool themSVHB(DTO_SVHocBong pHB)
        {
            dbConn.Open();
            string cmd = "INSERT INTO HOCBONG VALUES(N'" + pHB.MaHB + "',N'" + pHB.MaSV + "',N'" + pHB.HocKy + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaSVHB(DTO_SVHocBong pHB)
        {
            dbConn.Open();
            string cmd = "UPDATE LOP SET MAHB=N'" + pHB.MaHB + "',MASV='" + pHB.MaSV + "',HOCKY='" + pHB.HocKy + "' WHERE MAHB='" + pHB.MaHB + "' and MASV='" + pHB.MaSV + "' and HOCKY='" + pHB.HocKy + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaSVHB(String maHB, String maSV, String hocKy )
        {
            dbConn.Open();
            string cmd = "DELETE FROM HOCBONG WHERE MAHB='" + maHB + "' and MASV='" + maSV + "' and HOCKY='" + hocKy + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
