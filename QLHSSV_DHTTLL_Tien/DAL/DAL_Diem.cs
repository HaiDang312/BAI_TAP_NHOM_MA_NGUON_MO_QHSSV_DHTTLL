using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Diem:connect
    {
        SqlDataAdapter da;
        DataTable dt;

        // hàm lấy dữ liệu từ csdl lên datagridview
        public DataTable Diem()
        {
            da = new SqlDataAdapter("Select MASV, MAMH, HOCKY, DIEMCC, DIEMTX, DIEMGK, DIEMCK, ( DIEMCC + DIEMTX + DIEMGK*3 + DIEMCK*5 )/10 as DiemTongKet From DIEM", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable MonHoc()
        {
            da = new SqlDataAdapter("SELECT * FROM MONHOC", dbConn);
            dt = new DataTable();
            da.Fill(dt);
            dbConn.Close();
            return dt;
        }

        // thêm KT
        public bool themDiem(DTO_Diem pKT)
        {
            dbConn.Open();
            string cmd = "INSERT INTO DIEM VALUES(N'" + pKT.MaSinhVien + "','" + pKT.MaMonHoc + "', '" + pKT.HocKy + "', '"+ pKT.DiemCC+"', '" + pKT.DiemTX +"', '"+ pKT.DiemGK +"', '"+ pKT.DiemCK +"')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Sửa KT
        public bool suaDiem(DTO_Diem pKT)
        {
            dbConn.Open();
            string cmd = "UPDATE DIEM SET MAMH=N'" + pKT.MaMonHoc + "',HOCKY='" + pKT.HocKy + "', DIEMCC='"+ pKT.DiemCC +"', DIEMTX= '"+ pKT.DiemTX +"', DIEMGK= '"+ pKT.DiemGK + "', DIEMCK= '"+ pKT.DiemCK + "'  WHERE MASV='" + pKT.MaSinhVien + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }

        // Xóa KT
        public bool xoaDiem(string maSV, string maMH)
        {
            dbConn.Open();
            string cmd = "DELETE FROM DIEM WHERE MASV='" + maSV + "' AND MAMH='" + maMH + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
