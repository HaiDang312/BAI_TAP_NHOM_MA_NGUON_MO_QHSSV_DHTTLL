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
        Dal_TimKiemSVDT dal_timkiemsv = new Dal_TimKiemSVDT();
        public bool timSVDT(string maSV)
        {
            return dal_timkiemsv.timKiemSVDT(maSV);
        }
    }
}
