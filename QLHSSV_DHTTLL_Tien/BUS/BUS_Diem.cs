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
        DAL_Diem dal_di = new DAL_Diem();

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
        public bool xoaDiem(string maSV, string maMH)
        {
            return dal_di.xoaDiem(maSV, maMH);
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
