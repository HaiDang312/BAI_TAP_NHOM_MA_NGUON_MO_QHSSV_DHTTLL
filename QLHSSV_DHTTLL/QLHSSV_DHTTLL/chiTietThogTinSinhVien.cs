using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class chiTietThogTinSinhVien : Form
    {
        public chiTietThogTinSinhVien()
        {
            InitializeComponent();
        }

        private void chiTietThogTinSinhVien_Load(object sender, EventArgs e)
        {
           ////CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END, DIACHI, CASE WHEN DOANVIEN='Có' THEN 'Nam' ELSE 'Không' END,CASE WHEN HEDAOTAO='Dân sự' THEN 'Nam' ELSE 'Quan sự' END,

           // SqlConnection connDB = new SqlConnection(Program.strConn);
           // connDB.Open();
           // string cmd = "SELECT MASV,HOSV+' '+TENSV,ANHSINHVIEN, TENLOP, TENKHOA, TENNGANH, NGAYSINH, NGAYVD, NOIKETNAP, SOCMND, NGAYCAP, NOICAP, NAMTUYENSINH, DANTOC from SINHVIEN,KHOA,LOP,CHUYENNGANH WHERE (SINHVIEN.MALOP=LOP.MALOP) AND (SINHVIEN.MAKHOA=KHOA.MAKHOA) AND (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH) AND ( SINHVIEN.MASV='"+BienSinhVien.maSV+"' )";
           // SqlCommand sqlCmd = new SqlCommand(cmd, connDB);

           // //sqlCmd.Parameters.AddWithValue("@ANHSINHVIEN", images);
           // //sqlCmd.ExecuteNonQuery();
           // //connDB.Close();
           // //labMaSV.Text = SqlDataReader["MASV"].Tostring();

           // SqlDataReader reader = sqlCmd.ExecuteReader();
           // reader.Read();

           // labMaSV.Text = reader[0].ToString();
           // labHoTen.Text = reader[1].ToString();
           // labGioiTinh.Text=reader[2].ToString();
           // byte[] img = (byte[])(reader[3]);
           // MemoryStream ms = new MemoryStream(img);
           // AnhSV.Image = Image.FromStream(ms);

        }
    }
}
