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
    public class BUS_LoaiHB
    {
        DAL_LoaiHB dal_loaihb = new DAL_LoaiHB();

        //thêm LHB
        public bool themLHB(DTO_LoaiHB pLHB)
        {
            return dal_loaihb.themLHB(pLHB);
        }

        // Sửa LHB
        public bool suaLHB(DTO_LoaiHB pLHB)
        {
            return dal_loaihb.suaLHB(pLHB);
        }

        // Xóa LHB
        public bool xoaLHB(String maLHB)
        {
            return dal_loaihb.xoaLHB(maLHB);
        }

        public DataTable LoaiHB()
        {
            return dal_loaihb.LoaiHB();
        }

    }
}
