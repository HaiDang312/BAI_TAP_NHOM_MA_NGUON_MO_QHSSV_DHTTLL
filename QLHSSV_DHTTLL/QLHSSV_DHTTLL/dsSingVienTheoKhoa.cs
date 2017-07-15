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
    public partial class dsSingVienTheoKhoa : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        BindingSource bindSinhVien;

        public dsSingVienTheoKhoa()
        {
            InitializeComponent();
        }
        DataTable SinhVien_DS()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV, TENSV as [Tên SV], TENLOP,KHOA.TENKHOA,TENNGANH, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH)", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        DataTable SinhVienDS_Khoa(string maKhoa)
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV, TENSV as [Tên SV], TENLOP,KHOA.TENKHOA,TENNGANH, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH) and KHOA.MAKHOA='" + maKhoa + "'", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        DataTable Khoa_DS()
        {
            string cmd = "SELECT * FROM KHOA";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        private void dsSingVienTheoKhoa_Load(object sender, EventArgs e)
        {
            bindSinhVien = new BindingSource();
            bindSinhVien.DataSource = SinhVien_DS();
            dataDT.DataSource = bindSinhVien;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ SV";
            dataDT.Columns[2].HeaderText = "Tên SV";
            dataDT.Columns[3].HeaderText = "Lớp";
            dataDT.Columns[4].HeaderText = "Khoa";
            dataDT.Columns[5].HeaderText = "Ngành";
            dataDT.Columns[6].HeaderText = "Giới tính";
            dataDT.Columns[7].HeaderText = "Ngày sinh";
            dataDT.Columns[8].HeaderText = "Địa chỉ";


            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 20;
            dataDT.Columns[2].Width = 40;
            dataDT.Columns[3].Width = 70;
            dataDT.Columns[4].Width = 70;
            dataDT.Columns[5].Width = 70;
            dataDT.Columns[6].Width = 20;
            dataDT.Columns[7].Width = 40;
            dataDT.Columns[8].Width = 60;

            comboKhoa.DataSource = Khoa_DS();
            comboKhoa.DisplayMember = "TENKHOA";
            comboKhoa.ValueMember = "MAKHOA";
            comboKhoa.SelectedIndex = -1;
            comboKhoa.Text = "[ Chọn khoa ...]"; 
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = "[Tên SV] LIKE '" + txtTimKiem.Text + "%'";
            bindSinhVien.Filter = str;
            dataDT.DataSource = bindSinhVien;
        }

        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboKhoa.SelectedIndex == -1) || (comboKhoa.Text == ""))
                dataDT.DataSource = SinhVien_DS();
            else
                dataDT.DataSource = SinhVienDS_Khoa(comboKhoa.SelectedValue.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
