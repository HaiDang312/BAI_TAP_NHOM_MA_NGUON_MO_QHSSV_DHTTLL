using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenNganh
    {
        private string maNganh;

        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string tenNganh;

        public string TenNganh
        {
            get { return tenNganh; }
            set { tenNganh = value; }
        }
        public DTO_ChuyenNganh(string pmaNganh,string ptenNganh)
        {
            this.maNganh = pmaNganh;
            this.tenNganh = ptenNganh;
        }
        public DTO_ChuyenNganh()
        {
            this.maNganh = "";
            this.tenNganh = "";
        }
    }
}
