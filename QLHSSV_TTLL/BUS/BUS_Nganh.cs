using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Nganh
    {
        Dal_ChuyenNganh dal_Nganh = new Dal_ChuyenNganh();

        public bool themNganh(DTO_ChuyenNganh pNganh)
        {
            return dal_Nganh.themNganh(pNganh);
        }

        public bool suaNganh(DTO_ChuyenNganh pNganh)
        {
            return dal_Nganh.suaNganh(pNganh);
        }

        public bool xoaNganh(String maNganh)
        {
            return dal_Nganh.xoaNganh(maNganh);
        }

        public DataTable NGANH()
        {
            return dal_Nganh.Nganh();
        }
        public DataTable SV_dsNganh()
        {
            return dal_Nganh.SinhVien_DS();
        }
        public DataTable SV_dsLop(string maNganh)
        {
            return dal_Nganh.SinhVien_DSLop(maNganh);
        }
    }
}
