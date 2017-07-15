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
    public class BUS_TimKiemSVKTKL
    {
        DAL_TimKiemSVKTKL dal_timkiem = new DAL_TimKiemSVKTKL();
        // tìm kiếm sinh viên trong diện khen thưởng
        public bool timSVKT(string maSV)
        {
            return dal_timkiem.timKiemSVKT(maSV);
        }
        public bool timSVKL(string maSV)
        {
            return dal_timkiem.timKiemSVKL(maSV);
        }
    }
}
