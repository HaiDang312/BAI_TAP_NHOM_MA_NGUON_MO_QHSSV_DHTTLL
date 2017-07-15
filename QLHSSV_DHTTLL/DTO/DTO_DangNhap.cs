using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string tenDN;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
        private string MK;

        public string MK1
        {
            get { return MK; }
            set { MK = value; }
        }
        public DTO_DangNhap(string pId, string pHoTen, string pTenDN, string pMK)
        {
            this.id = pId;
            this.hoTen = pHoTen;
            this.tenDN = pTenDN;
            this.MK = pMK;
        }
        public DTO_DangNhap()
        {
            this.id = "";
            this.hoTen = "";
            this.tenDN = "";
            this.MK = "";
        }
    }
}
