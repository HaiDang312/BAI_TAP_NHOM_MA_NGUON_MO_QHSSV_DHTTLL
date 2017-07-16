using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HocBong
    {
        private string maHB;

        public string MaHB
        {
            get { return maHB; }
            set { maHB = value; }
        }


        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        private string hocKy;

        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        public DTO_HocBong(string pmaHB, string pmaSV, string phocKy)
        {
            this.maHB = pmaHB;
            this.maSV = pmaSV;
            this.hocKy = phocKy;
        }
    }
}
