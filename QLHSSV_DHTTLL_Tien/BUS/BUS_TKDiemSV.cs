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
    public class BUS_TKDiemSV
    {
        DAL_Diem dal_diem = new DAL_Diem();

        public DataTable Diem()
        {
            return dal_diem.Diem();
        }
    }
}
