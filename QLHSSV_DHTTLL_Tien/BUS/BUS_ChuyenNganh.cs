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
    public class BUS_ChuyenNganh
    {
        DAL_ChuyenNganh dal_cn = new DAL_ChuyenNganh();

        //thêm KT
        public bool themCN(DTO_ChuyenNganh pKT)
        {
            return dal_cn.themCN(pKT);
        }

        // Sửa KT
        public bool suaCN(DTO_ChuyenNganh pKT)
        {
            return dal_cn.suaCN(pKT);
        }

        // Xóa KT
        public bool xoaCN(String maCN)
        {
            return dal_cn.xoaCN(maCN);
        }

        public DataTable ChuyenNganh()
        {
            return dal_cn.ChuyenNganh();
        }

    }
}
