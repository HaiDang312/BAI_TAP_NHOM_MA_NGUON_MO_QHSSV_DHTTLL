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
    public class BUS_LoaiHocBong
    {
        Dal_LoaiHocBong dal_LoaiHB = new Dal_LoaiHocBong();

        public bool themLoaiHB(DTO_LoaiHocBong pLoaiHB)
        {
            return dal_LoaiHB.themLoaiHB(pLoaiHB);
        }

        public bool suaLoaiHB(DTO_LoaiHocBong pLoaiHB)
        {
            return dal_LoaiHB.suaLopLoaiHB(pLoaiHB);
        }

        public bool xoaLoaiHB(String maLoaiHB)
        {
            return dal_LoaiHB.xoaLopLoaiHB(maLoaiHB);
        }

        public DataTable LoaiHB()
        {
            return dal_LoaiHB.LoaiHB();
        }
    }
}
