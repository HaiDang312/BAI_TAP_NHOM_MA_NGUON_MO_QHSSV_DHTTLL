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
    public class BUS_KyLuat
    {
        DAL_KyLuat dal_kl = new DAL_KyLuat();

        //thêm KL
        public bool themKL(DTO_KyLuat pKL)
        {
            return dal_kl.themKL(pKL);
        }

        // Sửa KL
        public bool suaKL(DTO_KyLuat pKL)
        {
            return dal_kl.suaKL(pKL);
        }

        // Xóa KL
        public bool xoaKL(string maKL)
        {
            return dal_kl.xoaKL(maKL);
        }

        public DataTable KL()
        {
            return dal_kl.KL();
        }

    }
}
