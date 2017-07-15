using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DanhSachDoiTuong : Form
    {
        SqlConnection dbConn;
        DataTable dsDT;
        SqlDataAdapter adapDT;
        BindingSource bindSinhVien;
        public DanhSachDoiTuong()
        {
            InitializeComponent();
        }
        DataTable SinhVien_DS()
        {
            dbConn = new SqlConnection(Program.strConn);
            adapDT = new SqlDataAdapter();
            dbConn.Open();
            adapDT.SelectCommand = new SqlCommand("SELECT SINHVIEN.MaSV, HOSV, TENSV as [Tên SV], LOP.TENLOP,KHOA.TENKHOA ,TENDOITUONG,CHEDOMIENGIAM FROM SINHVIEN,LOP,KHOA,DOITUONG,SV_DOITUONG  WHERE (SINHVIEN.MaSV=SV_DOITUONG.MaSV) AND (SV_DOITUONG.MADT=DOITUONG.MADT) AND (SINHVIEN.MALOP=LOP.MALOP) AND (SINHVIEN.MAKHOA=KHOA.MAKHOA)", dbConn);
            dsDT = new DataTable();
            adapDT.Fill(dsDT);
            dbConn.Close();
            return dsDT;
        }
        private void DanhSachDoiTuong_Load(object sender, EventArgs e)
        {
            bindSinhVien = new BindingSource();
            bindSinhVien.DataSource = SinhVien_DS();
            dataDT.DataSource = bindSinhVien;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ SV";
            dataDT.Columns[2].HeaderText = "Tên SV";
            dataDT.Columns[3].HeaderText = "Lớp";
            dataDT.Columns[4].HeaderText = "Khoa";
            dataDT.Columns[5].HeaderText = "Đối tượng";
            dataDT.Columns[6].HeaderText = "Chế độ miển giảm";
            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 20;
            dataDT.Columns[2].Width = 40;
            dataDT.Columns[3].Width = 50;
            dataDT.Columns[4].Width = 50;
            dataDT.Columns[5].Width = 60;
            dataDT.Columns[6].Width = 150;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemDoiTuong f = new ThemDoiTuong();
            f.Show();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = "[Tên SV] LIKE '" + txtTimKiem.Text + "%'";
            bindSinhVien.Filter = str;
            dataDT.DataSource = bindSinhVien;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
