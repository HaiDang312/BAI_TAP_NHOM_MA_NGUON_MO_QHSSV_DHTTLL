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
using BUS;
using DAL;

namespace GUI
{
    public partial class Lop : Form
    {


        BUS_Lop bus_lop = new BUS_Lop();
 

        public Lop()
        {
            InitializeComponent();
        }
        private void binding()
        {
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", dataGridView1.DataSource, "MALOP");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", dataGridView1.DataSource, "TENLOP");
            comKhoa.DataBindings.Clear();
            comKhoa.DataBindings.Add("Text", dataGridView1.DataSource, "MAKHOA");
        }
        private void Lop_Load(object sender, EventArgs e)
        {

            
            comKhoa.DataSource = bus_lop.KHOA();
            comKhoa.DisplayMember = "TenKhoa";
            comKhoa.ValueMember = "MaKhoa";

            dataGridView1.DataSource = bus_lop.LOP();
            dataGridView1.Columns[0].HeaderText = "Mã lớp";
            dataGridView1.Columns[1].HeaderText = "Tên lớp";
            dataGridView1.Columns[2].HeaderText = "Mã khoa";

            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width =70;

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
            DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());
            bus_lop.themLop(Lop);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            this.Lop_Load(sender, e);
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
            DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());
            bus_lop.suaLop(Lop);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            this.Lop_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Sửa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {     
            try
            { 
            bus_lop.xoaLop(txtMaLop.Text);
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            this.Lop_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công. Vui lòng kiểm tra lại", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Lop_Load(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
