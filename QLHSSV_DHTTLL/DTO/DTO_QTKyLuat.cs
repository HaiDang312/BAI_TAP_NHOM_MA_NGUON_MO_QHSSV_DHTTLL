using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_QTKyLuat
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }


        private string maKL;

        public string MaKL
        {
            get { return maKL; }
            set { maKL = value; }
        }

        private string ngayKL;

        public string NgayKL
        {
            get { return ngayKL; }
            set { ngayKL = value; }
        }

        private string ngayHH;

        public string NgayHH
        {
            get { return ngayHH; }
            set { ngayHH = value; }
        }

        public DTO_QTKyLuat(string pmaSV,string pmaKL, string pngayKL, string pngayHH)
        {
            this.maSV = pmaSV;
            this.maKL = pmaKL;
            this.ngayKL = pngayKL;
             this.ngayHH = pngayHH;
        }
    }
}
