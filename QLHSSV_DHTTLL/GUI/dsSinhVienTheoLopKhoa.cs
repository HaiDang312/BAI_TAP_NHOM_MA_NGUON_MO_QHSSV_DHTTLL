using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class dsSinhVienTheoLopKhoa : Form
    {
        BUS_SinhVien bus_SV = new BUS_SinhVien();
        BindingSource binSV;
        public dsSinhVienTheoLopKhoa()
        {
            InitializeComponent();
        }

        private void dsSinhVienTheoLopKhoa_Load(object sender, EventArgs e)
        {
            binSV = new BindingSource();
            binSV.DataSource = bus_SV.SinhVien();
            dataSV.DataSource = binSV;
            dataSV.Columns[0].HeaderText = "Mã SV";
            dataSV.Columns[1].HeaderText = "Họ SV";
            dataSV.Columns[2].HeaderText = "Tên SV";
            dataSV.Columns[3].HeaderText = "Lớp";
            dataSV.Columns[4].HeaderText = "Khoa";
            dataSV.Columns[5].HeaderText = "Ngành";
            dataSV.Columns[6].HeaderText = "Ngày sinh";
            dataSV.Columns[7].HeaderText = "Giới tính";
            dataSV.Columns[8].HeaderText = "Địa chỉ";
            dataSV.Columns[9].HeaderText = "Đoàn viên";
            dataSV.Columns[10].HeaderText = "Ngày vào đoàn";
            dataSV.Columns[11].HeaderText = "Nơi kết nạp";
            dataSV.Columns[12].HeaderText = "Số CMND";
            dataSV.Columns[13].HeaderText = "Ngày cấp";
            dataSV.Columns[14].HeaderText = "Nơi cấp";
            dataSV.Columns[15].HeaderText = "Hệ đào tạo";
            dataSV.Columns[16].HeaderText = "Nam tuyển sinh";
            dataSV.Columns[17].HeaderText = "Dân tộc";


            dataSV.Columns[0].Width = 70;
            dataSV.Columns[1].Width = 80;
            dataSV.Columns[2].Width = 70;
            dataSV.Columns[3].Width = 70;
            dataSV.Columns[4].Width = 80;
            dataSV.Columns[5].Width = 70;
            dataSV.Columns[6].Width = 70;
            dataSV.Columns[7].Width = 70;
            dataSV.Columns[8].Width = 80;
            dataSV.Columns[9].Width = 70;
            dataSV.Columns[10].Width = 70;
            dataSV.Columns[11].Width = 80;
            dataSV.Columns[12].Width = 70;
            dataSV.Columns[13].Width = 70;
            dataSV.Columns[14].Width = 70;
            dataSV.Columns[15].Width = 80;
            dataSV.Columns[16].Width = 70;
            dataSV.Columns[17].Width = 70;

            comboLop.DataSource = bus_SV.Lop();
            comboLop.DisplayMember = "MALOP";
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]"; 

            dataSV.AllowUserToAddRows = false;
            dataSV.AllowUserToDeleteRows = false;
            dataSV.Width = this.ClientSize.Width;
            dataSV.Height = this.ClientSize.Height;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = "[Ma SV] LIKE '" + txtTimKiem.Text + "%'";
            binSV.Filter = str;
            dataSV.DataSource = binSV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((comboLop.SelectedIndex == -1) || (comboLop.Text == ""))
                dataSV.DataSource = bus_SV.SinhVien();
            else
                dataSV.DataSource = bus_SV.sinhVien_Lop(comboLop.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dsSinhVienTheoLopKhoa_Load(sender, e);
        }
    }
}
