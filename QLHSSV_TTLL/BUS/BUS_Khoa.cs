using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Khoa
    {
        Dal_Khoa dal_Khoa = new Dal_Khoa(); // Tạo đối tượng dal_Khoa

        // Thêm khoa
        public bool themKhoa(DTO_Khoa pKhoa)
        {
            return dal_Khoa.themKhoa(pKhoa); // gọi hàm thêm khoa bên DAL
        }

        // Sửa khoa
        public bool suaKhoa(DTO_Khoa pKhoa)
        {
            return dal_Khoa.suaKhoa(pKhoa);  // gọi hàm sửa khoa bên DAL
        }

        // Xóa khoa
        public bool xoaKhoa(String maKhoa)
        {
            return dal_Khoa.xoaKhoa(maKhoa); // gọi xóa thêm khoa bên DAL
        }

        // In danh sách khoa
        public DataTable KHOA()
        {
            return dal_Khoa.Khoa_DS();   // gọi hàm khoa bên DAL
        }
    }
}
