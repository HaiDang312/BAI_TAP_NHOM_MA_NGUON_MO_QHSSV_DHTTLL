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
    public partial class HocBong : Form
    {
        BUS_HocBong bus_hb = new BUS_HocBong();
        public HocBong()
        {
            InitializeComponent();
        }

        private void HocBong_Load(object sender, EventArgs e)
        {
            dtgHB.DataSource = bus_hb.HB();
            dtgHB.Columns[0].HeaderText = "Mã học bổng";
            dtgHB.Columns[1].HeaderText = "Mã sinh viên";
            dtgHB.Columns[2].HeaderText = "Học kỳ";

            dtgHB.Columns[0].Width = 50;
            dtgHB.Columns[1].Width = 100;
            dtgHB.Columns[2].Width = 150;

            dtgHB.AllowUserToAddRows = false;
            dtgHB.AllowUserToDeleteRows = false;
            dtgHB.Width = this.ClientSize.Width;
            dtgHB.Height = this.ClientSize.Height;

            // lấy mã học bổng từ bảng HOCBONG vào combobox
            txtMaHB.DataSource = bus_hb.LHB();
            txtMaHB.DisplayMember = "MAHB";
            txtMaHB.ValueMember = "MAHB";

            // lấy mã sinh viên từ bảng SINHVIEN vào combobox
            txtMaSV.DataSource = bus_hb.SV();
            txtMaSV.DisplayMember = "MASV";
            txtMaSV.ValueMember = "MASV";

            binding();
        }

        // Hàm load dữ liệu từ datagridview lên texbox
        private void binding()
        {
            txtMaHB.DataBindings.Clear();
            txtMaHB.DataBindings.Add("Text", dtgHB.DataSource, "MAHB");
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtgHB.DataSource, "MASV");
            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", dtgHB.DataSource, "HOCKY");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_HocBong hb = new DTO_HocBong(txtMaHB.SelectedValue.ToString(), txtMaSV.SelectedValue.ToString(), txtHocKy.Text);
                bus_hb.themHB(hb);
                txtMaHB.Text = "";
                txtMaSV.Text = "";
                txtHocKy.Text = "";
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                HocBong_Load(sender, e);
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
                DTO_HocBong hb = new DTO_HocBong(txtMaHB.SelectedValue.ToString(), txtMaSV.SelectedValue.ToString(), txtHocKy.Text);
                bus_hb.suaHB(hb);
                txtMaHB.Text = "";
                txtMaSV.Text = "";
                txtHocKy.Text = "";
                MessageBox.Show("Sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                HocBong_Load(sender, e);
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
                bus_hb.xoaHB(txtMaHB.SelectedValue.ToString(), txtMaSV.SelectedValue.ToString());
                txtMaHB.Text = "";
                txtMaSV.Text = "";
                txtHocKy.Text = "";
                MessageBox.Show("Xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                HocBong_Load(sender, e);
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
