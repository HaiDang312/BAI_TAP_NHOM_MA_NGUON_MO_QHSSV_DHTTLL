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
    public class BUS_DoiTuong
    {
        DAL_DoiTuong dal_dt = new DAL_DoiTuong();
        //thêm DT
        public bool themDT(DTO_DoiTuong pDT)
        {
            return dal_dt.themDT(pDT);
        }

        // Sửa DT
        public bool suaDT(DTO_DoiTuong pDT)
        {
            return dal_dt.suaDT(pDT);
        }

        // Xóa DT
        public bool xoaDT(string maDT)
        {
            return dal_dt.xoaDT(maDT);
        }

        public DataTable DT()
        {
            return dal_dt.DT();
        }

    }
}
