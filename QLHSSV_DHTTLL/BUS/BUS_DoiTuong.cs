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
    public class BUS_DoiTuong
    {
        Dal_DoiTuong dal_DT = new Dal_DoiTuong();

        public bool themLop(DTO_DoiTuong pDT)
        {
            return dal_DT.themLop(pDT);
        }

        public bool suaLop(DTO_DoiTuong pDT)
        {
            return dal_DT.suaLop(pDT);
        }

        public bool xoaLop(String maDT)
        {
            return dal_DT.xoaLop(maDT);
        }
        public DataTable DoiTuong()
        {
            return dal_DT.DoiTuong();
        }
    }
}
