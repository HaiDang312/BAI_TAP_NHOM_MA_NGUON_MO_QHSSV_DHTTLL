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

    public partial class dsSingVienKhenThuong : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        BindingSource bindSinhVien;

        public dsSingVienKhenThuong()
        {
            InitializeComponent();
        }
        DataTable SinhVien_DS()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV, TENSV as [Tên SV], TENLOP,KHOA.TENKHOA,TENKT,NGAYKT   FROM SINHVIEN,LOP,KHOA,KHENTHUONG,QTKHENTHUONG  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MASV=QTKHENTHUONG.MASV) and (QTKHENTHUONG.MAKT=KHENTHUONG.MAKT)", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        DataTable SinhVienDS_Lop(string maLop)
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV, TENSV as [Tên SV], TENLOP,KHOA.TENKHOA,TENKT,NGAYKT FROM SINHVIEN,LOP,KHOA,KHENTHUONG,QTKHENTHUONG  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MASV=QTKHENTHUONG.MASV) and (QTKHENTHUONG.MAKT=KHENTHUONG.MAKT) and LOP.MALOP='" + maLop + "'", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        DataTable Lop_DS()
        {
            string cmd = "SELECT * FROM LOP";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        DataTable SinhVienDS_Khoa(string maKhoa)
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV, TENSV as [Tên SV], TENLOP,KHOA.TENKHOA,TENKT,NGAYKT FROM SINHVIEN,LOP,KHOA,KHENTHUONG,QTKHENTHUONG WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MASV=QTKHENTHUONG.MASV) and (QTKHENTHUONG.MAKT=KHENTHUONG.MAKT) and KHOA.MAKHOA='" + maKhoa + "'", dbConn);
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
        DataTable SinhVienDS_KhoaVaLop(string maKhoa, string malop)
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV, TENSV as [Tên SV], TENLOP,KHOA.TENKHOA,TENKT,NGAYKT FROM SINHVIEN,LOP,KHOA,KHENTHUONG,QTKHENTHUONG WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MASV=QTKHENTHUONG.MASV) and (QTKHENTHUONG.MAKT=KHENTHUONG.MAKT) and KHOA.MAKHOA='" + maKhoa + "' and LOP.MALOP='" + malop + "'", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        private void dsSingVienKhenThuong_Load(object sender, EventArgs e)
        {
            bindSinhVien = new BindingSource();
            bindSinhVien.DataSource = SinhVien_DS();
            dataDT.DataSource = bindSinhVien;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ SV";
            dataDT.Columns[2].HeaderText = "Tên SV";
            dataDT.Columns[3].HeaderText = "Lớp";
            dataDT.Columns[4].HeaderText = "Khoa";
            dataDT.Columns[5].HeaderText = "Tên khen thưởng";
            dataDT.Columns[6].HeaderText = "Ngày khen thưởng";




            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 20;
            dataDT.Columns[2].Width = 40;
            dataDT.Columns[3].Width = 70;
            dataDT.Columns[4].Width = 70;
            dataDT.Columns[5].Width = 70;
            dataDT.Columns[6].Width = 20;
           // dataDT.Columns[7].Width = 40;

            comboLop.DataSource = Lop_DS();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]";

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
            if (((comboKhoa.SelectedIndex == -1) || (comboKhoa.Text == "")) && ((comboLop.SelectedIndex == -1) || (comboLop.Text == "")))
            {
                dataDT.DataSource = SinhVien_DS();
            }
            if (((comboKhoa.SelectedIndex != -1) || (comboKhoa.Text != "")) && ((comboLop.SelectedIndex == -1) || (comboLop.Text == "")))
            {
                dataDT.DataSource = SinhVienDS_Khoa(comboKhoa.SelectedValue.ToString());
            }

            if (((comboKhoa.SelectedIndex != -1) || (comboKhoa.Text != "")) && ((comboLop.SelectedIndex != -1) || (comboLop.Text != "")))
            {
                dataDT.DataSource = SinhVienDS_KhoaVaLop(comboKhoa.SelectedValue.ToString(), comboLop.SelectedValue.ToString());
            }
        }

        private void comboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboLop.SelectedIndex == -1) || (comboLop.Text == ""))
                dataDT.DataSource = SinhVien_DS();

            else
                dataDT.DataSource = SinhVienDS_Lop(comboKhoa.SelectedValue.ToString());
        }
    }
}
