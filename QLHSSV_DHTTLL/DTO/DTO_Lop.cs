using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string maLop;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }


        private string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        private string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }

        public DTO_Lop(string pmaLop,string ptenLop, string pmaKhoa)
        {
            this.maLop = pmaLop;
            this.tenLop = ptenLop;
            this.maKhoa = pmaKhoa;
        }
    }
}
