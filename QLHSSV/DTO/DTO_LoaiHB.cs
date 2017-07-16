using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_LoaiHB
    {
        private string maHB;

        public string MaHB
        {
            get { return maHB; }
            set { maHB = value; }
        }


        private string tenHB;

        public string TenHB
        {
            get { return tenHB; }
            set { tenHB = value; }
        }

        private string mucHB;

        public string MucHB
        {
            get { return mucHB; }
            set { mucHB = value; }
        }

        private string soTien;

        public string SoTien
        {
            get { return soTien; }
            set { soTien = value; }
        }

        public DTO_LoaiHB(string pmaHB, string ptenHB, string pmucHB, string psoTien)
        {
            this.maHB = pmaHB;
            this.tenHB = ptenHB;
            this.mucHB = pmucHB;
            this.soTien = psoTien;
        }
    }
}
