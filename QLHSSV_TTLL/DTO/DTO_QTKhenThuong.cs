using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QTKhenThuong
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }


        private string maKT;

        public string MaKT
        {
            get { return maKT; }
            set { maKT = value; }
        }

        private string ngayKT;

        public string NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }

        public DTO_QTKhenThuong(string pmaSV, string pmaKT, string pngayKT)
        {
            this.maSV = pmaSV;
            this.maKT = pmaKT;
            this.ngayKT = pngayKT;
        }
    }
}
