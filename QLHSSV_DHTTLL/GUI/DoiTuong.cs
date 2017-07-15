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
    public partial class DoiTuong : Form
    {
        BUS_DoiTuong bus_DT = new BUS_DoiTuong();

        public DoiTuong()
        {
            InitializeComponent();
        }

        private void binding()
        {
            txtMaDT.DataBindings.Clear();
            txtMaDT.DataBindings.Add("Text", dataDT.DataSource, "MADT");
            txtTenDT.DataBindings.Clear();
            txtTenDT.DataBindings.Add("Text", dataDT.DataSource, "TENDOITUONG");
            txtCheDMG.DataBindings.Clear();
            txtCheDMG.DataBindings.Add("Text", dataDT.DataSource, "CHEDOMIENGIAM");
        }

        private void ThemDoiTuong_Load(object sender, EventArgs e)
        {
           
            dataDT.DataSource = bus_DT.DoiTuong();
            dataDT.Columns[0].HeaderText = "Mã ĐT";
            dataDT.Columns[1].HeaderText = "Tên ĐT";
            dataDT.Columns[2].HeaderText = "Chế độ miển giảm";

            dataDT.Columns[0].Width = 70;
            dataDT.Columns[1].Width = 250;
            dataDT.Columns[2].Width = 70;

            dataDT.AllowUserToAddRows = false;
            dataDT.AllowUserToDeleteRows = false;
            dataDT.Width = this.ClientSize.Width;
            dataDT.Height = this.ClientSize.Height;

            binding();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_DoiTuong DT = new DTO_DoiTuong(txtMaDT.Text, txtTenDT.Text, txtCheDMG.Text);
                bus_DT.themLop(DT);
                this.ThemDoiTuong_Load(sender, e);
            }
            catch
            {
                labThongBao.Text = "Thêm không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_DoiTuong DT = new DTO_DoiTuong(txtMaDT.Text, txtTenDT.Text, txtCheDMG.Text);
                bus_DT.suaLop(DT);
                this.ThemDoiTuong_Load(sender, e);
            }
            catch
            {
                labThongBao.Text = "Sửa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bus_DT.xoaLop(txtMaDT.Text);
                this.ThemDoiTuong_Load(sender, e);
            }
            catch
            {
                labThongBao.Text = "Xóa không thành công. Vui lòng kiểm tra lại mã sinh viên và mã đối tượng";
            }
        }

        private void txtTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
