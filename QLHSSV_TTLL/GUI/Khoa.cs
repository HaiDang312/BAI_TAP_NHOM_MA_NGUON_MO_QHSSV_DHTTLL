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
    
    public partial class Khoa : Form
    {

        BUS_Khoa bus_Khoa = new BUS_Khoa();

        public Khoa()
        {
            InitializeComponent();
        }
        
        private void binding()
        {
            txtMaKhoa.DataBindings.Clear();
            txtMaKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MAKHOA");
            txtTenKhoa.DataBindings.Clear();
            txtTenKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "TENKHOA");
        }
        private void Khoa_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bus_Khoa.KHOA();
            dataGridView1.Columns[0].HeaderText = "Mã khoa";
            dataGridView1.Columns[1].HeaderText = "Tên khoa";

            dataGridView1.Columns[0].Width = 10;
            dataGridView1.Columns[1].Width = 150;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
            //binding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
            DTO_Khoa khoa = new DTO_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
            bus_Khoa.themKhoa(khoa);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            this.Khoa_Load(sender, e);
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
            DTO_Khoa khoa = new DTO_Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
            bus_Khoa.suaKhoa(khoa);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            this.Khoa_Load(sender, e);
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
            bus_Khoa.xoaKhoa(txtMaKhoa.Text);
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            this.Khoa_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Khoa_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
