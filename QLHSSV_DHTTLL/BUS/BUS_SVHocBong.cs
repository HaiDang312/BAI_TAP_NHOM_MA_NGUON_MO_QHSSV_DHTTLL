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
    public class BUS_SVHocBong
    {
        Dal_SVHocBong dal_SVHB = new Dal_SVHocBong();

        public bool themSVHB(DTO_SVHocBong pSVHB)
        {
            return dal_SVHB.themSVHB(pSVHB);
        }

        public bool suaSVHB(DTO_SVHocBong pSVHB)
        {
            return dal_SVHB.suaSVHB(pSVHB);
        }

        public bool xoaSVHB(String maHB, String maSV, String hocKy)
        {
            return dal_SVHB.xoaSVHB(maHB,maSV,hocKy);
        }
        public DataTable svHB()
        {
            return dal_SVHB.svHB();
        }

        public DataTable ds_svHB_Lop(string maLop)
        {
            return dal_SVHB.ds_svHB_Lop(maLop);
        }

        public DataTable ds_svHB()
        {
            return dal_SVHB.ds_svHB();
        }
    }
}
