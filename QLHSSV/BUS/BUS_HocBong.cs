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
    public class BUS_HocBong
    {
        DAL_HocBong dal_hb = new DAL_HocBong();
        DAL_LoaiHB dal_lhb = new DAL_LoaiHB();
        //thêm HB
        public bool themHB(DTO_HocBong pHB)
        {
            return dal_hb.themHB(pHB);
        }

        // Sửa HB
        public bool suaHB(DTO_HocBong pHB)
        {
            return dal_hb.suaHB(pHB);
        }

        // Xóa HB
        public bool xoaHB(string maHB, string maSV)
        {
            return dal_hb.xoaHB(maHB, maSV);
        }

        public DataTable HB()
        {
            return dal_hb.HB();
        }

        public DataTable LHB()
        {
            return dal_lhb.LoaiHB();
        }

        public DataTable SV()
        {
            return dal_lhb.SV();
        }

    }
}
