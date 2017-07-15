using BUS;
using DTO;
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
    public partial class SVDoiTuong : Form
    {
        BUS_SVDoiTuong bus_svdt = new BUS_SVDoiTuong();
        public SVDoiTuong()
        {
            InitializeComponent();
        }

        private void btnDS_Click(object sender, EventArgs e)
        {
            DSSVDoiTuong ds = new DSSVDoiTuong();
            ds.Show();
        }

        private void SVDoiTuong_Load(object sender, EventArgs e)
        {
            // lấy mã sinh viên từ bảng SINHVIEN vào combobox
            cbMaSV.DataSource = bus_svdt.SV();
            cbMaSV.DisplayMember = "TENSV";
            cbMaSV.ValueMember = "MASV";

            // lấy mã sinh viên từ bảng SINHVIEN vào combobox
            cbMaDT.DataSource = bus_svdt.DT();
            cbMaDT.DisplayMember = "TENDOITUONG";
            cbMaDT.ValueMember = "MADT";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_SVDoiTuong dt = new DTO_SVDoiTuong(cbMaSV.SelectedValue.ToString(), cbMaDT.SelectedValue.ToString());
                bus_svdt.themDT(dt);
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
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
                DTO_SVDoiTuong dt = new DTO_SVDoiTuong(cbMaSV.SelectedValue.ToString(), cbMaDT.SelectedValue.ToString());
                bus_svdt.suaDT(dt);
                MessageBox.Show("Sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
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
                bus_svdt.xoaDT(cbMaSV.SelectedValue.ToString(), cbMaDT.SelectedValue.ToString());
                MessageBox.Show("Xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
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
