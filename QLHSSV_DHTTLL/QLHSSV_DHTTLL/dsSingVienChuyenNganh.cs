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
    public partial class dsSingVienChuyenNganh : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        BindingSource bindSinhVien;
        public dsSingVienChuyenNganh()
        {
            InitializeComponent();
        }
        DataTable SinhVien_DS()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV+' '+ TENSV as [Họ Tên SV], TENNGANH, TENLOP, TENKHOA, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH)", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        DataTable SinhVienDS_Lop(string maNganh)
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV +' '+ TENSV as [Họ Tên SV], TENNGANH, LOP.TENLOP, TENKHOA, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,KHOA,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MAKHOA=KHOA.MAKHOA) and (SINHVIEN.MANGANH = CHUYENNGANH.MANGANH) and CHUYENNGANH.MANGANH='" + maNganh + "'", dbConn);
            ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        DataTable Lop_DS()
        {
            string cmd = "SELECT * FROM CHUYENNGANH";
            SqlDataAdapter adap = new SqlDataAdapter(cmd, Program.strConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
        private void dsSingVienChuyenNganh_Load(object sender, EventArgs e)
        {
            bindSinhVien = new BindingSource();
            bindSinhVien.DataSource = SinhVien_DS();
            dataDT.DataSource = bindSinhVien;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ tên SV";
            //dataDT.Columns[2].HeaderText = "Tên SV";
            dataDT.Columns[2].HeaderText = " Ngành ";
            dataDT.Columns[3].HeaderText = "Lớp";
            dataDT.Columns[4].HeaderText = "Khoa";
            dataDT.Columns[5].HeaderText = "Giới tính";
            dataDT.Columns[6].HeaderText = "Ngày sinh";
            dataDT.Columns[7].HeaderText = "Địa chỉ";


            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 30;
            dataDT.Columns[2].Width = 30;
            dataDT.Columns[3].Width = 50;
            dataDT.Columns[4].Width = 50;
            dataDT.Columns[5].Width = 50;
            dataDT.Columns[6].Width = 20;
            dataDT.Columns[7].Width = 40;
            //dataDT.Columns[8].Width = 50;

            comboNganh.DataSource = Lop_DS();
            comboNganh.DisplayMember = "TENNGANH";
            comboNganh.ValueMember = "MANGANH";
            comboNganh.SelectedIndex = -1;
            comboNganh.Text = "[Chọn ngành ...]"; 
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = "[Họ Tên SV] LIKE '" + txtTimKiem.Text + "%'";
            bindSinhVien.Filter = str;
            dataDT.DataSource = bindSinhVien;
        }

        private void comboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboNganh.SelectedIndex == -1) || (comboNganh.Text == ""))
                dataDT.DataSource = SinhVien_DS();
            else
                dataDT.DataSource = SinhVienDS_Lop(comboNganh.SelectedValue.ToString());
        }
    }
}
