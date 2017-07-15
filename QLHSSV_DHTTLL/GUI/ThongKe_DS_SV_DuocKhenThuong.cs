using BUS;
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
    public partial class ThongKe_DS_SV_DuocKhenThuong : Form
    {
        BUS_Lop bus_Lop = new BUS_Lop();
        BUS_KhenThuong bus_KT = new BUS_KhenThuong();
        public ThongKe_DS_SV_DuocKhenThuong()
        {
            InitializeComponent();
        }

        private void ThongKe_DS_SV_DuocKhenThuong_Load(object sender, EventArgs e)
        {
         
            comboLop.DataSource = bus_Lop.LOP();
            comboLop.DisplayMember = "MALOP";
            comboLop.ValueMember = "MALOP";
            comboLop.Text = "[Chọn lớp ...]";

            comboKT.DataSource = bus_KT.KT();
            comboKT.DisplayMember = "MAKT";
            comboKT.ValueMember = "MAKT";
            comboLop.Text = "[Chọn ...]";

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SV_Select_KhenThuongTableAdapter.Fill(this.QLHSSV_TTLLDataSet3.SV_Select_KhenThuong,comboLop.SelectedValue.ToString(),comboKT.SelectedValue.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
