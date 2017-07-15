using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        private string maMonHoc;

        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }


        private string tenMonHoc;

        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set { tenMonHoc = value; }
        }
        private string sotiet;

        public string SoTiet
        {
            get { return sotiet; }
            set { sotiet = value; }
        }


        public DTO_MonHoc(string pmaMonHoc, string ptenMonHoc, string psoTiet)
        {
            this.maMonHoc = pmaMonHoc;
            this.tenMonHoc = ptenMonHoc;
            this.SoTiet = psoTiet;
        }
    }
}
