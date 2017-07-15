using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Khoa
    {
        private string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        private string tenKhoa;

        public string TenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        public DTO_Khoa(string pmaKhoa,string ptenKhoa)
        {
            this.maKhoa = pmaKhoa;
            this.tenKhoa = ptenKhoa;
        }
    }
}
