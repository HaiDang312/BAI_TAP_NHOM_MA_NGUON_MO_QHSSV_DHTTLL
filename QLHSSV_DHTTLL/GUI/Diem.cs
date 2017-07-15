using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace GUI
{
    public partial class Diem : Form
    {
        BUS_Diem bus_Diem = new BUS_Diem();
        public Diem()
        {
            InitializeComponent();
        }
        class Bien
        {
            public static string maSV = "";
            public static string maMH = "";
            public static string hocKy = "";
            public static string diemCC = "";
            public static string diemTX = "";
            public static string diemGK = "";
            public static string diemCK = "";


        }

        private void binding()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", gridDS.DataSource, "MASV");
            cbMaMH.DataBindings.Clear();
            cbMaMH.DataBindings.Add("Text", gridDS.DataSource, "MAMH");
            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", gridDS.DataSource, "HOCKY");
            txtDiemCC.DataBindings.Clear();
            txtDiemCC.DataBindings.Add("Text", gridDS.DataSource, "DIEMCC");
            txtDiemTX.DataBindings.Clear();
            txtDiemTX.DataBindings.Add("Text", gridDS.DataSource, "DIEMTX");
            txtDiemGK.DataBindings.Clear();
            txtDiemGK.DataBindings.Add("Text", gridDS.DataSource, "DIEMGK");
            txtDiemCK.DataBindings.Clear();
            txtDiemCK.DataBindings.Add("Text", gridDS.DataSource, "DIEMTHI");
        }

        private void Diem_Load(object sender, EventArgs e)
        {

            // lấy mã khoa từ bảng khoa vào combobox
            cbMaMH.DataSource = bus_Diem.MonHoc();
            cbMaMH.DisplayMember = "MaMH";
            cbMaMH.ValueMember = "MaMH";

            gridDS.DataSource = bus_Diem.Diem();
            gridDS.Columns[0].HeaderText = "Mã SV";
            gridDS.Columns[1].HeaderText = "Mã MH";
            gridDS.Columns[2].HeaderText = "Học Kỳ";
            gridDS.Columns[3].HeaderText = "Điểm CC";
            gridDS.Columns[4].HeaderText = "Điểm TX";
            gridDS.Columns[5].HeaderText = "Điểm GK";
            gridDS.Columns[6].HeaderText = "Điểm CK";
            gridDS.Columns[7].HeaderText = "Điểm TK";

            gridDS.Columns[0].Width = 80;
            gridDS.Columns[1].Width = 60;
            gridDS.Columns[2].Width = 60;
            gridDS.Columns[3].Width = 60;
            gridDS.Columns[4].Width = 60;
            gridDS.Columns[5].Width = 60;
            gridDS.Columns[6].Width = 60;
            gridDS.Columns[7].Width = 60;

            gridDS.AllowUserToAddRows = false;
            gridDS.AllowUserToDeleteRows = false;
            gridDS.Width = this.ClientSize.Width;
            gridDS.Height = this.ClientSize.Height;

            binding();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DTO_Diem dto_Diem = new DTO_Diem(txtMaSV.Text, cbMaMH.SelectedValue.ToString(), txtHocKy.Text, txtDiemCC.Text, txtDiemTX.Text, txtDiemGK.Text, txtDiemCK.Text);
            bus_Diem.themDiem(dto_Diem);
            Diem_Load(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DTO_Diem dto_Diem = new DTO_Diem(txtMaSV.Text, cbMaMH.SelectedValue.ToString(), txtHocKy.Text, txtDiemCC.Text, txtDiemTX.Text, txtDiemGK.Text, txtDiemCK.Text);
            bus_Diem.suaDiem(dto_Diem);
            Diem_Load(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            bus_Diem.xoaDiem(txtMaSV.Text);
            Diem_Load(sender, e);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
