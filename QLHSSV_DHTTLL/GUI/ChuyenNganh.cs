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
using DTO;
using DAL;
using BUS;

namespace GUI
{

    public partial class ChuyenNganh : Form
    {
        BUS_Nganh bus_Nganh = new BUS_Nganh();
        public ChuyenNganh()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaCN.DataBindings.Clear();
            txtMaCN.DataBindings.Add("Text", dataGridView1.DataSource, "MANGANH");
            txtTenCN.DataBindings.Clear();
            txtTenCN.DataBindings.Add("Text", dataGridView1.DataSource, "TENNGANH");
        }
        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus_Nganh.NGANH();
            dataGridView1.Columns[0].HeaderText = "Mã CN";
            dataGridView1.Columns[1].HeaderText = "Tên chuyên ngành";

            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;

            binding();
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            DTO_ChuyenNganh Nganh = new DTO_ChuyenNganh(txtMaCN.Text, txtTenCN.Text);
            bus_Nganh.themNganh(Nganh);
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            this.ChuyenNganh_Load(sender, e);
            }
            catch
            {
                 MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại","Thông báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            DTO_ChuyenNganh Nganh = new DTO_ChuyenNganh(txtMaCN.Text, txtTenCN.Text);
            bus_Nganh.suaNganh(Nganh);
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            this.ChuyenNganh_Load(sender, e);
            }
            catch
            {
                 MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại","Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                 "Error", MessageBoxButtons.YesNoCancel);
            bus_Nganh.xoaNganh(txtMaCN.Text);
            txtMaCN.Text = "";
            txtTenCN.Text = "";
            this.ChuyenNganh_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ChuyenNganh_Load(sender, e);
        }
    }
}
