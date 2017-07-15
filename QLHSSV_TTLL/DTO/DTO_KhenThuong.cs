using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KhenThuong
    {
        private string maKT;

        public string MaKT
        {
            get { return maKT; }
            set { maKT = value; }
        }


        private string tenKT;

        public string TenKT
        {
            get { return tenKT; }
            set { tenKT = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public DTO_KhenThuong(string pmaKT, string ptenKT, string pghiChu)
        {
            this.maKT = pmaKT;
            this.tenKT = ptenKT;
            this.ghiChu = pghiChu;
        }
    }
}
