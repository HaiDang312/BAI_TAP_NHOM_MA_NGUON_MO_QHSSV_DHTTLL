using BUS;
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
    public partial class dsSinhVienHocBong : Form
    {
        BUS_SVHocBong bus_svHB = new BUS_SVHocBong();
        BUS_Lop bus_Lop = new BUS_Lop();
        BindingSource svHB;

        public dsSinhVienHocBong()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = "[Ma SV] LIKE '" + txtTimKiem.Text + "%'";
            svHB.Filter = str;
            dataDT.DataSource = svHB;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dsSinhVienTheoLop_Load(object sender, EventArgs e)
        {
            svHB = new BindingSource();
            svHB.DataSource = bus_svHB.ds_svHB();
            dataDT.DataSource = svHB;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ tên SV";
            dataDT.Columns[2].HeaderText = "Lớp";
            dataDT.Columns[3].HeaderText = "Tên HB";
            dataDT.Columns[4].HeaderText = "Số tiền";
            dataDT.Columns[5].HeaderText = "Học kỳ";

            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 50;
            dataDT.Columns[2].Width = 40;
            dataDT.Columns[3].Width = 60;
            dataDT.Columns[4].Width = 40;
            dataDT.Columns[5].Width = 30;

            comboLop.DataSource = bus_Lop.LOP();
            comboLop.DisplayMember = "MALOP";
            comboLop.ValueMember = "MALOP";
            comboLop.SelectedIndex = -1;
            comboLop.Text = "[Chọn lớp ...]"; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if ((comboLop.SelectedIndex == -1) || (comboLop.Text == ""))
                dataDT.DataSource = bus_svHB.ds_svHB();
            else
                dataDT.DataSource = bus_svHB.ds_svHB_Lop(comboLop.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dsSinhVienTheoLop_Load(sender, e);
        }
    }
}
