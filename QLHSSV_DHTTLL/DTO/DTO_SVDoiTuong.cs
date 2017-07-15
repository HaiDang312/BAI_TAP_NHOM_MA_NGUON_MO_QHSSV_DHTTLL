using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SVDoiTuong
    {


        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }

        private string maDT;

        public string MaDT
        {
            get { return maDT; }
            set { maDT = value; }
        }

        public DTO_SVDoiTuong(string pmaSV, string pmaDT)
        {
            this.maSV = pmaSV;
            this.maDT = pmaDT;

        }
    }
}
