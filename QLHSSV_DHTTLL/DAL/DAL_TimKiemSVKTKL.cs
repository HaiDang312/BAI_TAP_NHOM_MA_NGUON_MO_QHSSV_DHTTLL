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
    public class DAL_TimKiemSVKTKL:connect
    {

        public bool timKiemSVKT(string maSV)
        {
            dbConn.Open();
            string cmd = "select qtkt.MASV, HOSV, TENSV, lp.TENLOP, kh.TENKHOA, kt.MAKT, TENKT, NGAYKT, GHICHU from SINHVIEN sv join LOP lp on sv.MALOP=lp.MALOP join KHOA kh on lp.MAKHOA=kh.MAKHOA join QTKHENTHUONG qtkt on sv.MASV=qtkt.MASV join KHENTHUONG kt on qtkt.MAKT=kt.MAKT WHERE qtkt.MASV LIKE '%" + maSV + "%'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        public bool timKiemSVKL(string maSV)
        {
            dbConn.Open();
            string cmd = "select qtkl.MASV, HOSV, TENSV, lp.TENLOP, kh.TENKHOA, kl.MAKL, TENKL, NGAYKL,NGAYHH, GHICHU from SINHVIEN sv join LOP lp on sv.MALOP=lp.MALOP join KHOA kh on lp.MAKHOA=kh.MAKHOA join QTKYLUAT qtkl on sv.MASV=qtkl.MASV join KYLUAT kl on qtkl.MAKL=kl.MAKL WHERE qtkl.MASV LIKE '%" + maSV + "%'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

    }
}
