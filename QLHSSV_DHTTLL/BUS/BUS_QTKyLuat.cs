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
    public class BUS_QTKyLuat
    {
        DAL_QTKyLuat dal_qtkl = new DAL_QTKyLuat();

        //thêm QTKL
        public bool themQTKL(DTO_QTKyLuat pQTKL)
        {
            return dal_qtkl.themQTKL(pQTKL);
        }

        // Sửa QTKL
        public bool suaQTKL(DTO_QTKyLuat pQTKL)
        {
            return dal_qtkl.suaQTKL(pQTKL);
        }

        // Xóa QTKL
        public bool xoaQTKL(string maSV, string maKL)
        {
            return dal_qtkl.xoaQTKL(maSV, maKL);
        }

        public DataTable KL()
        {
            return dal_qtkl.KL();
        }

        public DataTable DSKL(string maSV)
        {
            return dal_qtkl.DSKL(maSV);
        }
    }
}
