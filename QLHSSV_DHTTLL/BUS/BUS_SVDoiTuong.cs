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
    public class BUS_SVDoiTuong
    {
        Dal_SVDoiTuong dal_svdt = new Dal_SVDoiTuong();
        //thêm DT
        public bool themDT(DTO_SVDoiTuong pDT)
        {
            return dal_svdt.themDT(pDT);
        }

        // Sửa DT
        public bool suaDT(DTO_SVDoiTuong pDT)
        {
            return dal_svdt.suaDT(pDT);
        }

        // Xóa DT
        public bool xoaDT(string maSV, string maDT)
        {
            return dal_svdt.xoaDT(maSV, maDT);
        }

        public DataTable SV()
        {
            return dal_svdt.SV();
        }

        public DataTable DT()
        {
            return dal_svdt.DT();
        }

        public DataTable DSSVDT(string maSV)
        {
            return dal_svdt.DSSVDT(maSV);
        }

    }
}
