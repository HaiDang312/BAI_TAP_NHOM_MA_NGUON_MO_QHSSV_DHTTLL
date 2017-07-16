using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace QLHSSV_DHTTLL_Vuong
{
    public partial class LoaiHocBong : Form
    {
        BUS_LoaiHB bus_loaihb = new BUS_LoaiHB();

        public LoaiHocBong()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void LoaiHocBong_Load(object sender, EventArgs e)
        {
            dtgLoaiHB.DataSource = bus_loaihb.LoaiHB();
            dtgLoaiHB.Columns[0].HeaderText = "Mã học bổng";
            dtgLoaiHB.Columns[1].HeaderText = "Tên học bổng";
            dtgLoaiHB.Columns[2].HeaderText = "Mức học bổng";
            dtgLoaiHB.Columns[3].HeaderText = "Số tiền";

            dtgLoaiHB.Columns[0].Width = 50;
            dtgLoaiHB.Columns[1].Width = 100;
            dtgLoaiHB.Columns[2].Width = 150;
            dtgLoaiHB.Columns[3].Width = 150;

            dtgLoaiHB.AllowUserToAddRows = false;
            dtgLoaiHB.AllowUserToDeleteRows = false;
            dtgLoaiHB.Width = this.ClientSize.Width;
            dtgLoaiHB.Height = this.ClientSize.Height;

            binding();
        }

        // Hàm load dữ liệu từ datagridview lên texbox
        private void binding()
        {
            txtMaHB.DataBindings.Clear();
            txtMaHB.DataBindings.Add("Text", dtgLoaiHB.DataSource, "MAHB");
            txtTenHB.DataBindings.Clear();
            txtTenHB.DataBindings.Add("Text", dtgLoaiHB.DataSource, "TENHB");
            txtMucHB.DataBindings.Clear();
            txtMucHB.DataBindings.Add("Text", dtgLoaiHB.DataSource, "MUCHB");
            txtSoTien.DataBindings.Clear();
            txtSoTien.DataBindings.Add("Text", dtgLoaiHB.DataSource, "SOTIEN");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_LoaiHB lhb = new DTO_LoaiHB(txtMaHB.Text, txtTenHB.Text, txtMucHB.Text, txtSoTien.Text);
                bus_loaihb.themLHB(lhb);
                txtMaHB.Text = "";
                txtTenHB.Text = "";
                txtMucHB.Text = "";
                txtSoTien.Text = "";
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                LoaiHocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_LoaiHB lhb = new DTO_LoaiHB(txtMaHB.Text, txtTenHB.Text, txtMucHB.Text, txtSoTien.Text);
                bus_loaihb.suaLHB(lhb);
                txtMaHB.Text = "";
                txtTenHB.Text = "";
                txtMucHB.Text = "";
                txtSoTien.Text = "";
                MessageBox.Show("Sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                LoaiHocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bus_loaihb.xoaLHB(txtMaHB.Text);
                txtMaHB.Text = "";
                txtTenHB.Text = "";
                txtMucHB.Text = "";
                txtSoTien.Text = "";
                MessageBox.Show("Xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                LoaiHocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
