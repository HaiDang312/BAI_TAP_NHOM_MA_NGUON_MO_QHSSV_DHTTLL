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
    public partial class MonHoc : Form
    {
        BUS_MonHoc bus_MonHoc = new BUS_MonHoc();
        public MonHoc()
        {
            InitializeComponent();
        }
        class Bien
        {
            public static string maMH = "";
            public static string tenMH = "";
            public static string soTiet = "";

        }

        private void binding()
        {
            txtMaMH.DataBindings.Clear();
            txtMaMH.DataBindings.Add("Text", gridDS.DataSource, "MAMH");
            txtTenMH.DataBindings.Clear();
            txtTenMH.DataBindings.Add("Text", gridDS.DataSource, "TENMH");
            txtSoTiet.DataBindings.Clear();
            txtSoTiet.DataBindings.Add("Text", gridDS.DataSource, "SOTIET");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            gridDS.DataSource = bus_MonHoc.MonHoc();
            gridDS.Columns[0].HeaderText = "Mã MH";
            gridDS.Columns[1].HeaderText = "Tên môn học";
            gridDS.Columns[2].HeaderText = "Số tiết";

            gridDS.Columns[0].Width = 70;
            gridDS.Columns[1].Width = 200;
            gridDS.Columns[2].Width = 70;

            gridDS.AllowUserToAddRows = false;
            gridDS.AllowUserToDeleteRows = false;
            gridDS.Width = this.ClientSize.Width;
            gridDS.Height = this.ClientSize.Height;

            binding();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            DTO_MonHoc dto_MonHoc = new DTO_MonHoc(txtMaMH.Text, txtTenMH.Text, txtSoTiet.Text);
            bus_MonHoc.themMH(dto_MonHoc);
            MonHoc_Load(sender, e);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            bus_MonHoc.xoaMH(txtMaMH.Text);
            MonHoc_Load(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DTO_MonHoc dto_MonHoc = new DTO_MonHoc(txtMaMH.Text, txtTenMH.Text, txtSoTiet.Text);
            bus_MonHoc.suaMH(dto_MonHoc);
            MonHoc_Load(sender, e);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MonHoc_Load(sender, e);
        }
    }
}
