using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SinhVien
    {
        Dal_SinhVien dal_SV = new Dal_SinhVien(); // Tạo đối tượng dal_SV

        // Thêm sinh viên
        public bool themSV(DTO_SinhVien sv)
        {
            return dal_SV.themSV(sv); // Gọi hàm thêm sinh viên bên Dal_SinhVien
        }
        // Sửa sinh viên
        public bool suaSV(DTO_SinhVien sv)
        {
            return dal_SV.suaSV(sv);  // Gọi hàm sủa sinh viên bên Dal_SinhVien
        }

        // Xóa sinh viên
        public bool xoaSV(String maSV)
        {
            return dal_SV.xoaSV(maSV);   // Gọi hàm xóa sinh viên bên Dal_SinhVien
        }

        // In danh sách sinh viên
        public DataTable SinhVien()
        {
            return dal_SV.SinhVien();  // Gọi hàm sinh viên bên Dal_SinhVien
        }

        // In danh sách lớp
        public DataTable Lop()
        {
            return dal_SV.Lop();  // Gọi hàm lớp bên Dal_SinhVien
        }

        // In danh sách khoa
        public DataTable Khoa()
        {
            return dal_SV.Khoa();  // Gọi hàm khoa bên Dal_SinhVien
        }

        // In danh sách lớp
        public DataTable Nganh()
        {
            return dal_SV.Nganh();  // Gọi hàm ngành bên Dal_SinhVien
        }
    }
}
