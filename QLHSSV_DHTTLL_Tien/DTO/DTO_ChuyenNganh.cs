using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChuyenNganh
    {
        private string maChuyenNganh;

        public string MaChuyenNganh
        {
            get { return maChuyenNganh; }
            set { maChuyenNganh = value; }
        }


        private string tenChuyenNganh;

        public string TenChuyenNganh
         {
            get { return tenChuyenNganh; }
            set { tenChuyenNganh = value; }
        }


        public DTO_ChuyenNganh(string pmaChuyenNganh,string ptenChuyenNganh)
        {
            this.maChuyenNganh = pmaChuyenNganh;
            this.tenChuyenNganh = ptenChuyenNganh;
        }
    }
}
