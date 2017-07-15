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
using BUS;
using DTO;
using DAL;

namespace GUI
{
    public partial class HocBong : Form
    {

        BUS_LoaiHocBong bus_LoaiHB = new BUS_LoaiHocBong();
        public HocBong()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaHB.DataBindings.Clear();
            txtMaHB.DataBindings.Add("Text", dataGridView1.DataSource, "MAHB");
            txtSoTien.DataBindings.Clear();
            txtSoTien.DataBindings.Add("Text", dataGridView1.DataSource, "SOTIEN");                        
            txtMucHB.DataBindings.Clear();
            txtMucHB.DataBindings.Add("Text", dataGridView1.DataSource, "MUCHB");
            txtTenHB.DataBindings.Clear();
            txtTenHB.DataBindings.Add("Text", dataGridView1.DataSource, "TENHB");
        }
        class Bien
        {
            public static string maHB = "";
            public static string mucHB = "";
            public static string soTien = "";
            public static string tenHB = "";

        }
        
        private void HocBong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bus_LoaiHB.LoaiHB();
            dataGridView1.Columns[0].HeaderText = "Mã HB";
            dataGridView1.Columns[1].HeaderText = "Tên HB";
            dataGridView1.Columns[2].HeaderText = "Mức HB";
            dataGridView1.Columns[3].HeaderText = "Số tiền";

            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[2].Width = 10;
            dataGridView1.Columns[3].Width = 110;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
            binding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            DTO_LoaiHocBong LoaiHB = new DTO_LoaiHocBong(txtMaHB.Text,txtMucHB.Text,txtSoTien.Text,txtTenHB.Text);
            bus_LoaiHB.themLoaiHB(LoaiHB);
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            txtMucHB.Text = "";
            txtSoTien.Text = "";
            this.HocBong_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
            DTO_LoaiHocBong LoaiHB = new DTO_LoaiHocBong(txtMaHB.Text, txtMucHB.Text, txtSoTien.Text, txtTenHB.Text);
            bus_LoaiHB.suaLoaiHB(LoaiHB);
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            txtMucHB.Text = "";
            txtSoTien.Text = "";
            this.HocBong_Load(sender, e);
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
            bus_LoaiHB.xoaLoaiHB(txtMaHB.Text);
            txtMaHB.Text = "";
            txtTenHB.Text = "";
            txtMucHB.Text = "";
            txtSoTien.Text = "";
            this.HocBong_Load(sender, e);
            }
            catch
            {
                 MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại","Thông báo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.HocBong_Load(sender, e);
        }
    }
}
