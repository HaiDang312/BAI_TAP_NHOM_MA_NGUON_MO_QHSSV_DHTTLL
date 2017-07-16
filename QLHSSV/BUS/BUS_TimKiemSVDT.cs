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
    public class BUS_TimKiemSVDT
    {
        DAL_TimKiemSVDT dal_timkiemsv = new DAL_TimKiemSVDT();
        public bool timSVDT(string maSV)
        {
            return dal_timkiemsv.timKiemSVDT(maSV);
        }
    }
}
