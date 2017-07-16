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
    public partial class DoiTuong : Form
    {
        BUS_DoiTuong bus_dt = new BUS_DoiTuong();
        public DoiTuong()
        {
            InitializeComponent();
        }

        private void DoiTuong_Load(object sender, EventArgs e)
        {
            dgDT.DataSource = bus_dt.DT();
            dgDT.Columns[0].HeaderText = "Mã đối tượng";
            dgDT.Columns[1].HeaderText = "Tên đối tượng";
            dgDT.Columns[2].HeaderText = "Chế độ miễn giảm";
           

            dgDT.Columns[0].Width = 150;
            dgDT.Columns[1].Width = 200;
            dgDT.Columns[2].Width = 150;
          

            dgDT.AllowUserToAddRows = false;
            dgDT.AllowUserToDeleteRows = false;
            dgDT.Width = this.ClientSize.Width;
            dgDT.Height = this.ClientSize.Height;

            binding();

        }

        // Hàm load dữ liệu từ datagridview lên texbox
        private void binding()
        {
            txtMaDT.DataBindings.Clear();
            txtMaDT.DataBindings.Add("Text", dgDT.DataSource, "MADT");
            txtTenDT.DataBindings.Clear();
            txtTenDT.DataBindings.Add("Text", dgDT.DataSource, "TENDOITUONG");
            txtMG.DataBindings.Clear();
            txtMG.DataBindings.Add("Text", dgDT.DataSource, "CHEDOMIENGIAM");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_DoiTuong dt = new DTO_DoiTuong(txtMaDT.Text, txtTenDT.Text, txtMG.Text);
                bus_dt.themDT(dt);
                txtMaDT.Text = "";
                txtTenDT.Text = "";
                txtMG.Text = "";
                MessageBox.Show("Thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                DoiTuong_Load(sender, e);
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
                DTO_DoiTuong dt = new DTO_DoiTuong(txtMaDT.Text, txtTenDT.Text, txtMG.Text);
                bus_dt.suaDT(dt);
                txtMaDT.Text = "";
                txtTenDT.Text = "";
                txtMG.Text = "";
                MessageBox.Show("Sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                DoiTuong_Load(sender, e);
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
                bus_dt.xoaDT(txtMaDT.Text);
                txtMaDT.Text = "";
                txtTenDT.Text = "";
                txtMG.Text = "";
                MessageBox.Show("Xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                DoiTuong_Load(sender, e);
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
