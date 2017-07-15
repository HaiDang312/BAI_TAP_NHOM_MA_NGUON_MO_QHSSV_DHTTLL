using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string hoSV;

        public string HoSV
        {
            get { return hoSV; }
            set { hoSV = value; }
        }
        private string tenSV;

        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }
        private string maLop;

        public string MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        private string maKhoa;

        public string MaKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        private string maNganh;

        public string MaNganh
        {
            get { return maNganh; }
            set { maNganh = value; }
        }
        private string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string doanVien;

        public string DoanVien
        {
            get { return doanVien; }
            set { doanVien = value; }
        }
        private string ngayVD;

        public string NgayVD
        {
            get { return ngayVD; }
            set { ngayVD = value; }
        }
        private string noiKN;

        public string NoiKN
        {
            get { return noiKN; }
            set { noiKN = value; }
        }
        private string soCMND;

        public string SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }
        private string ngayCap;

        public string NgayCap
        {
            get { return ngayCap; }
            set { ngayCap = value; }
        }
        private string noiCap;

        public string NoiCap
        {
            get { return noiCap; }
            set { noiCap = value; }
        }
        private string heDaoTao;

        public string HeDaoTao
        {
            get { return heDaoTao; }
            set { heDaoTao = value; }
        }
        private string namTuyenSinh;

        public string NamTuyenSinh
        {
            get { return namTuyenSinh; }
            set { namTuyenSinh = value; }
        }
        private string danToc;

        public string DanToc
        {
            get { return danToc; }
            set { danToc = value; }
        }

        public DTO_SinhVien(string pmaSV, string phoSV, string ptenSV, string pmaLop, string pmaKhoa, string pmaNganh, string pngaySinh, string pgioiTinh, string pdiaChi, string pdoanVien, string pngayKetNap, string pnoiKetNap, string pSCMND, string pngayCap, string pnoiCap, string pheDaoTao, string pnamTuyenSinh, string pdanToc)
        {
            this.maSV = pmaSV;
            this.hoSV = phoSV;
            this.tenSV = ptenSV;
            this.maLop = pmaLop;
            this.maKhoa = pmaKhoa;
            this.maNganh = pmaNganh;
            this.ngaySinh = pngaySinh;
            this.gioiTinh = pgioiTinh;
            this.diaChi = pdiaChi;
            this.doanVien = pdoanVien;
            this.ngayVD = pngayKetNap;
            this.noiKN = pnoiKetNap;
            this.soCMND = pSCMND;
            this.ngayCap = pngayCap;
            this.noiCap = pnoiCap;
            this.heDaoTao = pheDaoTao;
            this.namTuyenSinh = pnamTuyenSinh;
            this.danToc = pdanToc;
        }
    }
}
