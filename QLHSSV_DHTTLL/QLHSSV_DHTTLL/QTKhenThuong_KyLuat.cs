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

namespace QLHSSV_DHTTLL
{
    public partial class QTKhenThuong_KyLuat : Form
    {
        BUS_QTKhenThuong bus_qtkt = new BUS_QTKhenThuong();
        BUS_QTKyLuat bus_qtkl = new BUS_QTKyLuat();
        public QTKhenThuong_KyLuat()
        {
            InitializeComponent();
        }

        private void QTKhenThuong_KyLuat_Load(object sender, EventArgs e)
        {
            // lấy mã khoa từ bảng khoa vào combobox
            cbMaSV.DataSource = bus_qtkt.SV();
            cbMaSV.DisplayMember = "MASV";
            cbMaSV.ValueMember = "MASV";

            // lấy mã khoa từ bảng khoa vào combobox
            cbMaKtKl.DataSource = bus_qtkt.KT();
            cbMaKtKl.DisplayMember = "MAKT";
            cbMaKtKl.ValueMember = "MAKT";

            // lấy mã khoa từ bảng khoa vào combobox
            cbMaKl.DataSource = bus_qtkl.KL();
            cbMaKl.DisplayMember = "MAKL";
            cbMaKl.ValueMember = "MAKL";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                DSSVKhenThuong ds = new DSSVKhenThuong();
                ds.Show();
            }
            else
            {
                DSSVKyLuat ds = new DSSVKyLuat();
                ds.Show();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                try
                {
                    DTO_QTKhenThuong qtkt = new DTO_QTKhenThuong(cbMaSV.SelectedValue.ToString(), cbMaKtKl.SelectedValue.ToString(), DateTime.Parse(txtNgayKtKl.Text).ToString("MM/dd/yyyy"));
                    bus_qtkt.themQTKT(qtkt);
                    txtNgayKtKl.Text = "";
                    MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {

                    DTO_QTKyLuat qtkl = new DTO_QTKyLuat(cbMaSV.SelectedValue.ToString(), cbMaKl.SelectedValue.ToString(), DateTime.Parse(txtNgayKtKl.Text).ToString("MM/dd/yyyy"), DateTime.Parse(txtNgayHH.Text).ToString("MM/dd/yyyy"));
                    bus_qtkl.themQTKL(qtkl);
                    txtNgayKtKl.Text = "";
                    txtNgayHH.Text = "";
                    MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void radKL_CheckedChanged(object sender, EventArgs e)
        {
            txtNgayHH.ReadOnly = false;
            cbMaKtKl.Enabled = !radKL.Checked;
        }

        private void radKT_CheckedChanged(object sender, EventArgs e)
        {
            txtNgayHH.ReadOnly = true;
            cbMaKl.Enabled = !radKT.Checked;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                try
                {
                    DTO_QTKhenThuong qtkt = new DTO_QTKhenThuong(cbMaSV.SelectedValue.ToString(), cbMaKtKl.SelectedValue.ToString(), DateTime.Parse(txtNgayKtKl.Text).ToString("MM/dd/yyyy"));
                    bus_qtkt.suaQTKT(qtkt);
                    txtNgayKtKl.Text = "";
                    MessageBox.Show("Sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {

                    DTO_QTKyLuat qtkl = new DTO_QTKyLuat(cbMaSV.SelectedValue.ToString(), cbMaKl.SelectedValue.ToString(), DateTime.Parse(txtNgayKtKl.Text).ToString("MM/dd/yyyy"), DateTime.Parse(txtNgayHH.Text).ToString("MM/dd/yyyy"));
                    bus_qtkl.suaQTKL(qtkl);
                    txtNgayKtKl.Text = "";
                    txtNgayHH.Text = "";
                    MessageBox.Show("Sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                try
                {
                    bus_qtkt.xoaQTKT(cbMaSV.SelectedValue.ToString(), cbMaKtKl.SelectedValue.ToString());
                    txtNgayKtKl.Text = "";
                    MessageBox.Show("Xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
            else
            {
                try
                {
                    bus_qtkl.xoaQTKL(cbMaSV.SelectedValue.ToString(), cbMaKl.SelectedValue.ToString());
                    txtNgayKtKl.Text = "";
                    txtNgayHH.Text = "";
                    MessageBox.Show("Xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Xóa không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
