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
   public class BUS_MonHoc
    {
       DAL_MonHoc dal_mh = new DAL_MonHoc();

       //thêm KT
       public bool themMH(DTO_MonHoc pKT)
       {
           return dal_mh.themMH(pKT);
       }

       // Sửa KT
       public bool suaMH(DTO_MonHoc pKT)
       {
           return dal_mh.suaMH(pKT);
       }

       // Xóa KT
       public bool xoaMH(String maMH)
       {
           return dal_mh.xoaMH(maMH);
       }

       public DataTable MonHoc()
       {
           return dal_mh.MonHoc();
       }
    }
}
