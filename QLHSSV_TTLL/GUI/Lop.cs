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


        BUS_Lop bus_lop = new BUS_Lop(); // Tạo đối tượng kết nối
 

        public Lop()
        {
            InitializeComponent();
        }

        // Tạo hàm binding khi người dùng kich vào đối tượng nào đó ở data thi nó xẽ hiện thông tin lên các textbox
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

            
            comKhoa.DataSource = bus_lop.KHOA(); // Gọi hàm khoa bên BUS_Lop
            comKhoa.DisplayMember = "TenKhoa";  // Hiên tên lớp lên comboKhoa
            comKhoa.ValueMember = "MaKhoa";

            dataGridView1.DataSource = bus_lop.LOP(); // Hiện danh sách lớp lên data
            dataGridView1.Columns[0].HeaderText = "Mã lớp";
            dataGridView1.Columns[1].HeaderText = "Tên lớp";
            dataGridView1.Columns[2].HeaderText = "Mã khoa";
             // Quy định đọ rong của các ô trong data
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
                DTO_Lop Lop = new DTO_Lop(txtMaLop.Text, txtTenLop.Text, comKhoa.SelectedValue.ToString());  // Tạo đối tượng Lop với các thược tính mà người dungfnhapj vào ở giao diện
                bus_lop.themLop(Lop); // gọi hàm them lớp bên BUS_Lop
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
