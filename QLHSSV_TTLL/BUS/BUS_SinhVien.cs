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
        Dal_SinhVien dal_SV = new Dal_SinhVien();

        public bool themSV(DTO_SinhVien sv)
        {
            return dal_SV.themSV(sv);
        }

        public bool suaSV(DTO_SinhVien sv)
        {
            return dal_SV.suaSV(sv);
        }

        public bool xoaSV(String maSV)
        {
            return dal_SV.xoaSV(maSV);
        }
        public DataTable SinhVien()
        {
            return dal_SV.SinhVien();
        }
        public DataTable Lop()
        {
            return dal_SV.Lop();
        }

        public DataTable Khoa()
        {
            return dal_SV.Khoa();
        }
        public DataTable Nganh()
        {
            return dal_SV.Nganh();
        }
    }
}
