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
    public class BUS_Khoa
    {
        Dal_Khoa dal_Khoa = new Dal_Khoa();

        public bool themKhoa(DTO_Khoa pKhoa)
        {
            return dal_Khoa.themKhoa(pKhoa);
        }

        public bool suaKhoa(DTO_Khoa pKhoa)
        {
            return dal_Khoa.suaKhoa(pKhoa);
        }

        public bool xoaKhoa(String maKhoa)
        {
            return dal_Khoa.xoaKhoa(maKhoa);
        }

        public DataTable KHOA()
        {
            return dal_Khoa.Khoa_DS();
        }
    }
}
