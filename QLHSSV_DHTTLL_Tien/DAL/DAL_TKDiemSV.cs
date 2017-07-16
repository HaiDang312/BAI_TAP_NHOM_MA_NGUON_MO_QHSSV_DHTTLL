using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TKDiemSV:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable Diem(string maSV)
        {
            da = new SqlDataAdapter("Select MASV, MAMH, HOCKY, DIEMCC, DIEMTX, DIEMGK, DIEMCK, ( DIEMCC + DIEMTX + DIEMGK*3 + DIEMCK*5 )/10 as DiemTongKet From DIEM where MASV like N'%" + maSV + "%'", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public bool timkiem()
        {
            dbConn.Open();
           
            return true;
        }
    }
}
