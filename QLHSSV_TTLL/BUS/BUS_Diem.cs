using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    public class BUS_Diem
    {
        Dal_Diem dal_di = new Dal_Diem();

        //thêm KT
        public bool themDiem(DTO_Diem pKT)
        {
            return dal_di.themDiem(pKT);
        }

        // Sửa KT
        public bool suaDiem(DTO_Diem pKT)
        {
            return dal_di.suaDiem(pKT);
        }

        // Xóa KT
        public bool xoaDiem(String maSV)
        {
            return dal_di.xoaDiem(maSV);
        }

        public DataTable Diem()
        {
            return dal_di.Diem();
        }
        public DataTable MonHoc()
        {
            return dal_di.MonHoc();
        }
    }
}
