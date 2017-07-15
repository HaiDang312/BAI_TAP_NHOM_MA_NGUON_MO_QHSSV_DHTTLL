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
    public partial class KhenThuong_KyLuat : Form
    {
        BUS_KhenThuong bus_kt = new BUS_KhenThuong();
        BUS_KyLuat bus_kl = new BUS_KyLuat();

        public KhenThuong_KyLuat()
        {
            InitializeComponent();
        }

        private void KhenThuong_KyLuat_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                dsKhenThuong ds = new dsKhenThuong();
                ds.Show();
            }
            else
            {
                dsKyLuat ds = new dsKyLuat();
                ds.Show();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                try
                {
                    DTO_KhenThuong kt = new DTO_KhenThuong(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    bus_kt.themKT(kt);
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtGhichu.Text = "";
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
                    DTO_KyLuat kl = new DTO_KyLuat(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    bus_kl.themKL(kl);
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtGhichu.Text = "";
                    MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại!", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (radKT.Checked)
            {
                try
                {
                    DTO_KhenThuong kt = new DTO_KhenThuong(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    bus_kt.suaKT(kt);
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtGhichu.Text = "";
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
                    DTO_KyLuat kl = new DTO_KyLuat(txtMa.Text, txtTen.Text, txtGhichu.Text);
                    bus_kl.suaKL(kl);
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtGhichu.Text = "";
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
                    bus_kt.xoaKT(txtMa.Text);
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtGhichu.Text = "";
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
                    bus_kl.xoaKL(txtMa.Text);
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtGhichu.Text = "";
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
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
