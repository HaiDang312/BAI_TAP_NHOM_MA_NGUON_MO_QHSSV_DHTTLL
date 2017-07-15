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
    public partial class dsSingVienChuyenNganh : Form
    {
        BUS_Nganh bus_CN = new BUS_Nganh();
        BUS_Lop bus_L = new BUS_Lop();
        BindingSource CN;
        public dsSingVienChuyenNganh()
        {
            InitializeComponent();
        }
        private void dsSingVienChuyenNganh_Load(object sender, EventArgs e)
        {
            CN = new BindingSource();
            CN.DataSource = bus_CN.SV_dsNganh();
            dataDT.DataSource = CN;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ tên SV";
            //dataDT.Columns[2].HeaderText = "Tên SV";
            dataDT.Columns[2].HeaderText = " Ngành ";
            dataDT.Columns[3].HeaderText = "Lớp";
            dataDT.Columns[4].HeaderText = "Khoa";
            dataDT.Columns[5].HeaderText = "Giới tính";
            dataDT.Columns[6].HeaderText = "Ngày sinh";
            dataDT.Columns[7].HeaderText = "Địa chỉ";


            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 20;
            dataDT.Columns[2].Width = 30;
            dataDT.Columns[3].Width = 30;
            dataDT.Columns[4].Width = 30;
            dataDT.Columns[5].Width = 10;
            dataDT.Columns[6].Width = 20;
            dataDT.Columns[7].Width = 70;
            //dataDT.Columns[8].Width = 50;

            comboNganh.DataSource = bus_CN.NGANH();
            comboNganh.DisplayMember = "TENNGANH";
            comboNganh.ValueMember = "MANGANH";
            comboNganh.SelectedIndex = -1;
            comboNganh.Text = "[Chọn ngành ...]"; 
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = "[Họ Tên SV] LIKE '" + txtTimKiem.Text + "%'";
            CN.Filter = str;
            dataDT.DataSource = CN;
        }

        private void comboNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboNganh.SelectedIndex == -1) || (comboNganh.Text == ""))
                dataDT.DataSource = bus_CN.SV_dsNganh();
            else
                dataDT.DataSource = bus_CN.SV_dsLop(comboNganh.SelectedValue.ToString());
        }
    }
}
