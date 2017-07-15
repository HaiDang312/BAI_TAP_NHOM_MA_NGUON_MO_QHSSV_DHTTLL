using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class BienDN
    {
        public static string id = "";
        public static string hoTen = "";
        public static string tenDN = "";
        public static string MK = "";
    }
    class BienMH
    {
        public static string maMonHoc = "";
        public static string tenMonHoc = "";
        public static string soTiet = "";

    }
    class BienSinhVien
    {
        public static string maSV = "";
        public static string hoTenSV = "";
        public static string anhSV = "";
        public static string maLop = "";
        public static string maKhoa = "";
        public static string maNganh = "";
        public static string ngaySinh = "";
        public static string gioiTinh = "";
        public static string diaChi = "";
        public static string doanVien= "";
        public static string ngayVaoDoan = "";
        public static string noiKetNap = "";
        public static string soCMND = "";
        public static string ngayCap = "";
        public static string noiCap = "";
        public static string heDaoTao = "";
        public static string namTuyenSinh = "";
        public static string danToc = "";
    }

    static class Program
    {
        


       public static string strConn = @"Data Source=HUUTHUAN\SQLEXPRESS;Initial Catalog=QLHSSV_TTLL;Integrated Security=True";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DangNhap());
            Application.Run(new Lop());
            //Application.Run(new InDanhSachSinhVienTheoLop());
        }
    }
}
