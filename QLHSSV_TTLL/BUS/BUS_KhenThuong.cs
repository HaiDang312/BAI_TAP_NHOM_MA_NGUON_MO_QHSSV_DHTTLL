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
    public class BUS_KhenThuong
    {
        Dal_KhenThuong dal_kt = new Dal_KhenThuong();

        //thêm KT
        public bool themKT(DTO_KhenThuong pKT)
        {
            return dal_kt.themKT(pKT);
        }

        // Sửa KT
        public bool suaKT(DTO_KhenThuong pKT)
        {
            return dal_kt.suaKT(pKT);
        }

        // Xóa KT
        public bool xoaKT(String maKT)
        {
            return dal_kt.xoaKT(maKT);
        }

        public DataTable KT()
        {
            return dal_kt.KT();
        }

    }
}
