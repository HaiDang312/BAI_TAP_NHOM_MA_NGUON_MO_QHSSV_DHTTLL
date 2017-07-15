using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Diem
    {
        private string maSinhVien;

        public string MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }


        private string maMonHoc;

        public string MaMonHoc
        {
            get { return maMonHoc; }
            set { maMonHoc = value; }
        }
        private string hocKy;

        public string HocKy
        {
            get { return hocKy; }
            set { hocKy = value; }
        }
        private string diemCC;

        public string DiemCC
        {
            get { return diemCC; }
            set { diemCC = value; }
        }
        private string diemTX;

        public string DiemTX
        {
            get { return diemTX; }
            set { diemTX = value; }
        }
        private string diemGK;

        public string DiemGK
        {
            get { return diemGK; }
            set { diemGK = value; }
        }
        private string diemCK;

        public string DiemCK
        {
            get { return diemCK; }
            set { diemCK = value; }
        }


        public DTO_Diem(string pmaSinhVien, string pmaMonHoc, string phocKy, string pdiemCC, string pdiemTX, string pdiemGK, string pdiemCK)
        {
            this.maSinhVien = pmaSinhVien;
            this.maMonHoc = pmaMonHoc;
            this.hocKy = phocKy;
            this.diemCC = pdiemCC;
            this.diemTX = pdiemTX;
            this.diemGK = pdiemGK;
            this.diemCK = pdiemCK;
        }
    }
}
