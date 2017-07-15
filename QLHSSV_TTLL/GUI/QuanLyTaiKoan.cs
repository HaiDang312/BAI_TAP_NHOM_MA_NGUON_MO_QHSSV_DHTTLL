using BUS;
using DTO;
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
    public partial class QuanLyTaiKoan : Form
    {
        BUS_DangNhap bus_DN = new BUS_DangNhap();
        DTO_DangNhap dn = new DTO_DangNhap();

        public QuanLyTaiKoan()
        {
            InitializeComponent();
        }
        private void QuanLyTaiKoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus_DN.DN();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns[3].HeaderText = "Mật khẩu";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 225;
            dataGridView1.Columns[2].Width = 255;
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemTaiKhoan f = new ThemTaiKhoan();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            dn.Id= row.Cells["id"].Value.ToString();
            dn.HoTen = row.Cells["hoTen"].Value.ToString();
            dn.TenDN = row.Cells["tenDangNhap"].Value.ToString();
            dn.MK1 = row.Cells["matKhau"].Value.ToString();
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            bus_DN.xoaDN(dn.Id);
            this.QuanLyTaiKoan_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.CurrentRow;
            dn.Id = row.Cells["id"].Value.ToString();
            dn.HoTen = row.Cells["hoTen"].Value.ToString();
            dn.TenDN = row.Cells["tenDangNhap"].Value.ToString();
            dn.MK1 = row.Cells["matKhau"].Value.ToString();
            DTO_DangNhap dto_dn = new DTO_DangNhap(dn.Id,dn.HoTen,dn.TenDN,dn.MK1);
            bus_DN.suaDN(dto_dn);
            this.QuanLyTaiKoan_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
