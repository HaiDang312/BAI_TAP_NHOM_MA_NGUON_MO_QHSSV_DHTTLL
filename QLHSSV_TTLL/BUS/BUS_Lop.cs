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
    public class BUS_Lop
    {
        Dal_Lop dal_Lop = new Dal_Lop(); // Tạo đối tượng dal_Lop

        // Thêm lớp
        public bool themLop(DTO_Lop pLop)
        {
            return dal_Lop.themLop(pLop); // gọi hàm thêm lớp bên Dal_Lop
        }

        // Sửa lớp
        public bool suaLop(DTO_Lop pLop)
        {
            return dal_Lop.suaLop(pLop);  // gọi hàm sửa lớp bên Dal_Lop
        }

        // Xóa lớp
        public bool xoaLop(String maLop)
        {
            return dal_Lop.xoaLop(maLop);  // gọi hàm xóa lớp bên Dal_Lop
        }

        // In danh sách lớp
        public DataTable LOP()
        {
            return dal_Lop.LOP();  // gọi hàm lớp bên Dal_Lop
        }
        // In danh sách khoa
        public DataTable KHOA()
        {
            return dal_Lop.Khoa_DS();  // gọi hàm khia bên Dal_Lop
        }
    }
}
