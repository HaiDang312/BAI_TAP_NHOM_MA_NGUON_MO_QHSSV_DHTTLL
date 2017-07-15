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
    public partial class dsSinhVienTheoLop : Form
    {
        SqlConnection dbConn;
        DataTable ds;
        SqlDataAdapter adap;
        BindingSource bindSinhVien;

        public dsSinhVienTheoLop()
        {
            InitializeComponent();
        }

        DataTable SinhVien_DS()
        {
            dbConn = new SqlConnection(Program.strConn);
            adap = new SqlDataAdapter();
            dbConn.Open();
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV +' '+ TENSV as [Họ Tên SV], TENLOP,TENNGANH, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH)", dbConn);
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
            adap.SelectCommand = new SqlCommand("SELECT SINHVIEN.MASV, HOSV +' '+ TENSV as [Họ Tên SV], TENLOP,TENNGANH, CASE WHEN GIOITINH='1' THEN 'Nam' ELSE 'Nữ' END ,NGAYSINH,DIACHI FROM SINHVIEN,LOP,CHUYENNGANH  WHERE (SINHVIEN.MALOP=LOP.MALOP) and (SINHVIEN.MANGANH=CHUYENNGANH.MANGANH) and LOP.MALOP='" + maLop + "'", dbConn);
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = "[Họ Tên SV] LIKE '" + txtTimKiem.Text + "%'";
            bindSinhVien.Filter = str;
            dataDT.DataSource = bindSinhVien;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            bindSinhVien = new BindingSource();
            bindSinhVien.DataSource = SinhVien_DS();
            dataDT.DataSource = bindSinhVien;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ tên SV";
           // dataDT.Columns[2].HeaderText = "Tên SV";
            dataDT.Columns[2].HeaderText = "Lớp";
            dataDT.Columns[3].HeaderText = "Ngành";
            dataDT.Columns[4].HeaderText = "Giới tính";
            dataDT.Columns[5].HeaderText = "Ngày sinh";
            dataDT.Columns[6].HeaderText = "Địa chỉ";
         

            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 20;
            dataDT.Columns[2].Width = 40;
            dataDT.Columns[3].Width = 50;
            dataDT.Columns[4].Width = 50;
            dataDT.Columns[5].Width = 60;
            dataDT.Columns[6].Width = 150;
            //dataDT.Columns[7].Width = 150;

            comboLop.DataSource = Lop_DS();
            comboLop.DisplayMember = "TENLOP";
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]"; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboLop.SelectedIndex == -1) || (comboLop.Text == ""))
                dataDT.DataSource = SinhVien_DS();
            else
                dataDT.DataSource = SinhVienDS_Lop(comboLop.SelectedValue.ToString());
        }
    }
}
