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
        Dal_MonHoc dal_mh = new Dal_MonHoc();

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

        public DataTable ds_SV()
        {
            return dal_mh.ds_SinhVien();
        }

        public DataTable ds_SV_MH(string maMH)
        {
            return dal_mh.ds_SinhVien_MonHoc(maMH);
        }
    }
}
