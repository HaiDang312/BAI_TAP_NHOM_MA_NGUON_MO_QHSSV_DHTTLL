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
    public partial class svHocBong : Form
    {
        BUS_SVHocBong bus_HB = new BUS_SVHocBong();
        BUS_SinhVien bus_sv = new BUS_SinhVien();
        BUS_LoaiHocBong bus_LoaiHB = new BUS_LoaiHocBong();
        public svHocBong()
        {
            InitializeComponent();
        }

        private void binding()
        {
            txtHocKy.DataBindings.Clear();
            txtHocKy.DataBindings.Add("Text", dataHB.DataSource, "HOCKY");
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dataHB.DataSource, "MASV");
            combMaHB.DataBindings.Clear();
            combMaHB.DataBindings.Add("Text", dataHB.DataSource, "MAHB");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_SVHocBong svHB = new DTO_SVHocBong(combMaHB.SelectedValue.ToString(), txtMaSV.Text,txtHocKy.Text);
                bus_HB.themSVHB(svHB);
                combMaHB.Text = "--Chọn--";
                txtMaSV.Text = "";
                txtHocKy.Text = "";
                this.svHocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void svHocBong_Load(object sender, EventArgs e)
        {
            combMaHB.DataSource = bus_LoaiHB.LoaiHB();
            combMaHB.DisplayMember = "TENHB";
            combMaHB.ValueMember = "MAHB";

            dataHB.DataSource = bus_HB.svHB();
            dataHB.Columns[0].HeaderText = "Mã HB";
            dataHB.Columns[1].HeaderText = "Mã SV";
            dataHB.Columns[2].HeaderText = "Học kỳ";

            dataHB.Columns[0].Width = 70;
            dataHB.Columns[1].Width = 250;
            dataHB.Columns[2].Width = 70;

            dataHB.AllowUserToAddRows = false;
            dataHB.AllowUserToDeleteRows = false;
            dataHB.Width = this.ClientSize.Width;
            dataHB.Height = this.ClientSize.Height;

            binding();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_SVHocBong svHB = new DTO_SVHocBong(combMaHB.SelectedValue.ToString(), txtMaSV.Text, txtHocKy.Text);
                bus_HB.suaSVHB(svHB);
                combMaHB.Text = "--Chọn--";
                txtMaSV.Text = "";
                txtHocKy.Text = "";
                this.svHocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                bus_HB.xoaSVHB(combMaHB.SelectedValue.ToString(), txtMaSV.Text, txtHocKy.Text);
                combMaHB.Text = "--Chọn--";
                txtMaSV.Text = "";
                txtHocKy.Text = "";
                this.svHocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
