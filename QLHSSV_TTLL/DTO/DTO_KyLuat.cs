using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KyLuat
    {
        private string maKL;

        public string MaKL
        {
            get { return maKL; }
            set { maKL = value; }
        }


        private string tenKL;

        public string TenKL
        {
            get { return tenKL; }
            set { tenKL = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public DTO_KyLuat(string pmaKL, string ptenKL, string pghiChu)
        {
            this.maKL = pmaKL;
            this.tenKL = ptenKL;
            this.ghiChu = pghiChu;
        }
    }
}
