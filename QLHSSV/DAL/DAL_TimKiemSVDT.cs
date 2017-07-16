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
    public class DAL_TimKiemSVDT:connect
    {
        public bool timKiemSVDT(string maSV)
        {
            dbConn.Open();
            string cmd = "select svdt.MASV, HOSV, TENSV, TENLOP, TENKHOA, dt.MADT, TENDOITUONG, CHEDOMIENGIAM from SINHVIEN sv join LOP lp on sv.MALOP=lp.MALOP join KHOA kh on lp.MAKHOA= kh.MAKHOA join SV_DOITUONG svdt on sv.MASV=svdt.MASV join DOITUONG dt on svdt.MADT=dt.MADT  WHERE svdt.MASV LIKE '%" + maSV + "%'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
