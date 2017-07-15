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
    public partial class TimKiemSinhVienTheoMonHoc : Form
    {
        BUS_MonHoc bus_mh = new BUS_MonHoc();
        BindingSource MH;

        public TimKiemSinhVienTheoMonHoc()
        {
            InitializeComponent();
        }
        
        private void dsSingVienTheoKhoa_Load(object sender, EventArgs e)
        {
            MH = new BindingSource();
            MH.DataSource = bus_mh.ds_SV();
            dataDT.DataSource = MH;
            dataDT.Columns[0].HeaderText = "Mã SV";
            dataDT.Columns[1].HeaderText = "Họ tên SV";
            dataDT.Columns[2].HeaderText = "Môn";
            dataDT.Columns[3].HeaderText = "Học kỳ";
            dataDT.Columns[4].HeaderText = "Điểm CC";
            dataDT.Columns[5].HeaderText = "Điểm TX";
            dataDT.Columns[6].HeaderText = "Điểm GK";
            dataDT.Columns[7].HeaderText = "Điểm CK";
            dataDT.Columns[8].HeaderText = "Điểm Tổng kết";


            //Có thể thiết lập độ rộng của từng cột
            dataDT.Columns[0].Width = 20;
            dataDT.Columns[1].Width = 50;
            dataDT.Columns[2].Width = 70;
            dataDT.Columns[3].Width = 20;
            dataDT.Columns[4].Width = 20;
            dataDT.Columns[5].Width = 20;
            dataDT.Columns[6].Width = 20;
            dataDT.Columns[7].Width = 20;
            dataDT.Columns[8].Width = 50;

            comboMH.DataSource = bus_mh.MonHoc();
            comboMH.DisplayMember = "TENMH";
            comboMH.ValueMember = "MAMH";
            comboMH.SelectedIndex = -1;
            comboMH.Text = "[ Chọn môn học ...]"; 
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string str = "[Ma SV] LIKE '" + txtTimKiem.Text + "%'";
            MH.Filter = str;
            dataDT.DataSource = MH;
        }

        private void comboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if ((comboMH.SelectedIndex == -1) || (comboMH.Text == ""))
                dataDT.DataSource = bus_mh.ds_SV();
            else
                dataDT.DataSource = bus_mh.ds_SV_MH(comboMH.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dsSingVienTheoKhoa_Load(sender, e);
        }
    }
}
