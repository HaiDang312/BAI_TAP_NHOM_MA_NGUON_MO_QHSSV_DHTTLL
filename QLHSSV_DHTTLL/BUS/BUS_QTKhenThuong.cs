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
    public class BUS_QTKhenThuong
    {
        DAL_QTKhenThuong dal_qtkt = new DAL_QTKhenThuong();
        //thêm QTKT
        public bool themQTKT(DTO_QTKhenThuong pQTKT)
        {
            return dal_qtkt.themQTKT(pQTKT);
        }

        // Sửa QTKT
        public bool suaQTKT(DTO_QTKhenThuong pQTKT)
        {
            return dal_qtkt.suaQTKT(pQTKT);
        }

        // Xóa QTKT
        public bool xoaQTKT(string maSV, string maKT)
        {
            return dal_qtkt.xoaQTKT(maSV, maKT);
        }

        public DataTable KT()
        {
            return dal_qtkt.KT();
        }
        public DataTable SV()
        {
            return dal_qtkt.SV();
        }
        public DataTable DSSVKT(string maSV)
        {
            return dal_qtkt.DSSVKT(maSV);
        }

    }
}
