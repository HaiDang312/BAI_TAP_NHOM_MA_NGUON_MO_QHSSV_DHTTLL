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
    public class Dal_SinhVien:connect
    {
        SqlDataAdapter adap;
        DataTable dt;

        public DataTable SinhVien()
        {
            adap = new SqlDataAdapter("SELECT MASV as [Ma SV],HOSV,TENSV,MALOP,MAKHOA,MANGANH,NGAYSINH,CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,DIACHI,CASE WHEN DOANVIEN='1' THEN 'Có' ELSE 'Không' END, NGAYVD, NOIKETNAP,SOCMND,NGAYCAP,NOICAP,HEDAOTAO,NAMTUYENSINH,DANTOC FROM SINHVIEN", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable sinhVien_Lop(string maLop)
        {
            adap = new SqlDataAdapter("SELECT MASV,HOSV,TENSV,MALOP,MAKHOA,MANGANH,NGAYSINH,CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,DIACHI,CASE WHEN DOANVIEN='1' THEN 'Có' ELSE 'Không' END, NGAYVD, NOIKETNAP,SOCMND,NGAYCAP,NOICAP,HEDAOTAO,NAMTUYENSINH,DANTOC FROM SINHVIEN where MALOP='"+maLop+"'", dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable Lop()
        {
            string cmd = "SELECT * FROM LOP";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable Khoa()
        {
            string cmd = "SELECT * FROM KHOA";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public DataTable Nganh()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            adap = new SqlDataAdapter(cmd, dbConn);
            dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }
        public bool themSV(DTO_SinhVien sv)
        {
            dbConn.Open();
            string cmd = "INSERT INTO SINHVIEN VALUES('" + sv.MaSV + "',N'" + sv.HoSV + "', N'" + sv.TenSV + "',N'" + sv.MaLop + "', '" + sv.MaKhoa + "', '" + sv.MaNganh + "', '" + sv.NgaySinh + "', '" + sv.GioiTinh + "', N'" + sv.DiaChi + "', '" + sv.DoanVien + "', '" + sv.NgayVD + "', N'" + sv.NoiKN + "', '" + sv.SoCMND + "', '" + sv.NgayCap + "', N'" + sv.NoiCap + "','" + sv.HeDaoTao + "', '" + sv.NamTuyenSinh + "', N'" + sv.DanToc + "')";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool suaSV(DTO_SinhVien sv)
        {
            dbConn.Open();
            string cmd = "UPDATE SINHVIEN SET HOSV=N'" + sv.HoSV + "', TENSV=N'" + sv.TenSV + "',MALOP='" + sv.MaLop + "', MAKHOA='" + sv.MaKhoa + "', MANGANH='" + sv.MaNganh + "', NGAYSINH='" + sv.NgaySinh + "', GIOITINH='" + sv.GioiTinh + "', DIACHI=N'" + sv.DiaChi + "', DOANVIEN='" + sv.DoanVien + "', NGAYVD='" + sv.NgayVD + "', NOIKETNAP=N'" + sv.NoiKN + "', SOCMND='" + sv.SoCMND + "', NGAYCAP='" + sv.NgayCap + "', NOICAP=N'" + sv.NoiCap + "',HEDAOTAO='" + sv.HeDaoTao + "', NAMTUYENSINH='" + sv.NamTuyenSinh + "', DANTOC=N'" + sv.DanToc + "' WHERE MASV='" + sv.MaSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
        public bool xoaSV(String maSV)
        {
            dbConn.Open();
            string cmd = "DELETE FROM SINHVIEN WHERE MASV='" + maSV + "'";
            SqlCommand sqlCmd = new SqlCommand(cmd, dbConn);
            sqlCmd.ExecuteNonQuery();
            dbConn.Close();
            return true;
        }
    }
}
